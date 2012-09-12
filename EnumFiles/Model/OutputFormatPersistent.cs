using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EnumFiles.Model
{
    /// <summary>
    /// OutputFormatをファイルに保存するためのルーチン群
    /// </summary>
    public static class OutputFormatPersistent
    {
        /// <summary>
        /// 拡張子
        /// </summary>
        public static readonly string FILE_EXT = "tmpl";

        /// <summary>
        /// テンプレート
        /// </summary>
        public static readonly string DIR_NAME = "templates";

        /// <summary>
        /// XMLに変換するためのシリアライザ
        /// </summary>
        private static readonly XmlSerializer xmlSerializer = new XmlSerializer(typeof(OutputFormat));


        /// <summary>
        /// フォルダを複数指定し、そのフォルダ下にある、すべてのOutputFormatを読み取って返す.
        /// </summary>
        /// <param name="dirs">フォルダのリスト</param>
        /// <returns>読み取ったOutputFormatオブジェクトの列挙</returns>
        public static IEnumerable<OutputFormat> Load(params string[] dirs)
        {
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                if (dirInfo.Exists)
                {
                    foreach (FileInfo fileInfo in dirInfo.GetFiles("*." + FILE_EXT))
                    {
                        OutputFormat of;
                        try
                        {
                            of = Load(fileInfo);
                        }
                        catch (Exception ex)
                        {
                            // 例外が発生した場合は、そのアイテムは無視して継続する.
                            System.Diagnostics.Trace.WriteLine("file=" + fileInfo + "/exception=" + ex);
                            continue;
                        }
                        yield return of;
                    }
                }
            }
            yield break;
        }

        /// <summary>
        /// 指定したファイルからOutputFormatオブジェクトをロードする.
        /// </summary>
        /// <param name="file">ファイル</param>
        /// <returns>OutputFormatオブジェクト</returns>
        public static OutputFormat Load(FileInfo file)
        {
            if (file == null) throw new ArgumentException("nullは指定できません");
            System.Diagnostics.Trace.WriteLine("Load: " + file);
            using (var fs = file.OpenRead())
            {
                return (OutputFormat)xmlSerializer.Deserialize(fs);
            }
        }

        /// <summary>
        /// 指定したディレクトリ上にOutputFormatオブジェクトを保存する.
        /// </summary>
        /// <param name="of">保存するOutputFormatオブジェクト</param>
        /// <param name="dirInfo">保存先ディレクトリ</param>
        public static void Save(OutputFormat of, DirectoryInfo dirInfo)
        {
            if (of == null || dirInfo == null) throw new ArgumentException("nullは指定できません");
            string defname = "template-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string fileName = GetSafeName(of.Name, defname) + "." + FILE_EXT;

            // ディレクトリが存在しなければ作成する.
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            var path = Path.Combine(dirInfo.FullName, fileName);
            System.Diagnostics.Trace.WriteLine("Save: " + path);

            var fileInfo = new FileInfo(path);
            using (var fs = fileInfo.OpenWrite())
            {
                xmlSerializer.Serialize(fs, of);
            }
        }

        /// <summary>
        /// 指定したディレクトリ上のOutputFormatオブジェクトを削除し、trueを返す.
        /// 指定したディレクトリにファイルがないか、読み取り専用である場合は削除せずfalseを返す.
        /// 削除中に失敗した場合は例外が発生する.
        /// </summary>
        /// <param name="of">OutputFormatオブジェクト</param>
        /// <param name="dirInfo">対象ディレクトリ</param>
        /// <returns>削除された場合はtrue、削除できない場合はfalse</returns>
        public static bool Delete(OutputFormat of, DirectoryInfo dirInfo)
        {
            if (of == null || dirInfo == null) throw new ArgumentException("nullは指定できません");
            string defname = "template-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string fileName = GetSafeName(of.Name, defname) + "." + FILE_EXT;

            var path = Path.Combine(dirInfo.FullName, fileName);
            System.Diagnostics.Trace.WriteLine("Delete: " + path);

            var fileInfo = new FileInfo(path);
            if (fileInfo.Exists && !fileInfo.IsReadOnly)
            {
                fileInfo.Delete();
                return true;
            }
            return false;
        }

        /// <summary>
        /// ファイル名に使えない文字一覧
        /// </summary>
        private static readonly char[] INVALID_CHARS = "\\|;:<>,\"/*?.".ToCharArray();

        /// <summary>
        /// 名称からファイル名をマッピングする.
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="defname">名称省略時に設定するファイル名</param>
        /// <returns>マッピングされたファイル名</returns>
        public static string GetSafeName(string name, string defname = "")
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return defname;
            }
            name = name.Trim();
            foreach (char ch in INVALID_CHARS)
            {
                name = name.Replace(ch, '_');
            }
            return name;
        }

        /// <summary>
        /// 複数のOutputFormatの名前からファイル名にマップした結果、ファイル名が重複するものについて列挙する.
        /// </summary>
        /// <param name="fmts">検査対象のOutputFormat</param>
        /// <returns>出力ファイル名が重複するOutputFormatのコレクション</returns>
        public static IEnumerable<OutputFormat> CheckConflectFileName(IEnumerable<OutputFormat> fmts)
        {
            if (fmts != null)
            {
                var dupchk = new Dictionary<string, OutputFormat>();
                foreach (OutputFormat fmt in fmts)
                {
                    string fileName = GetSafeName(fmt.Name);
                    OutputFormat dupItem;
                    if (dupchk.TryGetValue(fileName, out dupItem))
                    {
                        // 重複あり
                        if (dupItem != null)
                        {
                            dupchk[fileName] = null;
                            yield return dupItem;
                        }
                        yield return fmt;
                    }
                    else
                    {
                        // 重複なし
                        dupchk.Add(fileName, fmt);
                    }
                }
            }
            yield break;
        }
    }
}

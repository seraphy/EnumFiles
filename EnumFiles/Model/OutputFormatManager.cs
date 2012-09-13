using EnumFiles.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EnumFiles.Model
{
    /// <summary>
    /// OutputFormat定義の一覧を管理する
    /// </summary>
    public class OutputFormatManager
    {
        /// <summary>
        /// 読み込まれたOutputFormatを保持、管理するクラス.
        /// </summary>
        [Serializable]
        protected sealed class OutputFormatHolder
        {
            /// <summary>
            /// 読み込み元のディレクトリ情報
            /// </summary>
            public PersistentDirectoryInfo directoryInfo { set; get; }

            /// <summary>
            /// 読み込んだ定義情報、ファイルの内容を正とする。
            /// 新規の場合はnullに設定される.
            /// </summary>
            public OutputFormat original { set; get; }

            /// <summary>
            /// 更新されたかもしれない情報、
            /// 削除された場合はnullに設定される.
            /// </summary>
            public OutputFormat current { set; get; }

            /// <summary>
            /// 読み込み後に定義が変更されているか示す
            /// </summary>
            public bool Modified
            {
                get
                {
                    return original != current;
                }
            }

            /// <summary>
            /// 診断用文字列を取得する
            /// </summary>
            /// <returns>診断用文字列</returns>
            public override string ToString()
            {
                return StringUtils.ReflectionToString(this);
            }
        }

        /// <summary>
        /// 定義を読み込むディレクトリのリスト、読み込み順
        /// </summary>
        private List<PersistentDirectoryInfo> dirs = new List<PersistentDirectoryInfo>();

        /// <summary>
        /// ディレクトリの定義順に読み込まれた、すべての定義のリスト
        /// </summary>
        private List<OutputFormatHolder> caches = new List<OutputFormatHolder>();

        /// <summary>
        /// 定義の名前と定義とディレクトリのペア、名前による索引を可能とする.
        /// 同一の名前が複数ある場合は、最後に読み込まれた定義が設定される.
        /// (つまり、その定義を読み込んだディレクトリよりも後方のディレクトリには
        /// 定義が存在しないことを保証する)
        /// </summary>
        private SortedDictionary<string, OutputFormatHolder> dict = new SortedDictionary<string, OutputFormatHolder>();


        /// <summary>
        /// 読み込むディレクトリを登録する.
        /// 登録した順番にディレクトリが読み込まれる.
        /// </summary>
        /// <param name="dir">ディレクトリ、null不可</param>
        public void AddDirectory(PersistentDirectoryInfo dir)
        {
            if (dir == null) throw new ArgumentException();
            dirs.Add(dir);
        }

        /// <summary>
        /// 指定したディレクトリを登録解除する.
        /// 該当するディレクトリが登録されていなければ何もしない.
        /// </summary>
        /// <param name="dir">ディレクトリ、null可</param>
        public void RemoveDirectory(PersistentDirectoryInfo dir)
        {
            if (dir != null)
            {
                dirs.Remove(dir);
            }
        }

        /// <summary>
        /// ディレクトリの一覧を登録順に返す.
        /// </summary>
        public IEnumerable<PersistentDirectoryInfo> Directories
        {
            get
            {
                return dirs;
            }
        }

        /// <summary>
        /// ディレクトリの登録をクリアする.
        /// </summary>
        public void RemoveAllDirectories()
        {
            dirs.Clear();
        }

        /// <summary>
        /// すべてのキャッシュをクリアする.
        /// </summary>
        public virtual void Clear()
        {
            caches.Clear();
            dict.Clear();
        }

        /// <summary>
        /// 対象ディレクトリの登録順に、そのディレクトリに存在する設定を
        /// すべて読み込みキャッシュする.
        /// </summary>
        public virtual void Load()
        {
            Clear();

            // すべてのディレクトリから存在する設定をすべて取り込む
            // (ディレクトリの登録順に格納する)
            foreach (var dirInfo in Directories)
            {
                string dir = dirInfo.Path;
                foreach (var outputFormat in OutputFormatPersistent.Load(dir))
                {
                    var cache = new OutputFormatHolder()
                    {
                        original = outputFormat,
                        current = outputFormat.duplicate(),
                        directoryInfo = dirInfo
                    };
                    caches.Add(cache);
                }
            }

            // 埋め込み設定を登録する
            caches.Add(CreateDefaultFormat("text"));
            caches.Add(CreateDefaultFormat("xml"));

            // 名前で設定をまとめる
            // 同一名がある場合は後方のもので上書きする.
            foreach (var cache in caches)
            {
                OutputFormat of = cache.original;
                string name = of.Name ?? "";

                dict[name] = cache;
            }
        }

        /// <summary>
        /// 既定の出力フォーマット(固定)を生成する.
        /// </summary>
        /// <returns></returns>
        protected virtual OutputFormatHolder CreateDefaultFormat(string typ)
        {
            OutputFormat of;
            switch (typ)
            {
                case "xml":
                    of = new OutputFormat()
                    {
                        Name = "Simple XML",
                        Header = "<files>",
                        EachItem = "<file sha1=\"%SHA1:XML%\">%PATH:XML%</file>",
                        Footer = "</files>"
                    };
                    break;

                case "text":
                default:
                    of = new OutputFormat()
                    {
                        Name = "Plain Text",
                        EachItem = "%PATH%\t%SHA1%"
                    };
                    break;
            }
            return new OutputFormatHolder()
                {
                    directoryInfo = new PersistentDirectoryInfo(".", false),
                    original = of,
                    current = of.duplicate()
                };
        }

        /// <summary>
        /// 現在保持しているすべてのOutputFormat設定の一覧を返す.
        /// 同名の設定が複数あった場合はもっとも最後に読み込まれた設定が有効となります.
        /// 読み込み順はディレクトリの登録順です.
        /// </summary>
        public virtual IEnumerable<OutputFormat> AllItems
        {
            get
            {
                foreach (var cache in dict.Values)
                {
                    if (cache.current != null)
                    {
                        yield return cache.current;
                    }
                }
            }
        }

        /// <summary>
        /// 名前を指定して該当するOutputFormat設定を取得し、trueを返す.
        /// 設定が存在しない場合はfalseを返す.
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="of">設定の格納先</param>
        /// <returns>設定が存在したらtrue、存在しなければfalse</returns>
        public virtual bool TryGetValue(string name, out OutputFormat of)
        {
            OutputFormatHolder ret;
            if (dict.TryGetValue(name, out ret))
            {
                of = ret.current;
            }
            else
            {
                of = null;
            }
            return of != null;
        }

        /// <summary>
        /// 名前を指定して該当するOutputFormat設定を取得・設定する.
        /// 取得時、該当しない場合はnullを返す.
        /// 設定時、nullの場合は削除、それ以外の場合は更新を行う.
        /// </summary>
        /// <param name="name">設定の名前</param>
        /// <returns>設定</returns>
        public virtual OutputFormat this[string name]
        {
            get
            {
                OutputFormat of;
                TryGetValue(name, out of);
                return of;
            }
            set
            {
                if (value == null)
                {
                    Remove(name);
                }
                else
                {
                    Update(value);
                }
            }
        }

        /// <summary>
        /// 指定した出力フォーマットが変更されているか判定する.
        /// 指定された名前のオリジナルの出力フォーマットとの差異を比較する.
        /// 指定された名前が、まだ保持されていない場合は変更ありとみなす.
        /// </summary>
        /// <param name="of">現在の出力フォーマット(名前による区別)</param>
        /// <returns>変更の有無</returns>
        public virtual bool IsModified(OutputFormat of)
        {
            if (of == null) return true;

            string name = of.Name;
            OutputFormatHolder holder;
            if (dict.TryGetValue(name, out holder))
            {
                return of.IsModified(holder.original);
            }
            return true;
        }

        /// <summary>
        /// OutputFormatの設定を登録または更新する.
        /// 実際にファイルに反映するにはSaveメソッドを呼び出す必要がある.
        /// </summary>
        /// <param name="outputFormat">対象となる設定</param>
        /// <returns>更新または登録が許可された場合はtrue、許可されない場合はfalse</returns>
        public virtual bool Update(OutputFormat outputFormat)
        {
            if (outputFormat == null) throw new ArgumentException("nullは指定できません");

            string name = outputFormat.Name ?? "";

            OutputFormatHolder holder;
            PersistentDirectoryInfo nextWritableDir;
            if (dict.TryGetValue(name, out holder))
            {
                // すでに読み込み済みのものがある場合
                if (holder.directoryInfo.Writable)
                {
                    // 書き込み可能なディレクトリのものである場合は更新する
                    holder.current = outputFormat;
                    return true;
                }
                else
                {
                    // 書き込み可能でない場合、後続の書き込み可能な
                    // 末端のディレクトリを探す
                    var curdir = holder.directoryInfo;
                    nextWritableDir = GetAfterDirectories(curdir)
                        .Where(dir => dir.Writable).LastOrDefault();
                    if (nextWritableDir == null)
                    {
                        // 後続に書き込み可能なディレクトリがなければ更新不可能
                        return false;
                    }
                }
            }
            else
            {
                // 既存にない新しい名前の場合、もっとも末端の書込み可能なディレクトリを選択し、
                // 新規にエントリを作成する
                nextWritableDir = dirs.Where(dir => dir.Writable).LastOrDefault();
            }

            // 後続の末端ディレクトリにエントリを書き込む
            var newHolder = new OutputFormatHolder()
            {
                directoryInfo = nextWritableDir,
                original = null,
                current = outputFormat
            };
            caches.Add(newHolder);
            dict[name] = newHolder;

            return false;
        }

        /// <summary>
        /// 指定したOutputFormatの設定を削除する.
        /// 設定が存在しないか、削除可能でない場合は何もしない.
        /// </summary>
        /// <param name="outputFormat">対象となる設定</param>
        /// <returns>削除が許可された場合はtrue、許可されなかった場合はfalse</returns>
        public virtual bool Remove(OutputFormat outputFormat)
        {
            if (outputFormat == null) throw new ArgumentException("nullは指定できません");

            string name = outputFormat.Name ?? "";
            return Remove(name);
        }

        /// <summary>
        /// 指定したOutputFormatの設定を削除する.
        /// 設定が存在しないか、削除可能でない場合は何もしない.
        /// </summary>
        /// <param name="outputFormat">対象となる設定の名称</param>
        /// <returns>削除が許可された場合はtrue、許可されなかった場合はfalse</returns>
        public virtual bool Remove(string name)
        {
            if (name == null) throw new ArgumentException("nullは指定できません");

            OutputFormatHolder holder;
            if (dict.TryGetValue(name, out holder))
            {
                if (holder.directoryInfo.Writable)
                {
                    // 書き込み可能である場合のみ、削除する.
                    holder.current = null;
                    
                    // このディレクトリよりも以前にある同名の設定があれば
                    // それを有効化する.
                    bool found = false;
                    foreach (var cache in caches)
                    {
                        if (cache.current != null && cache.current.Name == name)
                        {
                            dict[name] = cache;
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        // 以前に同名の設定がなければマップからも除去する
                        dict.Remove(name);
                    }

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 更新されたエントリがある場合、それをファイルに保存する.
        /// 変更がないエントリについては何もしない.
        /// </summary>
        public virtual void Save()
        {
            var removed = new List<OutputFormatHolder>();
            foreach (var cache in caches)
            {
                if (cache.Modified)
                {
                    // 変更があるエントリは必ず書き込み可能なディレクトリのものだけのはず
                    System.Diagnostics.Debug.Assert(cache.directoryInfo.Writable);

                    // ディレクトリの取得
                    string path = cache.directoryInfo.Path;
                    var dirInfo = new DirectoryInfo(path);

                    if (cache.current != null)
                    {
                        // 更新または追加の場合
                        OutputFormatPersistent.Save(cache.current, dirInfo);
                        cache.original = cache.current.duplicate();
                    }
                    else
                    {
                        // 削除の場合
                        OutputFormatPersistent.Delete(cache.original, dirInfo);
                        removed.Add(cache);
                    }
                }
            }
            // 削除済みエントリを消す
            foreach (var cache in removed)
            {
                caches.Remove(cache);
            }
        }

        /// <summary>
        /// 指定したディレクトリよりも後方のディレクトリの一覧を取得する.
        /// 指定したディレクトリが既存のディレクトリリストに存在しない場合、
        /// もしくは自身が最後のディレクトリであった場合は、結果は空となります.
        /// </summary>
        /// <param name="dirInfo">対象ディレクトリ</param>
        /// <returns>対象ディレクトリよりも後に定義されているディレクトリの一覧</returns>
        protected IEnumerable<PersistentDirectoryInfo> GetAfterDirectories(PersistentDirectoryInfo dirInfo)
        {
            if (dirInfo == null) throw new ArgumentException("nullは指定できません");
            bool outSw = false;
            foreach (var dir in dirs)
            {
                if (outSw)
                {
                    yield return dir;
                }
                else if (dir == dirInfo)
                {
                    outSw = true;
                }
            }
        }
    }
}

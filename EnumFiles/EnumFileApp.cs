using EnumFiles.Gui;
using EnumFiles.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EnumFiles
{
    public static class EnumFileApp
    {
        /// <summary>
        /// OutputFormatの管理クラス
        /// </summary>
        private static OutputFormatManager outputFormatManager = new OutputFormatManager();

        /// <summary>
        /// OutputFormatの管理クラス
        /// </summary>
        public static OutputFormatManager OutputFormatManager
        {
            get
            {
                return outputFormatManager;
            }
        }

        /// <summary>
        /// OutputFormat設定ファイルが保存されているディレクトリ名
        /// </summary>
        private static readonly string TEMPLATE_DIRNAME = "templates";

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // OutputFormatManagerのディレクトリを
            // アプリケーションの設定ディレクトリに設定する.
            var dirs = new List<string>() {
                Application.StartupPath,
                Application.CommonAppDataPath,
                Application.UserAppDataPath
            };
            dirs.ForEach(dir => {
                var path = Path.Combine(dir, TEMPLATE_DIRNAME);
                var dirInfo = new PersistentDirectoryInfo(path, false);
                outputFormatManager.AddDirectory(dirInfo);
            });

            // メインフォームを構築する.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // メッセージループを開始する.
            Application.Run(new EnumFilesForm());
        }
    }
}

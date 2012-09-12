using EnumFiles.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumFiles.Model
{
    /// <summary>
    /// 保存先ディレクトリ情報
    /// </summary>
    [Serializable]
    public sealed class PersistentDirectoryInfo
    {
        /// <summary>
        /// ディレクトリのパス
        /// </summary>
        private string path_;

        /// <summary>
        /// 書き込み用として使用できるか?
        /// </summary>
        private bool writable_;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="path">ディレクトリのパス、nullおよび空文字は不可</param>
        /// <param name="writable">書き込み用に使用できるか?</param>
        public PersistentDirectoryInfo(
            string path,
            bool writable
            )
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("引数は省略できません");
            }
            this.path_ = path;
            this.writable_ = writable;
        }

        /// <summary>
        /// ディレクトリのパス
        /// </summary>
        public string Path
        {
            get
            {
                return path_;
            }
        }

        /// <summary>
        /// ディレクトリに書き込み可能であるか?
        /// </summary>
        public bool Writable
        {
            get
            {
                return writable_;
            }
        }

        /// <summary>
        /// 同値判定
        /// </summary>
        /// <param name="obj">比較対象、null可</param>
        /// <returns>等しければtrue、そうでなければfalse</returns>
        public override bool Equals(object obj)
        {
            var o = obj as PersistentDirectoryInfo;
            if ((object)o != null)
            {
                return path_ == o.path_ && writable_ == o.writable_;
            }
            return false;
        }

        /// <summary>
        /// ハッシュ値
        /// </summary>
        /// <returns>ハッシュ値</returns>
        public override int GetHashCode()
        {
            return path_.GetHashCode();
        }

        /// <summary>
        /// 同値判定、他方または両方がnullでも比較可能
        /// </summary>
        /// <param name="o1">比較1</param>
        /// <param name="o2">比較2</param>
        /// <returns>等しければtrue、そうでなければfalse</returns>
        public static bool operator ==(PersistentDirectoryInfo o1, PersistentDirectoryInfo o2)
        {
            if (object.ReferenceEquals(o1, o2))
            {
                return true;
            }
            return (object)o1 != null && o1.Equals(o2);
        }

        /// <summary>
        /// 非同値判定、他方または両方がnullでも比較可能
        /// </summary>
        /// <param name="o1">比較1</param>
        /// <param name="o2">比較2</param>
        /// <returns>等しくなければtrue、等しければfalse</returns>
        public static bool operator !=(PersistentDirectoryInfo o1, PersistentDirectoryInfo o2)
        {
            return !(o1 == o2);
        }

        /// <summary>
        /// 診断用文字列を取得する.
        /// </summary>
        /// <returns>診断用文字列</returns>
        public override string ToString()
        {
            return StringUtils.ReflectionToString(this);
        }
    }
}

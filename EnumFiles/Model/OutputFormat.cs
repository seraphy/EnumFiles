using EnumFiles.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace EnumFiles.Model
{
    /// <summary>
    /// 出力フォーマットのテンプレート
    /// </summary>
    [Serializable]
    [XmlRoot("OutputFormat")]
    public class OutputFormat : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// 名前
        /// </summary>
        private string name_;

        /// <summary>
        /// ヘッダ部
        /// </summary>
        private string header_;

        /// <summary>
        /// 各アイテム部
        /// </summary>
        private string eachItem_;

        /// <summary>
        /// 各アイテム部(交互)
        /// </summary>
        private string eachItemAlternate_;

        /// <summary>
        /// フッター部
        /// </summary>
        private string footer_;

        #endregion

        #region Properties

        [XmlAttribute]
        public string Name
        {
            set
            {
                this.name_ = value;
                OnPropertyChanged("Name");
            }
            get
            {
                return name_;
            }
        }

        [XmlElement]
        public string Header
        {
            set
            {
                this.header_ = value;
                OnPropertyChanged("Header");
            }
            get
            {
                return header_;
            }
        }

        [XmlElement]
        public string EachItem
        {
            set
            {
                this.eachItem_ = value;
                OnPropertyChanged("EachItem");
            }
            get
            {
                return eachItem_;
            }
        }

        [XmlElement]
        public string EachItemAlternate
        {
            set
            {
                this.eachItemAlternate_ = value;
                OnPropertyChanged("EachItemAlternate");
            }
            get
            {
                return eachItemAlternate_;
            }
        }

        [XmlElement]
        public string Footer
        {
            set
            {
                this.footer_ = value;
                OnPropertyChanged("Footer");
            }
            get
            {
                return footer_;
            }
        }

        #endregion

        #region INotifyPropertyChanged メンバ

        /// <summary>
        /// プロパティ変更のイベントハンドラ
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// イベントハンドラに変更を通知する.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
        
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public OutputFormat()
        {
        }

        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        /// <param name="o"></param>
        public OutputFormat(OutputFormat o)
        {
            this.Name = o.Name;
            this.Header = o.Header;
            this.EachItem = o.EachItem;
            this.EachItemAlternate = o.EachItemAlternate;
            this.Footer = o.Footer;
        }

        /// <summary>
        /// 複製する.
        /// </summary>
        /// <returns>複製されたオブジェクト</returns>
        public virtual OutputFormat duplicate()
        {
            return new OutputFormat(this);
        }

        /// <summary>
        /// 変更の有無を判定する.
        /// </summary>
        /// <param name="o">比較対象、null可</param>
        /// <returns>内容が一致すればfalse、一致しなければtrue</returns>
        public virtual bool IsModified(OutputFormat o)
        {
            if ((object)o != null)
            {
                return !(this.Name == o.Name &&
                    this.Header == o.Header &&
                    this.EachItem == o.EachItem &&
                    this.EachItemAlternate == o.EachItemAlternate &&
                    this.Footer == o.Footer);
            }
            return false;
        }

        /// <summary>
        /// 同値であるか?
        /// </summary>
        /// <param name="obj">比較対象、null可</param>
        /// <returns>等しければtrue、そうでなければfalse</returns>
        public override bool Equals(object obj)
        {
            var o = obj as OutputFormat;
            if ((object)o != null)
            {
                return !IsModified(o);
            }
            return false;
        }

        /// <summary>
        /// ハッシュ値を取得する.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Name ?? "").GetHashCode();
        }

        /// <summary>
        /// 二つのオブジェクトが同値であるか?
        /// いずれか、もしくは両方がnullであっても可.
        /// </summary>
        /// <param name="o1">比較1</param>
        /// <param name="o2">比較2</param>
        /// <returns>等しければtrue、そうでなければfalse</returns>
        public static bool operator ==(OutputFormat o1, OutputFormat o2)
        {
            if (object.ReferenceEquals(o1, o2))
            {
                return true;
            }
            return (object)o1 != null && o1.Equals(o2);
        }

        /// <summary>
        /// 二つのオブジェクトが同値でないか?
        /// </summary>
        /// <param name="o1">比較1</param>
        /// <param name="o2">比較2</param> 
        /// <returns>同値でなければtrue、同値であればfalse</returns>
        public static bool operator !=(OutputFormat o1, OutputFormat o2)
        {
            return !(o1 == o2);
        }

        /// <summary>
        /// 診断用に文字列化する.
        /// </summary>
        /// <returns>診断用文字列</returns>
        public override string ToString()
        {
            return StringUtils.ReflectionToString(this);
        }
    }
}

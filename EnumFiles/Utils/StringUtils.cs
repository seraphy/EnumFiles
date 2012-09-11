using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EnumFiles.Utils
{
    /// <summary>
    /// 文字列のユーテリティ
    /// </summary>
    public static class StringUtils
    {

        /// <summary>
        /// 指定したオブジェクトのプロパティを文字列化する.
        /// nullの場合は「null」という文字列を返す。
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ReflectionToString(object obj)
        {
            if (obj == null)
            {
                // nullならばnullとする.
                return "null";
            }

            var buf = new StringBuilder();
            // 先頭の括弧をつける
            buf.Append("(");

            Type typ = obj.GetType();
            PropertyInfo[] props = typ.GetProperties();
            foreach (var prop in props)
            {
                if (buf.Length > 1) // 先頭の括弧の一文字は除外
                {
                    buf.Append(", ");
                }

                // プロパティ名
                buf.Append(prop.Name);
                buf.Append("=");
                try
                {
                    // プロパティの値
                    object v = prop.GetValue(obj, null);
                    buf.Append(v == null ? "null" : v.ToString());
                }
                catch (Exception ex)
                {
                    // 失敗したらエラーをプリント
                    buf.Append(ex.Message);
                }
            }
            // 末尾の括弧をつける
            buf.Append(")");

            return buf.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace tt.Template.Core
{
    public static class EnumHelp
    {
        /// <summary>
        /// 获取枚举对象描述信息
        /// </summary>
        /// <param name="enumObject">枚举对象</param>
        /// <returns>返回描述(Description)</returns>
        public static string Description(this Enum enumObject)
        {
            Type type = enumObject.GetType();
            string text = (from f in Enum.GetNames(type)
                where f.Equals(enumObject.ToString(), StringComparison.CurrentCultureIgnoreCase)
                select f
                into d
                select d).FirstOrDefault<string>();
            if (text == null)
            {
                return string.Empty;
            }
            object[] customAttributes = type.GetField(text).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (customAttributes.Length == 0)
            {
                return text;
            }
            return ((DescriptionAttribute) customAttributes[0]).Description;
        }

        /// <summary>
        /// 获取枚举对象对应整形值
        /// </summary>
        /// <param name="enumObject">枚举对象</param>
        /// <returns>返回整形值</returns>
        public static int Value(this Enum enumObject)
        {
            return (int) Enum.Parse(enumObject.GetType(), enumObject.ToString(), true);
        }
    }
}

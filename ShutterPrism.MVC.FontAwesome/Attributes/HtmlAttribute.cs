using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShutterPrism.MVC.FontAwesome.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class HtmlAttribute : Attribute
    {
        private string _value;
        private string _name;
        public HtmlAttribute(String name, String value)
        {
            this._name = name;
            this._value = value;
        }

        public static string GetName(object enm)
        {
            if (enm != null)
            {
                MemberInfo[] mi = enm.GetType().GetMember(enm.ToString());
                if (mi != null && mi.Length > 0)
                {
                    HtmlAttribute attr = Attribute.GetCustomAttribute(mi[0],
                        typeof(HtmlAttribute)) as HtmlAttribute;
                    if (attr != null)
                    {
                        return attr._name;
                    }
                }
            }
            return null;
        }

        public static string GetValue(object enm)
        {
            if (enm != null)
            {
                MemberInfo[] mi = enm.GetType().GetMember(enm.ToString());
                if (mi != null && mi.Length > 0)
                {
                    HtmlAttribute attr = Attribute.GetCustomAttribute(mi[0],
                        typeof(HtmlAttribute)) as HtmlAttribute;
                    if (attr != null)
                    {
                        return attr._value;
                    }
                }
            }
            return null;
        }
    }
}

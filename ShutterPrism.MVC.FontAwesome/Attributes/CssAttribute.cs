using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShutterPrism.MVC.FontAwesome.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CssAttribute : Attribute
    {
        private string _clsname;
        public CssAttribute(string className)
        {
            this._clsname = className;
        }

        public static string Get(object enm)
        {
            if (enm != null)
            {
                MemberInfo[] mi = enm.GetType().GetMember(enm.ToString());
                if (mi != null && mi.Length > 0)
                {
                    CssAttribute attr = Attribute.GetCustomAttribute(mi[0],
                        typeof(CssAttribute)) as CssAttribute;
                    if (attr != null)
                    {
                        return attr._clsname;
                    }
                }
            }
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome.Utilities
{
    public static class HtmlAttributes
    {
        public static TagBuilder AddOrMergeAttribute(this TagBuilder tb, string attrName, string attrValue)
        {
            if (tb.Attributes.ContainsKey(attrName))
            {
                if (!tb.Attributes[attrName].Contains(attrValue))
                    tb.Attributes[attrName] += " " + attrValue;
            }
            else
            {
                tb.Attributes.Add(attrName, attrValue);
            }

            return tb;
        }
    }
}

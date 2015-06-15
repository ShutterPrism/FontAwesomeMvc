using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome.Framework
{
    public abstract class BaseHtmlElement<T> : IHtmlString
    where T : BaseHtmlElement<T>
    {
        protected IDictionary<string, object> _htmlAttributes;

        public T HtmlAttributes(IDictionary<string, object> htmlAttributes)
        {
            this._htmlAttributes = htmlAttributes;
            return (T)this;
        }

        public T HtmlAttributes(object htmlAttributes)
        {
            this._htmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            return (T)this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract TagBuilder BuildTag();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() { return BuildTag().ToString(); }

        public string ToHtmlString()
        {
            return BuildTag().ToString();
        }
    }
}

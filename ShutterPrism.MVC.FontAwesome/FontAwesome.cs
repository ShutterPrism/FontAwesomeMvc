using FontAwesome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome
{
    public class FontAwesome<TModel>
    {
        protected HtmlHelper<TModel> Html;

        public FontAwesome(HtmlHelper<TModel> _html)
        {
            this.Html = _html;
        }

        public Icon Icon(FontAwesomeIcons icon)
        {
            return new Icon(icon);
        }

        public IconStack IconStack(FontAwesomeIcons front, FontAwesomeIcons back)
        {
            return new IconStack(front, back);
        }

        public IconStack IconStack(Icon front, Icon back)
        {
            return new IconStack(front, back);
        }
    }
}

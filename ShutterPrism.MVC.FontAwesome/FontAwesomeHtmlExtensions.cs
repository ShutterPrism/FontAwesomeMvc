using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome
{
    public static class FontAwesomeHtmlExtensions
    {
        public static FontAwesome<TModel> FontAwesome<TModel>(this HtmlHelper<TModel> helper)
        {
            return new FontAwesome<TModel>(helper);
        }
    }
}

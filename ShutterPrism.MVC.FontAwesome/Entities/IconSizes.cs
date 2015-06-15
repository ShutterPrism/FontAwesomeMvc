using ShutterPrism.MVC.FontAwesome.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontAwesome
{
    public enum IconSizes
    {
        /// <summary>
        /// This is the default size
        /// </summary>
        Normal,
        /// <summary>
        /// 33% increase in size
        /// </summary>
        [CssAttribute("fa-lg")]
        Large,
        /// <summary>
        /// 2 times the size
        /// </summary>
        [CssAttribute("fa-2x")]
        X2,
        /// <summary>
        /// 3 times the size
        /// </summary>
        [CssAttribute("fa-3x")]
        X3,
        /// <summary>
        /// 4 times the size
        /// </summary>
        [CssAttribute("fa-4x")]
        X4,
        /// <summary>
        /// 5 times the size
        /// </summary>
        [CssAttribute("fa-5x")]
        X5
    }
}

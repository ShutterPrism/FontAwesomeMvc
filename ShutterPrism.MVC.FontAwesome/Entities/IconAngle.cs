using ShutterPrism.MVC.FontAwesome.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FontAwesome
{
    public enum IconAngle
    {
        None,

        [CssAttribute("fa-flip-horizontal")]
        FlipHorizontally,

        [CssAttribute("fa-flip-vertical")]
        FlipVertically,

        [CssAttribute("fa-rotate-90")]
        Rotate90,

        [CssAttribute("fa-rotate-180")]
        Rotate180,

        [CssAttribute("fa-rotate-270")]
        Rotate270,
    }
}

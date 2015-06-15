using FontAwesome;
using ShutterPrism.MVC.FontAwesome.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome
{
    public enum StackedLayer
    {
        Front,
        Back
    }

    public class StackedIcon : Icon
    {
        protected StackedLayer _layer;
        protected IconStack _stack;

        public StackedIcon(FontAwesomeIcons type, StackedLayer layer, IconStack stack)
            : base(type)
        {
            this._layer = layer;
            this._stack = stack;
        }

        public IconStack IconStack()
        {
            return this._stack;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override TagBuilder BuildTag()
        {
            TagBuilder i = new TagBuilder("span");
            i.MergeAttributes(this._htmlAttributes);
            i.AddCssClass("fa");
            i.AddCssClass(CssAttribute.Get(this._type));

            var size = CssAttribute.Get(this._size);
            if (size != null)
                i.AddCssClass(size);

            if (this._isFixedWidth)
                i.AddCssClass("fa-fw");

            if (this._isBordered)
                i.AddCssClass("fa-border");

            if (this._isSpinner)
                i.AddCssClass("fa-spin");

            switch (this._layer)
            {
                case StackedLayer.Front:
                    i.AddCssClass("fa-stack-1x");
                    break;
                case StackedLayer.Back:
                    i.AddCssClass("fa-stack-2x");
                    break;
            }

            var angle = CssAttribute.Get(this._angle);
            if (this._isSpinner)
                i.AddCssClass(angle);

            return i;
        }
    }
}

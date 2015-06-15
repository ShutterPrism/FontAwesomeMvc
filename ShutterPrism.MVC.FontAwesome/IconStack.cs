using FontAwesome;
using ShutterPrism.MVC.FontAwesome.Attributes;
using ShutterPrism.MVC.FontAwesome.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ShutterPrism.MVC.FontAwesome
{
    public class IconStack : BaseIconElement<Icon>
    {
        private Icon _front;
        private Icon _back;
        protected IconSizes _size = IconSizes.Large;
        protected IconAngle _angle = IconAngle.None;
        protected Boolean _isReverse = false;

        public IconStack(FontAwesomeIcons front, FontAwesomeIcons back)
        {
            this._front = new Icon(front);
            this._back = new Icon(back);
        }

        public IconStack(Icon front, Icon back)
        {
            this._front = front;
            this._back = back;
        }

        /// <summary>
        /// Change the size relative to the container's size
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public IconStack Size(IconSizes size)
        {
            this._size = size;
            return this;
        }

        /// <summary>
        /// Set the angle/flip the icon
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public IconStack Angle(IconAngle angle)
        {
            this._angle = angle;
            return this;
        }

        /// <summary>
        /// This flips the order in which the icons are positioned in the HTML. This allows the smaller icon to be in
        /// the background, while the larger one will be in the foreground. A simple example of this would be placing a ban icon ontop
        /// of any other icon.
        /// </summary>
        /// <returns></returns>
        public IconStack Reverse()
        {
            this._isReverse = true;
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override TagBuilder BuildTag()
        {
            TagBuilder i = new TagBuilder("span");
            i.MergeAttributes(this._htmlAttributes);
            i.AddCssClass("fa-stack");

            var size = CssAttribute.Get(this._size);
            if (size != null)
                i.AddCssClass(size);

            var angle = CssAttribute.Get(this._angle);
            if (angle != null)
                i.AddCssClass(angle);

            StringBuilder sb = new StringBuilder();

            var back = this._back.BuildTag();
            back.AddCssClass("fa-stack-2x");

            var front = this._front.BuildTag();
            front.AddCssClass("fa-stack-1x");


            sb.Append(((this._isReverse) ? front.ToString() : back.ToString()));
            sb.Append(((this._isReverse) ? back.ToString() : front.ToString()));

            i.InnerHtml = sb.ToString();

            return i;
        }
    }
}

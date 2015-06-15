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
    public class Icon : BaseIconElement<Icon>
    {
        protected FontAwesomeIcons _type;
        protected IconSizes _size = IconSizes.Normal;
        protected Boolean _isFixedWidth = false;
        protected Boolean _isBordered = false;
        protected Boolean _isSpinner = false;
        protected Boolean _isInverse = false;
        protected IconAngle _angle = IconAngle.None;

        public Icon(FontAwesomeIcons type)
        {
            this._type = type;
        }

        /// <summary>
        /// Change the size relative to the container's size
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Icon Size(IconSizes size)
        {
            this._size = size;
            return this;
        }

        /// <summary>
        /// Use Fixed width to set icons at a fixed width. 
        /// Great to use when different icon widths throw off alignment. Especially useful in things like nav lists & list groups.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public Icon FixedWidth()
        {
            this._isFixedWidth = true;
            return this;
        }

        /// <summary>
        /// Place a border around the icon
        /// </summary>
        /// <returns></returns>
        public Icon Bordered()
        {
            this._isBordered = true;
            return this;
        }

        /// <summary>
        /// Set the angle/flip the icon
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public Icon Angle(IconAngle angle)
        {
            this._angle = angle;
            return this;
        }

        /// <summary>
        /// Use to get any icon to rotate. This uses CSS3, and is not supported in IE9 or earlier.
        /// </summary>
        /// <returns></returns>
        public Icon Spinner()
        {
            this._isSpinner = true;
            return this;
        }

        /// <summary>
        /// alternative icon color. Usually used when stacking multiple icons, but can be used on any icon.
        /// </summary>
        /// <returns></returns>
        public Icon Inverse()
        {
            this._isInverse = true;
            return this;
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

            if (this._isInverse)
                i.AddCssClass("fa-inverse");

            var angle = CssAttribute.Get(this._angle);
            if (angle != null)
                i.AddCssClass(angle);

            return i;
        }
    }
}

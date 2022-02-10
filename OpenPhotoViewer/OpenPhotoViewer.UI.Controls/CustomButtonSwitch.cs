using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OpenPhotoViewer.UI.Controls
{
    public class CustomButtonSwitch : CheckBox
    {
        private Image _mainImage = new Bitmap(1,1);
        private Image _hoverImage = new Bitmap(1,1);
        private Image _clickImage = new Bitmap(1,1);

        public CustomButtonSwitch()
        {
            Appearance = Appearance.Button;
        }
        
        private void Set<T>(ref T field, T value)
        {
            if (field.Equals(value))
                return;
            field = value;
            base.Refresh();
        }
        
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Image = _mainImage;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Image = _hoverImage;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            if (!SystemInformation.MouseButtonsSwapped && mevent.Button == MouseButtons.Left || mevent.Button == MouseButtons.Right)
                Image = _clickImage;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            Image = _hoverImage;
        }

        [Category("Appearence"),
         Description(
             "Image to show when nothing happens")]
        public Image MainImage
        {
            get => _mainImage;
            set => Set(ref _mainImage, value);
        }

        [Category("Appearence"),
         Description(
             "Image to show on hover")]
        public Image HoverImage
        {
            get => _hoverImage;
            set => Set(ref _hoverImage, value);
        }

        [Category("Appearence"),
         Description(
             "Image to show on click")]
        public Image ClickImage
        {
            get => _clickImage;
            set => Set(ref _clickImage, value);
        }
    }
}
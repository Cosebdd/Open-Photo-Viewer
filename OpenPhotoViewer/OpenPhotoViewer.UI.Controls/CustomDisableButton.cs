using System;
using System.ComponentModel;
using System.Drawing;

namespace OpenPhotoViewer.UI.Controls
{
    public class CustomDisableButton : CustomButton
    {
        private Image _disabledImage = new Bitmap(1,1);
        
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Image = Enabled ? MainImage : _disabledImage;
        }
        
        [Category("Appearence"),
         Description(
             "Image to show when the button is disabled")]
        public Image DisabledImage
        {
            get => _disabledImage;
            set => Set(ref _disabledImage, value);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenPhotoViewer.Core;
using OpenPhotoViewer.UI.Controls.ImageBox;

namespace OpenPhotoViewer.UI
{
    public partial class MainForm : Form
    {
        private bool _fitToWindow;
        private string _currentFilePath;

        public MainForm(string currentFilePath)
        {
            _currentFilePath = currentFilePath;
            _fitToWindow = true;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_currentFilePath != null)
            {
                var image = Image.FromFile(_currentFilePath);
                ImageBox.Text = string.Empty;
                ImageBox.Image = image;

                ImageBox.ZoomLevels = ZoomLevelCollectionFactory.CreateZoomLevelCollection(ImageBox.Zoom);
            }
        }

        private void ImageBox_SizeChanged(object sender, EventArgs e)
        {
            var zoomToFit = ImageBox.GetZoomToFit();

            if (zoomToFit < 100)
            {
                ImageBox.ZoomLevels = ZoomLevelCollectionFactory.CreateZoomLevelCollection(zoomToFit);
            }
            else
            {
                ImageBox.ZoomLevels = ZoomLevelCollectionFactory.CreateZoomLevelCollection(100);
            }
        }

        private void ImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
            if (e.NewZoom == ImageBox.ZoomLevels[0])
            {
                ImageBox.SizeMode = ImageBoxSizeMode.Fit;
            }
        }
    }
}
using System;
using System.Windows.Forms;
using OpenPhotoViewer.Core;
using OpenPhotoViewer.UI.Controls.ImageBox;

namespace OpenPhotoViewer.UI
{
    public partial class MainForm : Form
    {
        private ImageLoader _loader;

        public MainForm(string currentFilePath)
        {
            _loader = new ImageLoader(currentFilePath);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadImage(() => _loader.LoadImage());
            ImageBox.Text = string.Empty;
        }

        private void ImageBox_SizeChanged(object sender, EventArgs e)
        {
            var zoomToFit = ImageBox.GetZoomToFit();

            ImageBox.ZoomLevels =
                ZoomLevelCollectionFactory.CreateZoomLevelCollection(zoomToFit < 100 ? zoomToFit : 100);
        }

        private void ImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
            if (e.NewZoom == ImageBox.ZoomLevels[0])
            {
                ImageBox.SizeMode = ImageBoxSizeMode.Fit;
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            LoadImage(() => _loader.NextImage());
        }

        private void Left_Click(object sender, EventArgs e)
        {
            LoadImage(() => _loader.PreviousImage());
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    Left_Click(sender, e);
                    break;
                case Keys.Right:
                case Keys.D:
                    Right_Click(sender, e);
                    break;
            }
        }

        private void LoadImage(Func<LoadedImage> loadFunc)
        {
            var loadedImage = loadFunc();
            ImageBox.Image = loadedImage.Image;
            
            ImageBox.SizeMode = ImageBoxSizeMode.Fit;
            
            ImageBox.ZoomLevels = ZoomLevelCollectionFactory.CreateZoomLevelCollection(ImageBox.Zoom);

            Text = $"{loadedImage.FileName} - Open Photo Viewer";

            var centerPoint = ImageBox.CenterPoint;
            ImageBox.ScrollTo(ImageBox.PointToImage(centerPoint), centerPoint);
        }
    }
}
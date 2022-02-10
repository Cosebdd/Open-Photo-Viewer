using System;
using System.Windows.Forms;
using OpenPhotoViewer.Core;
using OpenPhotoViewer.UI.Controls.ImageBox;

namespace OpenPhotoViewer.UI
{
    public partial class MainForm : Form
    {
        private readonly ImageLoader _loader;

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

            CheckAndSetFitToWindowButtonEnabled(zoomToFit);
        }

        private void ImageBox_Zoomed(object sender, ImageBoxZoomEventArgs e)
        {
            if (e.NewZoom == ImageBox.ZoomLevels[0])
            {
                ImageBox.SizeMode = ImageBoxSizeMode.Fit;
            }

            var zoomToFit = ImageBox.GetZoomToFit();
            CheckAndSetFitToWindowButtonEnabled(zoomToFit);
        }

        private void ImageBox_SizeModeChanged(object sender, EventArgs e)
        {
            //FitToWindowButton.Text = ImageBox.SizeMode == ImageBoxSizeMode.Fit ? "↙" : "↗";
            if (ImageBox.SizeMode == ImageBoxSizeMode.Fit && !ImageBox.IsActualSize)
            {
                FitToWindowButton.Visible = false;
                ActualSizeButton.Visible = true;
            }
            else
            {
                FitToWindowButton.Visible = true;
                ActualSizeButton.Visible = false;
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

        private void GridSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var gridIsDisplayed = ImageBox.GridDisplayMode == ImageBoxGridDisplayMode.Client;
            ImageBox.GridDisplayMode = gridIsDisplayed ? ImageBoxGridDisplayMode.None : ImageBoxGridDisplayMode.Client;
        }

        private void FitToWindow_Click(object sender, EventArgs e)
        {
            ImageBox.ZoomToFit();
            ImageBox.SizeMode = ImageBoxSizeMode.Fit;

            RecenterScroll();
        }

        private void ActualSizeButton_Click(object sender, EventArgs e)
        {
            ImageBox.ActualSize();

            RecenterScroll();
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

            RecenterScroll();
        }

        private void RecenterScroll()
        {
            var centerPoint = ImageBox.CenterPoint;
            ImageBox.ScrollTo(ImageBox.PointToImage(centerPoint), centerPoint);
        }

        private void CheckAndSetFitToWindowButtonEnabled(int zoomToFit)
        {
            if (zoomToFit > 100 && ImageBox.IsActualSize)// zoomToFit > 100 means the whole image of actual size is visible
            {
                if (FitToWindowButton.Enabled)
                    FitToWindowButton.Enabled = false;
                ActualSizeButton.Visible = false;
                FitToWindowButton.Visible = true;
            }
            else
            {
                if (!FitToWindowButton.Enabled)
                    FitToWindowButton.Enabled = true;

                if (ImageBox.SizeMode == ImageBoxSizeMode.Fit && !ImageBox.IsActualSize)
                {
                    FitToWindowButton.Visible = false;
                    ActualSizeButton.Visible = true;
                }
                    
            }
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            GrayGradientPanel.Refresh(); //Prevents weird artifacts when the gradient is moved out of the screen
        }
    }
}
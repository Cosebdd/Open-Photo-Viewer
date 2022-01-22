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
        private string _currentFilePath;
        
        public MainForm(string currentFilePath)
        {
            _currentFilePath = currentFilePath;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_currentFilePath != null)
            {
                var image = Image.FromFile(_currentFilePath);
                ImageBox.Text = string.Empty;
                ImageBox.Image = image;
                if (ImageBox.Width < image.Width || ImageBox.Height < image.Height)
                    ImageBox.SizeMode = ImageBoxSizeMode.Fit;
                
                ImageBox.ZoomLevels = ZoomLevelCollectionFactory.CreateZoomLevelCollection(ImageBox.Zoom);
            }
        }
    }
}

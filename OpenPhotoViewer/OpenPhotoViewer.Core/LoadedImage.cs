using System.Drawing;

namespace OpenPhotoViewer.Core
{
    public class LoadedImage
    {
        public LoadedImage(Image image, string fileName)
        {
            Image = image;
            FileName = fileName;
        }

        public Image Image { get; }
        public string FileName { get; }
    }
}
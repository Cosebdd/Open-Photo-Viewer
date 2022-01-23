using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace OpenPhotoViewer.Core
{
    public class ImageLoader
    {
        private string _currentFilePath;
        private Image _currentImage;
        private ReadOnlyCircularLinkedList<string> _imagesInCurrentFolder;

        public ImageLoader(string filePath)
        {
            _currentFilePath = filePath;
        }

        public LoadedImage LoadImage()
        {
            var folder = Path.GetDirectoryName(_currentFilePath);
            
            if (folder == null)
                throw new ArgumentException($"Unable to get a directory name for {_currentFilePath}");
            
            var currentFolderImages = SupportedFileExtensions.All
                .SelectMany(ext => Directory.GetFiles(folder, $"*.{ext}", SearchOption.TopDirectoryOnly))
                .OrderBy(s => s, StringComparer.InvariantCultureIgnoreCase);
            
            _imagesInCurrentFolder = new ReadOnlyCircularLinkedList<string>(currentFolderImages);
            _imagesInCurrentFolder.FindAndSetCurrentNode(_currentFilePath);
            _currentImage = Image.FromFile(_currentFilePath);
            return new LoadedImage(_currentImage, Path.GetFileName(_currentFilePath));
        }

        public LoadedImage NextImage()
        {
            return LoadImage(_imagesInCurrentFolder.GetNext());
        }

        public LoadedImage PreviousImage()
        {
            return LoadImage(_imagesInCurrentFolder.GetPrevious());
        }

        private LoadedImage LoadImage(string nextFilePath)
        {
            var previousImage = _currentImage;
            try
            {
                _currentFilePath = nextFilePath;
                _currentImage = Image.FromFile(_currentFilePath);
                return new LoadedImage(_currentImage, Path.GetFileName(_currentFilePath));
            }
            finally
            {
                previousImage?.Dispose();
            }
        }
    }
}
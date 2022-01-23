using System.Linq;
using OpenPhotoViewer.Core.Extensions;

namespace OpenPhotoViewer.Core
{
    public static class ZoomLevelCollectionFactory
    {
        private static readonly int[] _defaultLevels =
            { 100, 150, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1200, 1400, 1600 };

        public static ZoomLevelCollection CreateZoomLevelCollection(int initialZoom)
        {
            var zoomLevels = initialZoom
                .RoundOff()
                .Range(100, 10)
                .Concat(_defaultLevels)
                .ToArray();

            return new ZoomLevelCollection(zoomLevels);
        }
    }
}
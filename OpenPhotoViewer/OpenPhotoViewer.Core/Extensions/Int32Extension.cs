using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenPhotoViewer.Core.Extensions
{
    public static class Int32Extension
    {
        public static int RoundOff (this int i)
        {
            return ((int)Math.Round(i / 10.0)) * 10;
        }

        public static IEnumerable<int> Range(this int start, int stop, int step)
        {
            bool IsOutsideRange(int i)
            {
                return step < 0 && i <= stop || step > 0 && i >= stop;
            }

            if (step == 0)
                throw new ArgumentException("step must not be equal to 0");

            var x = start;
            
            while (!IsOutsideRange(x))
            {
                yield return x;
                x += step;
            }
        }
    }
}
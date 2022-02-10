using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OpenPhotoViewer.UI.Controls
{
    public sealed class GrayGradientPanel : Panel
    {
        private bool _angleScales = false;
        private int _angle = 0;

        private readonly Color[] _colors =
        {
            ColorTranslator.FromHtml("#3F3F3F"),
            ColorTranslator.FromHtml("#5D5D5D"),
            ColorTranslator.FromHtml("#606060"),
            ColorTranslator.FromHtml("#7D7D7D")
        };

        private readonly float[] _positions =
        {
            0f,
            0.1f,
            0.9f,
            1f
        };

        public GrayGradientPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        /// litle helper to redraw when property changes, a litle OnNofifyChanged for the 
        /// IDE causing it to update
        /// </summary>
        /// <typeparam name="T">Making sure the values are comparable</typeparam>
        /// <param name="field">the field that is compared</param>
        /// <param name="value">the value that is assigned</param>
        /// <remarks>Updates re-paints the panel when needed</remarks>
        private void Set<T>(ref T field, T value)
        {
            if (field.Equals(value))
                return;
            field = value;
            base.Refresh();
        }

        [Category("Appearence"),
         Description("The angle, measured in degrees clockwise from the x-axis, of the gradient's orientation line.")]
        public int Angle
        {
            get => _angle;
            set => Set(ref _angle, value);
        }

        [Category("Appearence"),
         Description(
             "If Set to true to specify that the angle is affected by the transform associated with this panel")]
        public bool AngleScales
        {
            get => _angleScales;
            set => Set(ref _angleScales, value);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (e.ClipRectangle.Width == 0 || e.ClipRectangle.Height == 0)
                return;
            var br = new LinearGradientBrush(e.ClipRectangle, Color.Transparent, Color.Transparent, Angle, AngleScales);

            br.InterpolationColors = new ColorBlend
            {
                Colors = _colors,
                Positions = _positions
            };

            e.Graphics.FillRectangle(br, e.ClipRectangle);
            base.OnPaint(e);
        }
    }
}
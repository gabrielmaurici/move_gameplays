using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MoveGameplays.Wfp.UIExtensions
{
    public class CustomButton : Button
    {
        //Fields
        private int _borderSize = 0;
        private int _borderRadius = 10;
        private Color _borderColor = Color.PaleVioletRed;
        private Color _previousColor;

        //Properties
        [Category("Custom Button")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        [Category("Custom Button")]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        [Category("Custom Button")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom Button")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set { BackColor = value; }
        }

        [Category("Custom Button")]
        public Color TextColor
        {
            get { return ForeColor; }
            set { ForeColor = value; }
        }

        //Constructor
        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BorderRadius = 10;
            Size = new Size(150, 40);
            BackColor = Color.FromArgb(75, 75, 75);
            ForeColor = Color.White;
            Resize += new EventHandler(Button_Resize);

            MouseEnter += CustomButton_MouseEnter;
            MouseLeave += CustomButton_MouseLeave;
        }

        private void CustomButton_MouseLeave(object? sender, EventArgs e)
        {
            BackgroundColor = _previousColor;
        }

        private void CustomButton_MouseEnter(object? sender, EventArgs e)
        {
            _previousColor = BackgroundColor;
            BackgroundColor = Color.FromArgb(0, 165, 255);
        }

        //Methods
        private static GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);
            int smoothSize = 2;
            if (_borderSize > 0)
                smoothSize = _borderSize;

            if (_borderRadius > 2) //Rounded button
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize);
                using Pen penSurface = new(Parent.BackColor, smoothSize);
                using Pen penBorder = new(_borderColor, _borderSize);
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Button border                    
                if (_borderSize >= 1)
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                Region = new Region(rectSurface);
                //Button border
                if (_borderSize >= 1)
                {
                    using Pen penBorder = new Pen(_borderColor, _borderSize);
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > Height)
                _borderRadius = Height;
        }
    }
}

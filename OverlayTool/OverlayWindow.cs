using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayTool
{
    public partial class OverlayWindow : Form
    {
        public OverlayWindow()
        {
            InitializeComponent();
            // FormBorderStyle = FormBorderStyle.None;
            Text = "";
            ControlBox = false;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            TopMost = true;
        }

        public string ImagePath
        {
            set
            {
                try
                {
                    imageBox.Image = Image.FromFile(value);
                    imageBox.Dock = DockStyle.Fill;
                    imageBox.Size = Size;
                    imageBox.Location = new Point(0, 0);
                }
                catch { }
            }
        }

        private bool leftMouseDown;
        private bool middleMouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            leftMouseDown = (e.Button == MouseButtons.Left) || leftMouseDown;
            middleMouseDown = (e.Button == MouseButtons.Middle) || middleMouseDown;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftMouseDown)
            {
                Location = new Point(
                    Location.X - lastLocation.X + e.X,
                    Location.Y - lastLocation.Y + e.Y);

                Update();
            }
            else if (middleMouseDown)
            {
                var size = imageBox.Size;
                imageBox.Dock = DockStyle.None;
                imageBox.Size = size;
                imageBox.Location = new Point(
                    imageBox.Location.X - lastLocation.X + e.X,
                    imageBox.Location.Y - lastLocation.Y + e.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            leftMouseDown = (e.Button != MouseButtons.Left) && leftMouseDown;
            middleMouseDown = (e.Button != MouseButtons.Middle) && middleMouseDown;
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            var scale = e.Delta / 1200f + 1;
            var imageBoxPos = new Vector2(imageBox.Location.X, imageBox.Location.Y);
            var cursorPos = new Vector2(e.X, e.Y);
            var cursorDelta = imageBoxPos - cursorPos;
            var newImageBoxPos = cursorPos + cursorDelta * scale;
            
            SuspendLayout();
            var size = imageBox.Size;
            imageBox.Dock = DockStyle.None;
            imageBox.Size = size;
            imageBox.Location = new Point((int)newImageBoxPos.X, (int)newImageBoxPos.Y);
            imageBox.Width = (int)Math.Max(scale*imageBox.Width, 100);
            imageBox.Height = (int)Math.Max(scale*imageBox.Height, 100);
            ResumeLayout();
            Refresh();
        }

        private enum ResizeDirection
        {
            None,
            TopLeft,
            Top,
            TopRight,
            Right,
            BottomRight,
            Bottom,
            BottomLeft,
            Left
        }
    }

}

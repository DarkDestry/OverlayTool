using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OverlayTool
{
    public partial class MainWindow : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        private const int WS_EX_TRANSPARENT = 0x00000020;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = File.Exists(imagePathTextField.Text)
                ? Path.GetDirectoryName(imagePathTextField.Text)
                : @"C:\";
            openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, do something with it
                string selectedFile = openFileDialog.FileName;
                imagePathTextField.Text = selectedFile;

            }
        }



        private OverlayWindow overlayWindow;

        private void openOverlayButton_Click(object sender, EventArgs e)
        {
            overlayWindow ??= new OverlayWindow();
            overlayWindow.Opacity = (double)opacityField.Value / 100d;
            overlayWindow.ImagePath = imagePathTextField.Text;
            overlayWindow.Show();
        }

        private void imagePathTextField_TextChanged(object sender, EventArgs e)
        {
            if (overlayWindow != null)
            {
                overlayWindow.ImagePath = imagePathTextField.Text;
            }
        }

        private void opacityField_ValueChanged(object sender, EventArgs e)
        {
            UpdateOverlayOpacity();
        }

        private void SetClickthroughEnabled(bool enabled)
        {
            IntPtr currentStyle = GetWindowLongPtr(overlayWindow.Handle, -20); // GWL_EXSTYLE
            IntPtr newStyle;

            if (enabled)
            {
                newStyle = new IntPtr((long)currentStyle | WS_EX_TRANSPARENT); // Enable clickthrough
            }
            else
            {
                newStyle = new IntPtr((long)currentStyle & ~WS_EX_TRANSPARENT); // Disable clickthrough
            }

            SetWindowLongPtr(overlayWindow.Handle, -20, newStyle); // GWL_EXSTYLE
        }

        private void clickThroughToggle_CheckedChanged(object sender, EventArgs e)
        {
            SetClickthroughEnabled(clickThroughToggle.Checked);
        }

        private void hideOverlayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOverlayOpacity();
        }

        private void UpdateOverlayOpacity()
        {
            if (overlayWindow != null)
                overlayWindow.Opacity = hideOverlayCheckbox.Checked ? 0 : (double)opacityField.Value / 100;
        }

        private void OpacityPresetBtn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            opacityField.Value = decimal.Parse(btn.Tag.ToString());
            UpdateOverlayOpacity();
        }
    }

}
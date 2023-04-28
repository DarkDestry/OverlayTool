namespace OverlayTool
{
    partial class OverlayWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imageBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            SuspendLayout();
            // 
            // imageBox
            // 
            imageBox.Location = new Point(0, 0);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(800, 450);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 0;
            imageBox.TabStop = false;
            imageBox.MouseDown += Form_MouseDown;
            imageBox.MouseMove += Form_MouseMove;
            imageBox.MouseUp += Form_MouseUp;
            // 
            // OverlayWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(imageBox);
            Name = "OverlayWindow";
            Text = "OverlayWindow";
            TransparencyKey = Color.White;
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
            MouseUp += Form_MouseUp;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imageBox;
    }
}
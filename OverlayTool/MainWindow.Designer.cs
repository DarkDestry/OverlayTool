namespace OverlayTool
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imagePathTextField = new TextBox();
            imagePathLabel = new Label();
            browseImagePathBtn = new Button();
            transparentWindowControlsGroupBox = new GroupBox();
            hideOverlayCheckbox = new CheckBox();
            clickThroughToggle = new CheckBox();
            label1 = new Label();
            opacityField = new NumericUpDown();
            openOverlayButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            transparentWindowControlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)opacityField).BeginInit();
            SuspendLayout();
            // 
            // imagePathTextField
            // 
            imagePathTextField.Location = new Point(135, 15);
            imagePathTextField.Name = "imagePathTextField";
            imagePathTextField.Size = new Size(526, 31);
            imagePathTextField.TabIndex = 0;
            imagePathTextField.TextChanged += imagePathTextField_TextChanged;
            // 
            // imagePathLabel
            // 
            imagePathLabel.AutoSize = true;
            imagePathLabel.Location = new Point(28, 18);
            imagePathLabel.Name = "imagePathLabel";
            imagePathLabel.Size = new Size(101, 25);
            imagePathLabel.TabIndex = 1;
            imagePathLabel.Text = "Image Path";
            // 
            // browseImagePathBtn
            // 
            browseImagePathBtn.Location = new Point(667, 13);
            browseImagePathBtn.Name = "browseImagePathBtn";
            browseImagePathBtn.Size = new Size(112, 34);
            browseImagePathBtn.TabIndex = 2;
            browseImagePathBtn.Text = "Browse";
            browseImagePathBtn.UseVisualStyleBackColor = true;
            browseImagePathBtn.Click += button1_Click;
            // 
            // transparentWindowControlsGroupBox
            // 
            transparentWindowControlsGroupBox.Controls.Add(button6);
            transparentWindowControlsGroupBox.Controls.Add(button5);
            transparentWindowControlsGroupBox.Controls.Add(button4);
            transparentWindowControlsGroupBox.Controls.Add(button3);
            transparentWindowControlsGroupBox.Controls.Add(button2);
            transparentWindowControlsGroupBox.Controls.Add(button1);
            transparentWindowControlsGroupBox.Controls.Add(hideOverlayCheckbox);
            transparentWindowControlsGroupBox.Controls.Add(clickThroughToggle);
            transparentWindowControlsGroupBox.Controls.Add(label1);
            transparentWindowControlsGroupBox.Controls.Add(opacityField);
            transparentWindowControlsGroupBox.Controls.Add(openOverlayButton);
            transparentWindowControlsGroupBox.Location = new Point(28, 66);
            transparentWindowControlsGroupBox.Name = "transparentWindowControlsGroupBox";
            transparentWindowControlsGroupBox.Size = new Size(751, 359);
            transparentWindowControlsGroupBox.TabIndex = 3;
            transparentWindowControlsGroupBox.TabStop = false;
            transparentWindowControlsGroupBox.Text = "Window Controls";
            // 
            // hideOverlayCheckbox
            // 
            hideOverlayCheckbox.AutoSize = true;
            hideOverlayCheckbox.Location = new Point(24, 143);
            hideOverlayCheckbox.Name = "hideOverlayCheckbox";
            hideOverlayCheckbox.Size = new Size(140, 29);
            hideOverlayCheckbox.TabIndex = 4;
            hideOverlayCheckbox.Text = "Hide Overlay";
            hideOverlayCheckbox.UseVisualStyleBackColor = true;
            hideOverlayCheckbox.CheckedChanged += hideOverlayCheckbox_CheckedChanged;
            // 
            // clickThroughToggle
            // 
            clickThroughToggle.AutoSize = true;
            clickThroughToggle.Location = new Point(24, 95);
            clickThroughToggle.Name = "clickThroughToggle";
            clickThroughToggle.Size = new Size(138, 29);
            clickThroughToggle.TabIndex = 3;
            clickThroughToggle.Text = "Clickthrough";
            clickThroughToggle.UseVisualStyleBackColor = true;
            clickThroughToggle.CheckedChanged += clickThroughToggle_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 42);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Opacity %";
            // 
            // opacityField
            // 
            opacityField.Location = new Point(123, 40);
            opacityField.Name = "opacityField";
            opacityField.Size = new Size(117, 31);
            opacityField.TabIndex = 1;
            opacityField.Value = new decimal(new int[] { 50, 0, 0, 0 });
            opacityField.ValueChanged += opacityField_ValueChanged;
            // 
            // openOverlayButton
            // 
            openOverlayButton.Location = new Point(623, 309);
            openOverlayButton.Name = "openOverlayButton";
            openOverlayButton.Size = new Size(112, 34);
            openOverlayButton.TabIndex = 0;
            openOverlayButton.Text = "Open Window";
            openOverlayButton.UseVisualStyleBackColor = true;
            openOverlayButton.Click += openOverlayButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(366, 37);
            button1.Name = "button1";
            button1.Size = new Size(69, 34);
            button1.TabIndex = 5;
            button1.Tag = "20";
            button1.Text = "20%";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpacityPresetBtn_Clicked;
            // 
            // button2
            // 
            button2.Location = new Point(441, 37);
            button2.Name = "button2";
            button2.Size = new Size(69, 34);
            button2.TabIndex = 6;
            button2.Tag = "40";
            button2.Text = "40%";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OpacityPresetBtn_Clicked;
            // 
            // button3
            // 
            button3.Location = new Point(516, 37);
            button3.Name = "button3";
            button3.Size = new Size(69, 34);
            button3.TabIndex = 7;
            button3.Tag = "60";
            button3.Text = "60%";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OpacityPresetBtn_Clicked;
            // 
            // button4
            // 
            button4.Location = new Point(591, 37);
            button4.Name = "button4";
            button4.Size = new Size(69, 34);
            button4.TabIndex = 8;
            button4.Tag = "80";
            button4.Text = "80%";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OpacityPresetBtn_Clicked;
            // 
            // button5
            // 
            button5.Location = new Point(666, 37);
            button5.Name = "button5";
            button5.Size = new Size(69, 34);
            button5.TabIndex = 9;
            button5.Tag = "100";
            button5.Text = "100%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += OpacityPresetBtn_Clicked;
            // 
            // button6
            // 
            button6.Location = new Point(291, 37);
            button6.Name = "button6";
            button6.Size = new Size(69, 34);
            button6.TabIndex = 10;
            button6.Tag = "0";
            button6.Text = "0%";
            button6.UseVisualStyleBackColor = true;
            button6.Click += OpacityPresetBtn_Clicked;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transparentWindowControlsGroupBox);
            Controls.Add(browseImagePathBtn);
            Controls.Add(imagePathLabel);
            Controls.Add(imagePathTextField);
            Name = "MainWindow";
            Text = "UI Overlay Tool";
            transparentWindowControlsGroupBox.ResumeLayout(false);
            transparentWindowControlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)opacityField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imagePathTextField;
        private Label imagePathLabel;
        private Button browseImagePathBtn;
        private GroupBox transparentWindowControlsGroupBox;
        private Button openOverlayButton;
        private Label label1;
        private NumericUpDown opacityField;
        private CheckBox clickThroughToggle;
        private CheckBox hideOverlayCheckbox;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
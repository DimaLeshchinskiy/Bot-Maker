using System.Windows.Forms;

namespace BotMaker
{
    partial class SetLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetLocationForm));
            this.ScreenshotName_ComboBox = new System.Windows.Forms.ComboBox();
            this.Image_scr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_scr)).BeginInit();
            this.SuspendLayout();
            // 
            // ScreenshotName_ComboBox
            // 
            this.ScreenshotName_ComboBox.FormattingEnabled = true;
            this.ScreenshotName_ComboBox.Location = new System.Drawing.Point(12, 12);
            this.ScreenshotName_ComboBox.Name = "ScreenshotName_ComboBox";
            this.ScreenshotName_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ScreenshotName_ComboBox.TabIndex = 0;
            this.ScreenshotName_ComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenshotName_ComboBox_SelectedIndexChanged);
            // 
            // Image_scr
            // 
            this.Image_scr.Location = new System.Drawing.Point(12, 39);
            this.Image_scr.Name = "Image_scr";
            this.Image_scr.Size = new System.Drawing.Size(530, 299);
            this.Image_scr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_scr.TabIndex = 2;
            this.Image_scr.TabStop = false;
            this.Image_scr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Image_Click);
            // 
            // SetLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 346);
            this.Controls.Add(this.Image_scr);
            this.Controls.Add(this.ScreenshotName_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Cursor Location";
            ((System.ComponentModel.ISupportInitialize)(this.Image_scr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ScreenshotName_ComboBox;
        private System.Windows.Forms.PictureBox Image_scr;
    }
}
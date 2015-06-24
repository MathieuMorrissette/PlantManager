namespace PlantManager
{
    partial class ViewPictureForm
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
            this.pbImagePlant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlant)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagePlant
            // 
            this.pbImagePlant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImagePlant.Location = new System.Drawing.Point(12, 12);
            this.pbImagePlant.Name = "pbImagePlant";
            this.pbImagePlant.Size = new System.Drawing.Size(260, 237);
            this.pbImagePlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagePlant.TabIndex = 0;
            this.pbImagePlant.TabStop = false;
            // 
            // ViewPictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbImagePlant);
            this.Name = "ViewPictureForm";
            this.Text = "ViewPicture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePlant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagePlant;
    }
}
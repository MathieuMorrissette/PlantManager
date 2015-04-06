namespace PlantManager
{
    partial class ManageSunLevelsForm
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
            this.lstSunLevels = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtSunLevelName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSunLevels
            // 
            this.lstSunLevels.FullRowSelect = true;
            this.lstSunLevels.Location = new System.Drawing.Point(12, 38);
            this.lstSunLevels.Name = "lstSunLevels";
            this.lstSunLevels.Size = new System.Drawing.Size(181, 158);
            this.lstSunLevels.TabIndex = 12;
            this.lstSunLevels.UseCompatibleStateImageBehavior = false;
            this.lstSunLevels.View = System.Windows.Forms.View.Details;
            this.lstSunLevels.SelectedIndexChanged += new System.EventHandler(this.lstSunLevels_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(170, 10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSunLevelName
            // 
            this.txtSunLevelName.Location = new System.Drawing.Point(12, 11);
            this.txtSunLevelName.Name = "txtSunLevelName";
            this.txtSunLevelName.Size = new System.Drawing.Size(151, 20);
            this.txtSunLevelName.TabIndex = 10;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 202);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ManageSunLevelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 239);
            this.Controls.Add(this.lstSunLevels);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtSunLevelName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManageSunLevelsForm";
            this.Text = "ManageSunLevelsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSunLevels;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSunLevelName;
        private System.Windows.Forms.Button btDelete;
    }
}
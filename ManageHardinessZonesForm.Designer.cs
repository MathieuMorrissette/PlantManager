namespace PlantManager
{
    partial class ManageHardinessZonesForm
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
            this.lstHardinessZones = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtZoneName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHardinessZones
            // 
            this.lstHardinessZones.FullRowSelect = true;
            this.lstHardinessZones.Location = new System.Drawing.Point(12, 39);
            this.lstHardinessZones.Name = "lstHardinessZones";
            this.lstHardinessZones.Size = new System.Drawing.Size(181, 158);
            this.lstHardinessZones.TabIndex = 8;
            this.lstHardinessZones.UseCompatibleStateImageBehavior = false;
            this.lstHardinessZones.View = System.Windows.Forms.View.Details;
            this.lstHardinessZones.SelectedIndexChanged += new System.EventHandler(this.lstHardinessZones_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(170, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtZoneName
            // 
            this.txtZoneName.Location = new System.Drawing.Point(12, 12);
            this.txtZoneName.Name = "txtZoneName";
            this.txtZoneName.Size = new System.Drawing.Size(151, 20);
            this.txtZoneName.TabIndex = 6;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 203);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ManageHardinessZonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 235);
            this.Controls.Add(this.lstHardinessZones);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtZoneName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManageHardinessZonesForm";
            this.Text = "ManageHardinessZonesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHardinessZones;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtZoneName;
        private System.Windows.Forms.Button btDelete;
    }
}
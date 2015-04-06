namespace PlantManager
{
    partial class ManageSoilTypesForm
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
            this.lstSoilTypes = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtSoilTypeName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSoilTypes
            // 
            this.lstSoilTypes.FullRowSelect = true;
            this.lstSoilTypes.Location = new System.Drawing.Point(12, 39);
            this.lstSoilTypes.Name = "lstSoilTypes";
            this.lstSoilTypes.Size = new System.Drawing.Size(181, 158);
            this.lstSoilTypes.TabIndex = 24;
            this.lstSoilTypes.UseCompatibleStateImageBehavior = false;
            this.lstSoilTypes.View = System.Windows.Forms.View.Details;
            this.lstSoilTypes.SelectedIndexChanged += new System.EventHandler(this.lstSoilTypes_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(170, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 23;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtSoilTypeName
            // 
            this.txtSoilTypeName.Location = new System.Drawing.Point(12, 12);
            this.txtSoilTypeName.Name = "txtSoilTypeName";
            this.txtSoilTypeName.Size = new System.Drawing.Size(151, 20);
            this.txtSoilTypeName.TabIndex = 22;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 203);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ManageSoilTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 239);
            this.Controls.Add(this.lstSoilTypes);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtSoilTypeName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManageSoilTypesForm";
            this.Text = "ManageSoilTypesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSoilTypes;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtSoilTypeName;
        private System.Windows.Forms.Button btDelete;
    }
}
namespace PlantManager
{
    partial class ManagePlantTypesForm
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
            this.lstPlantTypes = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPlantTypeName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPlantTypes
            // 
            this.lstPlantTypes.FullRowSelect = true;
            this.lstPlantTypes.Location = new System.Drawing.Point(12, 38);
            this.lstPlantTypes.Name = "lstPlantTypes";
            this.lstPlantTypes.Size = new System.Drawing.Size(181, 158);
            this.lstPlantTypes.TabIndex = 20;
            this.lstPlantTypes.UseCompatibleStateImageBehavior = false;
            this.lstPlantTypes.View = System.Windows.Forms.View.Details;
            this.lstPlantTypes.SelectedIndexChanged += new System.EventHandler(this.lstPlantTypes_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(170, 10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPlantTypeName
            // 
            this.txtPlantTypeName.Location = new System.Drawing.Point(12, 11);
            this.txtPlantTypeName.Name = "txtPlantTypeName";
            this.txtPlantTypeName.Size = new System.Drawing.Size(151, 20);
            this.txtPlantTypeName.TabIndex = 18;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 202);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 17;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ManagePlantTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 237);
            this.Controls.Add(this.lstPlantTypes);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPlantTypeName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManagePlantTypesForm";
            this.Text = "ManagePlantTypesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPlantTypes;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtPlantTypeName;
        private System.Windows.Forms.Button btDelete;
    }
}
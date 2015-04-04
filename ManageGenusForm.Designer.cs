namespace PlantManager
{
    partial class ManageGenusForm
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
            this.btDelete = new System.Windows.Forms.Button();
            this.txtGenusName = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lstGenus = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(13, 206);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtGenusName
            // 
            this.txtGenusName.Location = new System.Drawing.Point(13, 15);
            this.txtGenusName.Name = "txtGenusName";
            this.txtGenusName.Size = new System.Drawing.Size(151, 20);
            this.txtGenusName.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(171, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lstGenus
            // 
            this.lstGenus.FullRowSelect = true;
            this.lstGenus.Location = new System.Drawing.Point(13, 42);
            this.lstGenus.Name = "lstGenus";
            this.lstGenus.Size = new System.Drawing.Size(181, 158);
            this.lstGenus.TabIndex = 4;
            this.lstGenus.UseCompatibleStateImageBehavior = false;
            this.lstGenus.View = System.Windows.Forms.View.Details;
            this.lstGenus.SelectedIndexChanged += new System.EventHandler(this.lstGenus_SelectedIndexChanged);
            // 
            // ManageGenusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 244);
            this.Controls.Add(this.lstGenus);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtGenusName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManageGenusForm";
            this.Text = "ManageGenusForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtGenusName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ListView lstGenus;
    }
}
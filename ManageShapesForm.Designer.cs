namespace PlantManager
{
    partial class ManageShapesForm
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
            this.lstShapes = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtShapeName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstShapes
            // 
            this.lstShapes.FullRowSelect = true;
            this.lstShapes.Location = new System.Drawing.Point(12, 38);
            this.lstShapes.Name = "lstShapes";
            this.lstShapes.Size = new System.Drawing.Size(181, 158);
            this.lstShapes.TabIndex = 16;
            this.lstShapes.UseCompatibleStateImageBehavior = false;
            this.lstShapes.View = System.Windows.Forms.View.Details;
            this.lstShapes.SelectedIndexChanged += new System.EventHandler(this.lstShapes_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(170, 10);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(23, 23);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtShapeName
            // 
            this.txtShapeName.Location = new System.Drawing.Point(12, 11);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Size = new System.Drawing.Size(151, 20);
            this.txtShapeName.TabIndex = 14;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 202);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ManageShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 235);
            this.Controls.Add(this.lstShapes);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtShapeName);
            this.Controls.Add(this.btDelete);
            this.Name = "ManageShapesForm";
            this.Text = "ManageShapesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstShapes;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtShapeName;
        private System.Windows.Forms.Button btDelete;
    }
}
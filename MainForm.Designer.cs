namespace PlantManager
{
    partial class MainForm
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
            this.lstPlants = new System.Windows.Forms.ListView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.tcPlant = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCultivar = new System.Windows.Forms.TextBox();
            this.cbGenus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSearchImage = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btAddImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDetail = new System.Windows.Forms.TabPage();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageGenus = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.udHeight = new System.Windows.Forms.NumericUpDown();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.tcPlant.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tpDetail.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPlants
            // 
            this.lstPlants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstPlants.FullRowSelect = true;
            this.lstPlants.Location = new System.Drawing.Point(12, 59);
            this.lstPlants.MultiSelect = false;
            this.lstPlants.Name = "lstPlants";
            this.lstPlants.Size = new System.Drawing.Size(244, 369);
            this.lstPlants.TabIndex = 0;
            this.lstPlants.UseCompatibleStateImageBehavior = false;
            this.lstPlants.View = System.Windows.Forms.View.Details;
            this.lstPlants.SelectedIndexChanged += new System.EventHandler(this.lstPlants_SelectedIndexChanged);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDelete.Location = new System.Drawing.Point(181, 434);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAdd.Location = new System.Drawing.Point(12, 434);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.Enabled = false;
            this.btSaveChanges.Location = new System.Drawing.Point(441, 435);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(248, 23);
            this.btSaveChanges.TabIndex = 8;
            this.btSaveChanges.Text = "Enregistrer les modifications";
            this.btSaveChanges.UseVisualStyleBackColor = true;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // tcPlant
            // 
            this.tcPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPlant.Controls.Add(this.tpGeneral);
            this.tcPlant.Controls.Add(this.tpDetail);
            this.tcPlant.Location = new System.Drawing.Point(265, 27);
            this.tcPlant.Name = "tcPlant";
            this.tcPlant.SelectedIndex = 0;
            this.tcPlant.Size = new System.Drawing.Size(577, 408);
            this.tcPlant.TabIndex = 10;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.label4);
            this.tpGeneral.Controls.Add(this.txtCultivar);
            this.tpGeneral.Controls.Add(this.cbGenus);
            this.tpGeneral.Controls.Add(this.label3);
            this.tpGeneral.Controls.Add(this.btSearchImage);
            this.tpGeneral.Controls.Add(this.txtDescription);
            this.tpGeneral.Controls.Add(this.btAddImage);
            this.tpGeneral.Controls.Add(this.pbImage);
            this.tpGeneral.Controls.Add(this.label1);
            this.tpGeneral.Controls.Add(this.txtName);
            this.tpGeneral.Controls.Add(this.label2);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(569, 382);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Général";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cultivar :";
            // 
            // txtCultivar
            // 
            this.txtCultivar.Location = new System.Drawing.Point(83, 85);
            this.txtCultivar.Name = "txtCultivar";
            this.txtCultivar.Size = new System.Drawing.Size(222, 20);
            this.txtCultivar.TabIndex = 14;
            this.txtCultivar.TextChanged += new System.EventHandler(this.CheckChanges);
            // 
            // cbGenus
            // 
            this.cbGenus.AllowDrop = true;
            this.cbGenus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenus.FormattingEnabled = true;
            this.cbGenus.Location = new System.Drawing.Point(83, 45);
            this.cbGenus.Name = "cbGenus";
            this.cbGenus.Size = new System.Drawing.Size(222, 21);
            this.cbGenus.TabIndex = 12;
            this.cbGenus.SelectedIndexChanged += new System.EventHandler(this.CheckChanges);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Genre :";
            // 
            // btSearchImage
            // 
            this.btSearchImage.Location = new System.Drawing.Point(83, 264);
            this.btSearchImage.Name = "btSearchImage";
            this.btSearchImage.Size = new System.Drawing.Size(222, 23);
            this.btSearchImage.TabIndex = 10;
            this.btSearchImage.Text = "Rechercher une image";
            this.btSearchImage.UseVisualStyleBackColor = true;
            this.btSearchImage.Click += new System.EventHandler(this.btSearchImage_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(83, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(222, 136);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TextChanged += new System.EventHandler(this.CheckChanges);
            // 
            // btAddImage
            // 
            this.btAddImage.Location = new System.Drawing.Point(311, 264);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(245, 23);
            this.btAddImage.TabIndex = 9;
            this.btAddImage.Text = "Ajouter une image";
            this.btAddImage.UseVisualStyleBackColor = true;
            this.btAddImage.Click += new System.EventHandler(this.btAddImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(311, 13);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(245, 245);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.CheckChanges);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description :";
            // 
            // tpDetail
            // 
            this.tpDetail.Controls.Add(this.comboBox5);
            this.tpDetail.Controls.Add(this.label13);
            this.tpDetail.Controls.Add(this.label12);
            this.tpDetail.Controls.Add(this.comboBox4);
            this.tpDetail.Controls.Add(this.comboBox3);
            this.tpDetail.Controls.Add(this.label11);
            this.tpDetail.Controls.Add(this.comboBox2);
            this.tpDetail.Controls.Add(this.label10);
            this.tpDetail.Controls.Add(this.label9);
            this.tpDetail.Controls.Add(this.comboBox1);
            this.tpDetail.Controls.Add(this.label8);
            this.tpDetail.Controls.Add(this.label7);
            this.tpDetail.Controls.Add(this.label6);
            this.tpDetail.Controls.Add(this.udWidth);
            this.tpDetail.Controls.Add(this.udHeight);
            this.tpDetail.Controls.Add(this.label5);
            this.tpDetail.Location = new System.Drawing.Point(4, 22);
            this.tpDetail.Name = "tpDetail";
            this.tpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetail.Size = new System.Drawing.Size(569, 382);
            this.tpDetail.TabIndex = 1;
            this.tpDetail.Text = "Détails";
            this.tpDetail.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(181, 32);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Recherche";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(12, 32);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(163, 20);
            this.txtSearchField.TabIndex = 12;
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.tsmiOptions});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(852, 24);
            this.msMainMenu.TabIndex = 13;
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClose});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmiFichier.Text = "Fichier";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(111, 22);
            this.tsmiClose.Text = "&Quitter";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiManageGenus});
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(61, 20);
            this.tsmiOptions.Text = "Options";
            // 
            // tsmiManageGenus
            // 
            this.tsmiManageGenus.Name = "tsmiManageGenus";
            this.tsmiManageGenus.Size = new System.Drawing.Size(110, 22);
            this.tsmiManageGenus.Text = "Genres";
            this.tsmiManageGenus.Click += new System.EventHandler(this.tsmiManageGenus_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hauteur :";
            // 
            // udHeight
            // 
            this.udHeight.Location = new System.Drawing.Point(87, 19);
            this.udHeight.Name = "udHeight";
            this.udHeight.Size = new System.Drawing.Size(62, 20);
            this.udHeight.TabIndex = 3;
            this.udHeight.ValueChanged += new System.EventHandler(this.CheckChanges);
            // 
            // udWidth
            // 
            this.udWidth.Location = new System.Drawing.Point(87, 45);
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(62, 20);
            this.udWidth.TabIndex = 4;
            this.udWidth.ValueChanged += new System.EventHandler(this.CheckChanges);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Largeur :";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(155, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "cm";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(155, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "cm";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Zone de rusticité :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Niveau d\'ensoleillement :";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 137);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Forme :";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(28, 177);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(28, 217);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Type de plante :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Type de sol :";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(28, 262);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 471);
            this.Controls.Add(this.txtSearchField);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tcPlant);
            this.Controls.Add(this.btSaveChanges);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lstPlants);
            this.Controls.Add(this.msMainMenu);
            this.MainMenuStrip = this.msMainMenu;
            this.MinimumSize = new System.Drawing.Size(773, 487);
            this.Name = "MainForm";
            this.Text = "PlantManager";
            this.tcPlant.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tpDetail.ResumeLayout(false);
            this.tpDetail.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPlants;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.TabControl tcPlant;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btAddImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpDetail;
        private System.Windows.Forms.Button btSearchImage;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageGenus;
        private System.Windows.Forms.ComboBox cbGenus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCultivar;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.NumericUpDown udHeight;
        private System.Windows.Forms.Label label5;
    }
}


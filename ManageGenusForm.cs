﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class ManageGenusForm : Form
    {
        public ManageGenusForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstGenus.Columns.Add("ID", 0);
            lstGenus.Columns.Add("Genre", lstGenus.Width - 5);

            RefreshList();
        }

        private void RefreshList()
        {
            lstGenus.Items.Clear();

            Genus[] genus = Genus.GetAllGenus();

            foreach (ListViewItem lvi in genus.Select(item => new ListViewItem(new[] {item.Id.ToString(), item.Name})))
            {
                lstGenus.Items.Add(lvi);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtGenusName.Text != string.Empty)
                Genus.AddGenus(txtGenusName.Text);

            txtGenusName.Text = string.Empty;

            RefreshList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstGenus.SelectedItems.Count <= 0) return;
            string genusId = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

            Genus.DeleteGenusById(Convert.ToInt32(genusId));

            RefreshList();
        }

        private void lstGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstGenus.SelectedItems.Count <= 0) return;
            string genusId = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(genusId) != -1;
        }

        private void txtGenusName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
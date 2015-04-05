using System;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class ManageGenusForm : Form
    {
        public ManageGenusForm()
        {
            InitializeComponent();

            lstGenus.Columns.Add("ID", 0);
            lstGenus.Columns.Add("Genre", lstGenus.Width - 5);

            RefreshList();
        }

        private void RefreshList()
        {
            lstGenus.Items.Clear();

            Genus[] genus = Genus.GetAllGenus();

            foreach (Genus item in genus)
            {
                ListViewItem lvi = new ListViewItem(new[] {item.Id.ToString(), item.Name});
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
            if (lstGenus.SelectedItems.Count > 0)
            {
                string genusId = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

                Genus.DeleteGenusById(Convert.ToInt32(genusId));

                RefreshList();
            }
        }

        private void lstGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstGenus.SelectedItems.Count > 0)
            {
                string genusId = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

                btDelete.Enabled = Convert.ToInt32(genusId) != -1;
            }
        }
    }
}
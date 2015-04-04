using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.RefreshList();
        }

        private void RefreshList()
        {
            this.lstGenus.Items.Clear();

            Genus[] genus = Genus.GetAllGenus();

            foreach(Genus item in genus)
            {
                ListViewItem lvi = new ListViewItem( new [] {item.ID.ToString(), item.Name} );
                lstGenus.Items.Add(lvi);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(txtGenusName.Text != string.Empty)
                Genus.AddGenus(txtGenusName.Text);

            txtGenusName.Text = string.Empty;

            this.RefreshList();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstGenus.SelectedItems.Count > 0)
            {
                string GenusID = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

                Genus.DeleteGenusByID(Convert.ToInt32(GenusID));

                this.RefreshList();
            }
        }

        private void lstGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstGenus.SelectedItems.Count > 0)
            {
                string GenusID = lstGenus.Items[lstGenus.SelectedIndices[0]].SubItems[0].Text;

                btDelete.Enabled = Convert.ToInt32(GenusID) != -1; 
            }
        }
    }
}

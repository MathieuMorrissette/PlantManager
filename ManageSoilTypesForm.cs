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
    public partial class ManageSoilTypesForm : Form
    {
        public ManageSoilTypesForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstSoilTypes.Columns.Add("ID", 0);
            lstSoilTypes.Columns.Add("Nom", lstSoilTypes.Width - 5);

            RefreshList();
        }

        private void RefreshList()
        {
            lstSoilTypes.Items.Clear();

            SoilType[] soilTypes = SoilType.GetAllSoilTypes();

            foreach (
                ListViewItem lvi in soilTypes.Select(item => new ListViewItem(new[] { item.Id.ToString(), item.Name })))
            {
                lstSoilTypes.Items.Add(lvi);
            }
        }


        private void lstSoilTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstSoilTypes.SelectedItems.Count <= 0) return;

            string soilTypeId = lstSoilTypes.Items[lstSoilTypes.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(soilTypeId) != -1;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstSoilTypes.SelectedItems.Count <= 0) return;

            string soilTypeId = lstSoilTypes.Items[lstSoilTypes.SelectedIndices[0]].SubItems[0].Text;

            SoilType.DeleteSoilTypeById(Convert.ToInt32(soilTypeId));

            RefreshList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtSoilTypeName.Text != string.Empty)
                SoilType.AddSoilType(txtSoilTypeName.Text);

            txtSoilTypeName.Text = string.Empty;

            RefreshList();
        }
    }
}

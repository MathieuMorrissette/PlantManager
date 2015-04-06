using System;
using System.Linq;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class ManageHardinessZonesForm : Form
    {
        public ManageHardinessZonesForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstHardinessZones.Columns.Add("ID", 0);
            lstHardinessZones.Columns.Add("Nom", lstHardinessZones.Width - 5);

            RefreshList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtZoneName.Text != string.Empty)
                HardinessZone.AddHardinessZone(txtZoneName.Text);

            txtZoneName.Text = string.Empty;

            RefreshList();
        }

        private void RefreshList()
        {
            lstHardinessZones.Items.Clear();

            HardinessZone[] hardinessZones = HardinessZone.GetAllHardinessZones();

            foreach (
                ListViewItem lvi in
                    hardinessZones.Select(item => new ListViewItem(new[] {item.Id.ToString(), item.Name})))
            {
                lstHardinessZones.Items.Add(lvi);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstHardinessZones.SelectedItems.Count <= 0) return;

            string hardinessZoneId = lstHardinessZones.Items[lstHardinessZones.SelectedIndices[0]].SubItems[0].Text;

            HardinessZone.DeleteHardinessZoneById(Convert.ToInt32(hardinessZoneId));

            RefreshList();
        }

        private void lstHardinessZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstHardinessZones.SelectedItems.Count <= 0) return;

            string hardinessZoneId = lstHardinessZones.Items[lstHardinessZones.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(hardinessZoneId) != -1;
        }
    }
}
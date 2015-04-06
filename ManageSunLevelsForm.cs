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
    public partial class ManageSunLevelsForm : Form
    {
        public ManageSunLevelsForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstSunLevels.Columns.Add("ID", 0);
            lstSunLevels.Columns.Add("Nom", lstSunLevels.Width - 5);

            RefreshList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtSunLevelName.Text != string.Empty)
                SunLevel.AddSunLevel(txtSunLevelName.Text);

            txtSunLevelName.Text = string.Empty;

            RefreshList();
        }

        private void RefreshList()
        {
            lstSunLevels.Items.Clear();

            SunLevel[] sunLevels = SunLevel.GetAllSunLevels();

            foreach (
                ListViewItem lvi in sunLevels.Select(item => new ListViewItem(new[] {item.Id.ToString(), item.Name})))
            {
                lstSunLevels.Items.Add(lvi);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstSunLevels.SelectedItems.Count <= 0) return;

            string sunLevelId = lstSunLevels.Items[lstSunLevels.SelectedIndices[0]].SubItems[0].Text;

            SunLevel.DeleteSunLevelById(Convert.ToInt32(sunLevelId));

            RefreshList();
        }

        private void lstSunLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstSunLevels.SelectedItems.Count <= 0) return;

            string sunLevelId = lstSunLevels.Items[lstSunLevels.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(sunLevelId) != -1;
        }
    }
}
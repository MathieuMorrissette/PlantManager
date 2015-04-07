using System;
using System.Linq;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class ManagePlantTypesForm : Form
    {
        public ManagePlantTypesForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstPlantTypes.Columns.Add("ID", 0);
            lstPlantTypes.Columns.Add("Nom", lstPlantTypes.Width - 5);

            RefreshList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtPlantTypeName.Text != string.Empty)
                PlantType.AddPlantType(txtPlantTypeName.Text);

            txtPlantTypeName.Text = string.Empty;

            RefreshList();
        }

        private void RefreshList()
        {
            lstPlantTypes.Items.Clear();

            PlantType[] plantTypes = PlantType.GetAllPlantTypes();

            foreach (
                ListViewItem lvi in plantTypes.Select(item => new ListViewItem(new[] {item.Id.ToString(), item.Name})))
            {
                lstPlantTypes.Items.Add(lvi);
            }
        }

        private void lstPlantTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstPlantTypes.SelectedItems.Count <= 0) return;

            string plantTypeId = lstPlantTypes.Items[lstPlantTypes.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(plantTypeId) != -1;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstPlantTypes.SelectedItems.Count <= 0) return;

            string plantTypeId = lstPlantTypes.Items[lstPlantTypes.SelectedIndices[0]].SubItems[0].Text;

            PlantType.DeletePlantTypeById(Convert.ToInt32(plantTypeId));

            RefreshList();
        }
    }
}
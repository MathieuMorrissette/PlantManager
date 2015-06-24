using System;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class AddPlantForm : Form
    {
        public AddPlantForm()
        {
            InitializeComponent();
            LoadGenusCombo();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Plant.AddPlant((int)cbGenus.SelectedValue, txtSpecies.Text, txtCultivar.Text, txtDescription.Text);
            Close();
        }

        private void LoadGenusCombo()
        {
            Genus[] genuses = Genus.GetAllGenus();

            cbGenus.DataSource = genuses;
            cbGenus.DisplayMember = "Name";
            cbGenus.ValueMember = "ID";

            cbGenus.SelectedIndex = 0;
            //Dont forget to check if theres no genus added they need to add before adding a plant
        }
    }
}
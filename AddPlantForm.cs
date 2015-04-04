using System;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class AddPlantForm : Form
    {
        public AddPlantForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Plant.AddPlant(txtName.Text, txtDescription.Text);
            Close();
        }
    }
}
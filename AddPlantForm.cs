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
    public partial class AddPlantForm : Form
    {
        DB m_db;

        public AddPlantForm(DB _db)
        {
            InitializeComponent();

            m_db = _db;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Plant.AddPlant(txtName.Text, txtDescription.Text);
            this.Close();        
        }
    }
}

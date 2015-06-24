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
    public partial class ViewPictureForm : Form
    {
        public ViewPictureForm(Image img, string plantName)
        {
            InitializeComponent();

            pbImagePlant.Image = img;
            this.Text = plantName; 
        }
    }
}

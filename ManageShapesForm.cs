using System;
using System.Linq;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class ManageShapesForm : Form
    {
        public ManageShapesForm()
        {
            InitializeComponent();
            btDelete.Enabled = false;

            lstShapes.Columns.Add("ID", 0);
            lstShapes.Columns.Add("Nom", lstShapes.Width - 5);

            RefreshList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtShapeName.Text != string.Empty)
                Shape.AddShape(txtShapeName.Text);

            txtShapeName.Text = string.Empty;

            RefreshList();
        }

        private void RefreshList()
        {
            lstShapes.Items.Clear();

            Shape[] shapes = Shape.GetAllShapes();

            foreach (
                ListViewItem lvi in shapes.Select(item => new ListViewItem(new[] {item.Id.ToString(), item.Name})))
            {
                lstShapes.Items.Add(lvi);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstShapes.SelectedItems.Count <= 0) return;

            string shapeId = lstShapes.Items[lstShapes.SelectedIndices[0]].SubItems[0].Text;

            Shape.DeleteShapeById(Convert.ToInt32(shapeId));

            RefreshList();
        }

        private void lstShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDelete.Enabled = false;

            if (lstShapes.SelectedItems.Count <= 0) return;

            string shapeId = lstShapes.Items[lstShapes.SelectedIndices[0]].SubItems[0].Text;

            btDelete.Enabled = Convert.ToInt32(shapeId) != -1;
        }
    }
}
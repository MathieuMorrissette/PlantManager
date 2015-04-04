using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class MainForm : Form
    {
        private Plant m_currentPlant;

        public MainForm()
        {
            InitializeComponent();

            //Ajouter les colonnes dans la liste.
            lstPlants.Columns.Add("ID", 0);
            lstPlants.Columns.Add("Name", -2);

            //Afficher les plantes dans la liste.
            ReloadListView();

            //Charger les informations dans le combobox des genres.
            LoadGenusCombo();

            //Desactiver le bouton pour sauvegarder les changements.
            btSaveChanges.Enabled = false;

            //Cacher le TabControl.
            tcPlant.Enabled = false;
            tcPlant.Visible = false;
        }

        public void RefreshPlant()
        {
            pbImage.Image = null;
            txtDescription.Text = string.Empty;
            txtName.Text = string.Empty;
            udHeight.Value = 0;
            udWidth.Value = 0;

            txtName.Text = m_currentPlant.Name;
            txtCultivar.Text = m_currentPlant.Cultivar;

            txtDescription.Text = m_currentPlant.Description;
            cbGenus.SelectedValue = m_currentPlant.genus.ID;

            udHeight.Value = m_currentPlant.Height;
            udWidth.Value = m_currentPlant.Width;

            pbImage.Image = m_currentPlant.Img;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddPlantForm addPlantForm = new AddPlantForm();
            addPlantForm.ShowDialog();
            ReloadListView();
        }

        private void ReloadListView()
        {
            Plant[] Plants = Plant.GetAllPlant();

            lstPlants.Items.Clear();

            foreach (Plant plant in Plants)
            {
                string customizeName = string.Empty;
                if (plant.genus.ID != Genus.GetDefaultGenus().ID)
                    customizeName += plant.genus.Name + " ";
                ListViewItem lvi =
                    new ListViewItem(new[] {plant.ID.ToString(), customizeName + plant.Name, plant.Description});
                lstPlants.Items.Add(lvi);
            }
        }

        private void LoadGenusCombo()
        {
            Genus[] genuses = Genus.GetAllGenus();

            cbGenus.DataSource = genuses;
            cbGenus.DisplayMember = "Name";
            cbGenus.ValueMember = "ID";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstPlants.SelectedItems.Count > 0)
            {
                string PlantID = lstPlants.Items[lstPlants.SelectedIndices[0]].SubItems[0].Text;

                if (PlantID == m_currentPlant.ID.ToString())
                {
                    m_currentPlant = null;
                    tcPlant.Visible = false;
                    tcPlant.Enabled = false;
                }

                Plant.DeletePlantByID(Convert.ToInt32(PlantID));
                ReloadListView();
            }
        }

        private void lstPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlants.SelectedItems.Count > 0)
            {
                string PlantID = lstPlants.Items[lstPlants.SelectedIndices[0]].SubItems[0].Text;
                Plant maPlante = Plant.GetPlantByID(Convert.ToInt32(PlantID));

                //Afficher un message si les modifications n'ont pas ete enregistres.
                m_currentPlant = maPlante;
                tcPlant.Enabled = true;
                tcPlant.Visible = true;
                RefreshPlant();
            }
            else
            {
                tcPlant.Enabled = false;
                tcPlant.Visible = false;
            }
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if (m_currentPlant == null)
            {
                return;
            }
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show(Constants.DIALOG_NAME_CANNOT_BE_BLANK);
            }

            if (txtName.Text != m_currentPlant.Name ||
                txtDescription.Text != m_currentPlant.Description)
            {
                Plant.UpdatePlantBase(m_currentPlant.ID, txtName.Text, txtDescription.Text);
            }


            if ((int) cbGenus.SelectedValue != m_currentPlant.genus.ID)
                Plant.UpdatePlantGenus(m_currentPlant.ID, (int) cbGenus.SelectedValue);

            if (txtCultivar.Text != m_currentPlant.Cultivar)
                Plant.UpdatePlantCultivar(m_currentPlant.ID, txtCultivar.Text);

            if (udHeight.Value != m_currentPlant.Height)
                Plant.UpdatePlantHeight(m_currentPlant.ID, (int) udHeight.Value);

            if (udWidth.Value != m_currentPlant.Width)
                Plant.UpdatePlantWidth(m_currentPlant.ID, (int) udWidth.Value);

            btSaveChanges.Enabled = false;
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (m_currentPlant != null)
            {
                ImagePlant.DeleteImageByPlantID(m_currentPlant.ID);
                ImagePlant.AddImage(m_currentPlant.ID, dlg.FileName);

                pbImage.Image = m_currentPlant.Img;
            }
        }

        private void btSearchImage_Click(object sender, EventArgs e)
        {
            string searchString = string.Empty;

            if (m_currentPlant.genus.ID != -1)
                searchString += m_currentPlant.genus.Name + " ";

            searchString += m_currentPlant.Name + " " + m_currentPlant.Cultivar;

            Process.Start("http://images.google.com/search?tbm=isch&q=" + searchString);
        }

        private void CheckChanges(object sender, EventArgs e)
        {
            bool enableSave = false;

            if (m_currentPlant == null)
                return;

            if (txtName.Text != m_currentPlant.Name)
                enableSave = true;

            if (txtDescription.Text != m_currentPlant.Description)
                enableSave = true;

            if ((int) cbGenus.SelectedValue != m_currentPlant.genus.ID)
                enableSave = true;

            if (txtCultivar.Text != m_currentPlant.Cultivar)
                enableSave = true;

            if (udHeight.Value != m_currentPlant.Height)
                enableSave = true;

            if (udWidth.Value != m_currentPlant.Width)
                enableSave = true;

            btSaveChanges.Enabled = enableSave;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            tcPlant.Visible = false;
            Plant[] Plants = Plant.GetAllPlantByNameContains(txtSearchField.Text);

            lstPlants.Items.Clear();

            foreach (Plant plant in Plants)
            {
                ListViewItem lvi = new ListViewItem(new[] {plant.ID.ToString(), plant.Name});
                lstPlants.Items.Add(lvi);
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiManageGenus_Click(object sender, EventArgs e)
        {
            ManageGenusForm manageGenusForm = new ManageGenusForm();
            manageGenusForm.ShowDialog();

            LoadGenusCombo();

            if (m_currentPlant != null)
                cbGenus.SelectedValue = m_currentPlant.genus.ID;
        }
    }
}
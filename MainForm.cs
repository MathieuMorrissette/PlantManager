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
    public partial class MainForm : Form
    {
        DB m_db;
        Plant m_currentPlant;

        public MainForm()
        {
            InitializeComponent();

            //Ajouter les colonnes dans la liste.
            lstPlants.Columns.Add("ID", 0);
            lstPlants.Columns.Add("Name", 100);
            lstPlants.Columns.Add("Description", lstPlants.Width - 105);

            //Afficher les plantes dans la liste.
            ReloadListView();

            //Charger les informations dans le combobox des genres.
            this.LoadGenusCombo();

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

            txtName.Text = m_currentPlant.Name;
            txtCultivar.Text = m_currentPlant.Cultivar;

            txtDescription.Text = m_currentPlant.Description;
            cbGenus.SelectedValue = m_currentPlant.genus.ID;
          
            pbImage.Image = m_currentPlant.Img;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddPlantForm addPlantForm = new AddPlantForm(m_db);
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
                ListViewItem lvi = new ListViewItem( new [] {plant.ID.ToString(), customizeName + plant.Name , plant.Description} );
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
                this.RefreshPlant();
            }
            else
            {
                tcPlant.Enabled = false;
                tcPlant.Visible = false;
            }
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if (m_currentPlant != null)
            { 
                if(txtName.Text.Length < 1)
                {
                    MessageBox.Show(Constants.DIALOG_NAME_CANNOT_BE_BLANK);
                }

                Plant.UpdatePlantBase(m_currentPlant.ID, txtName.Text, txtDescription.Text);
                Plant.UpdatePlantGenus(m_currentPlant.ID, (int)cbGenus.SelectedValue);
                Plant.UpdatePlantCultivar(m_currentPlant.ID, txtCultivar.Text);

                btSaveChanges.Enabled = false;
            }
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

            searchString += m_currentPlant.Name;

            System.Diagnostics.Process.Start("http://images.google.com/search?tbm=isch&q=" + searchString );
        }

        private void CheckChanges(object sender, EventArgs e)
        {
            btSaveChanges.Enabled = false;

            if (m_currentPlant == null)
                return;

            if (txtName.Text != m_currentPlant.Name)
                btSaveChanges.Enabled = true;

            if (txtDescription.Text != m_currentPlant.Description)
                btSaveChanges.Enabled = true;

            if ((int)cbGenus.SelectedValue != m_currentPlant.genus.ID)
                btSaveChanges.Enabled = true;

            if (txtCultivar.Text != m_currentPlant.Cultivar)
                btSaveChanges.Enabled = true;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            tcPlant.Visible = false;
            Plant[] Plants = Plant.GetAllPlantByNameContains(txtSearchField.Text);
            
            lstPlants.Items.Clear();

            foreach (Plant plant in Plants)
            {
                ListViewItem lvi = new ListViewItem( new [] {plant.ID.ToString(), plant.Name, plant.Description} );
                lstPlants.Items.Add(lvi);
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiManageGenus_Click(object sender, EventArgs e)
        {
            ManageGenusForm manageGenusForm = new ManageGenusForm();
            manageGenusForm.ShowDialog();

            this.LoadGenusCombo();

            if(m_currentPlant != null)
                cbGenus.SelectedValue = m_currentPlant.genus.ID;
        }


    }
}

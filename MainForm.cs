using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantManager
{
    public partial class MainForm : Form
    {
        private Plant _mCurrentPlant;

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

            LoadHardinessZonesCombo();

            LoadSunLevelsCombo();

            //Desactiver le bouton pour sauvegarder les changements.
            btSaveChanges.Enabled = false;

            //Cacher le TabControl.
            tcPlant.Visible = false;
        }

        public void RefreshPlant()
        {
            pbImage.Image = null;
            txtDescription.Text = string.Empty;
            txtName.Text = string.Empty;
            udHeight.Value = 0;
            udWidth.Value = 0;

            txtName.Text = _mCurrentPlant.Name;
            txtCultivar.Text = _mCurrentPlant.Cultivar;

            txtDescription.Text = _mCurrentPlant.Description;
            cbGenus.SelectedValue = _mCurrentPlant.Genus.Id;

            cbHardinessZones.SelectedValue = _mCurrentPlant.HardZone.Id;
            cbSunLevels.SelectedValue = _mCurrentPlant.SunLvl.Id;

            udHeight.Value = _mCurrentPlant.Height;
            udWidth.Value = _mCurrentPlant.Width;

            pbImage.Image = _mCurrentPlant.Img;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddPlantForm addPlantForm = new AddPlantForm();
            addPlantForm.ShowDialog();
            ReloadListView();
        }

        private void ReloadListView()
        {
            Plant[] plants = Plant.GetAllPlant();

            lstPlants.BeginUpdate();
            lstPlants.Items.Clear();

            foreach (Plant plant in plants)
            {
                string customizeName = string.Empty;
                if (plant.Genus.Id != Genus.GetDefaultGenus().Id)
                    customizeName += plant.Genus.Name + " ";
                ListViewItem lvi =
                    new ListViewItem(new[] {plant.Id.ToString(), customizeName + plant.Name, plant.Description});
                lstPlants.Items.Add(lvi);
            }
            lstPlants.EndUpdate();
        }

        private void LoadGenusCombo()
        {
            Genus[] genuses = Genus.GetAllGenus();

            cbGenus.DataSource = genuses;
            cbGenus.DisplayMember = "Name";
            cbGenus.ValueMember = "ID";
        }

        private void LoadHardinessZonesCombo()
        {
            HardinessZone[] hardinessZones = HardinessZone.GetAllHardinessZones();

            cbHardinessZones.DataSource = hardinessZones;
            cbHardinessZones.DisplayMember = "Name";
            cbHardinessZones.ValueMember = "ID";
        }

        private void LoadSunLevelsCombo()
        {
            SunLevel[] sunLevels = SunLevel.GetAllSunLevels();

            cbSunLevels.DataSource = sunLevels;
            cbSunLevels.DisplayMember = "Name";
            cbSunLevels.ValueMember = "ID";
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lstPlants.SelectedItems.Count > 0)
            {
                string plantId = lstPlants.Items[lstPlants.SelectedIndices[0]].SubItems[0].Text;

                if (plantId == _mCurrentPlant.Id.ToString())
                {
                    _mCurrentPlant = null;
                    tcPlant.Visible = false;
                    tcPlant.Enabled = false;
                }

                Plant.DeletePlantById(Convert.ToInt32(plantId));
                ReloadListView();
            }
        }

        private void lstPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application.DoEvents();

            if (lstPlants.SelectedItems.Count > 0)
            {
                string plantId = lstPlants.Items[lstPlants.SelectedIndices[0]].SubItems[0].Text;
                Plant maPlante = Plant.GetPlantById(Convert.ToInt32(plantId));

                //Afficher un message si les modifications n'ont pas ete enregistres.
                _mCurrentPlant = maPlante;
                
                RefreshPlant();

                if (tcPlant.Visible) return;
                    tcPlant.Visible = true;
            }
            else
            {
               if (tcPlant.Visible == false) return;
                    tcPlant.Visible = false;
            }
        }

        private void btSaveChanges_Click(object sender, EventArgs e)
        {
            if (_mCurrentPlant == null)
            {
                return;
            }
            if (txtName.Text.Length < 1)
            {
                MessageBox.Show(Constants.DialogNameCannotBeBlank);
            }

            if (txtName.Text != _mCurrentPlant.Name ||
                txtDescription.Text != _mCurrentPlant.Description)
            {
                Plant.UpdatePlantBase(_mCurrentPlant.Id, txtName.Text, txtDescription.Text);
            }


            if ((int) cbGenus.SelectedValue != _mCurrentPlant.Genus.Id)
                Plant.UpdatePlantGenus(_mCurrentPlant.Id, (int) cbGenus.SelectedValue);

            if (txtCultivar.Text != _mCurrentPlant.Cultivar)
                Plant.UpdatePlantCultivar(_mCurrentPlant.Id, txtCultivar.Text);

            if (udHeight.Value != _mCurrentPlant.Height)
                Plant.UpdatePlantHeight(_mCurrentPlant.Id, (int) udHeight.Value);

            if (udWidth.Value != _mCurrentPlant.Width)
                Plant.UpdatePlantWidth(_mCurrentPlant.Id, (int) udWidth.Value);

            if((int)cbHardinessZones.SelectedValue != _mCurrentPlant.HardZone.Id)
                Plant.UpdatePlantHardinessZone(_mCurrentPlant.Id, (int) cbHardinessZones.SelectedValue);

            if ((int) cbSunLevels.SelectedValue != _mCurrentPlant.SunLvl.Id)
                Plant.UpdatePlantSunLevel(_mCurrentPlant.Id, (int) cbSunLevels.SelectedValue);

            btSaveChanges.Enabled = false;
        }

        private void btAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            if (_mCurrentPlant != null)
            {
                ImagePlant.DeleteImageByPlantId(_mCurrentPlant.Id);
                ImagePlant.AddImage(_mCurrentPlant.Id, dlg.FileName);

                pbImage.Image = _mCurrentPlant.Img;
            }
        }

        private void btSearchImage_Click(object sender, EventArgs e)
        {
            string searchString = string.Empty;

            if (_mCurrentPlant.Genus.Id != -1)
                searchString += _mCurrentPlant.Genus.Name + " ";

            searchString += _mCurrentPlant.Name + " " + _mCurrentPlant.Cultivar;

            Process.Start("http://images.google.com/search?tbm=isch&q=" + searchString);
        }

        private void CheckChanges(object sender, EventArgs e)
        {
            if (tcPlant.Visible == false)
                return;

            bool enableSave = false;

            if (_mCurrentPlant == null)
                return;

            if (txtName.Text != _mCurrentPlant.Name)
                enableSave = true;

            if (txtDescription.Text != _mCurrentPlant.Description)
                enableSave = true;

            if ((int) cbGenus.SelectedValue != _mCurrentPlant.Genus.Id)
                enableSave = true;

            if (txtCultivar.Text != _mCurrentPlant.Cultivar)
                enableSave = true;

            if (udHeight.Value != _mCurrentPlant.Height)
                enableSave = true;

            if (udWidth.Value != _mCurrentPlant.Width)
                enableSave = true;

            if ((int) cbHardinessZones.SelectedValue != _mCurrentPlant.HardZone.Id)
                enableSave = true;

            if ((int) cbSunLevels.SelectedValue != _mCurrentPlant.SunLvl.Id)
                enableSave = true;

            btSaveChanges.Enabled = enableSave;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            tcPlant.Visible = false;
            Plant[] plants = Plant.GetAllPlantByNameContains(txtSearchField.Text);

            lstPlants.Items.Clear();

            foreach (Plant plant in plants)
            {
                ListViewItem lvi = new ListViewItem(new[] {plant.Id.ToString(), plant.Name});
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

            if (_mCurrentPlant != null)
                cbGenus.SelectedValue = _mCurrentPlant.Genus.Id;
        }

        private void tsmiManageHardinessZones_Click(object sender, EventArgs e)
        {
            ManageHardinessZonesForm manageHardinessZonesForm = new ManageHardinessZonesForm();
            manageHardinessZonesForm.ShowDialog();

            LoadHardinessZonesCombo();

            if (_mCurrentPlant != null)
                cbHardinessZones.SelectedValue = _mCurrentPlant.HardZone.Id;
        }

        private void tsmiManageSunLevels_Click(object sender, EventArgs e)
        {
            ManageSunLevelsForm manageSunLevelsForm = new ManageSunLevelsForm();
            manageSunLevelsForm.ShowDialog();

            LoadSunLevelsCombo();

            if (_mCurrentPlant != null)
                cbSunLevels.SelectedValue = _mCurrentPlant.SunLvl.Id;
        }


    }
}
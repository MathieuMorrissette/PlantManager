using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PlantManager
{
    public class Plant
    {
        private string m_name;

        public Plant(int _ID, string _name, string _description)
        {
            ID = _ID;
            m_name = _name;
            Description = _description;
        }

        public int ID { get; private set; }

        public string Name
        {
            get { return GetPlantName(); }
        }

        public Genus genus
        {
            get
            {
                var item = Genus.GetGenusByPlantID(ID);
                return item;
            }
        }

        public string Description { get; private set; }

        public string Cultivar
        {
            get { return GetPlantCultivar(); }
        }

        public Image Img
        {
            get
            {
                var img = ImagePlant.GetImageByPlantID(ID);
                if (img != null)
                {
                    if (File.Exists(img.FilePath))
                    {
                        try
                        {
                            return Image.FromFile(img.FilePath);
                        }
                        catch (Exception ex)
                        {
                            //
                            MessageBox.Show("L'image n'est pas valide : " + ex.Message);
                        }
                    }
                }

                return Image.FromFile(Constants.IMG_PATH_NOT_FOUND);
            }
        }

        public int Width
        {
            get { return GetPlantWidth(); }
        }

        public int Height
        {
            get { return GetPlantHeight(); }
        }

        public static Plant GetPlantByID(int _PlantID)
        {
            var Plant = DB.QueryFirst("SELECT * FROM Plants WHERE PlantID = ?", _PlantID.ToString());
            return new Plant(Convert.ToInt32(Plant["PlantID"]), Plant["PlantName"].ToString(),
                Plant["PlantDescription"].ToString());
        }

        public static Plant[] GetAllPlant()
        {
            var dtPlants = DB.Query("SELECT * FROM Plants");
            var lstPlants = new List<Plant>();

            foreach (DataRow Row in dtPlants.Rows)
            {
                lstPlants.Add(new Plant(Convert.ToInt32(Row["PlantID"]), Row["PlantName"].ToString(),
                    Row["PlantDescription"].ToString()));
            }
            return lstPlants.ToArray();
        }

        public static Plant[] GetAllPlantByNameContains(string _searchString)
        {
            var dtPlants = DB.Query("SELECT * FROM Plants WHERE(PlantName LIKE ?)", "%" + _searchString + "%");
            var lstPlants = new List<Plant>();

            foreach (DataRow Row in dtPlants.Rows)
            {
                lstPlants.Add(new Plant(Convert.ToInt32(Row["PlantID"]), Row["PlantName"].ToString(),
                    Row["PlantDescription"].ToString()));
            }
            return lstPlants.ToArray();
        }

        public static void DeletePlantByID(int _ID)
        {
            DB.Execute("DELETE FROM Plants WHERE PlantID = ?", _ID.ToString());
        }

        public static void AddPlant(string _name, string _description)
        {
            DB.Execute("INSERT INTO Plants (PlantName, PlantDescription) VALUES (?, ?)", _name, _description);
        }

        public static void UpdatePlantBase(int _ID, string _name, string _description)
        {
            DB.Execute("UPDATE Plants SET PlantName = ?, PlantDescription = ? WHERE PlantID = ?", _name, _description,
                _ID.ToString());
        }

        public static void UpdatePlantGenus(int _plantID, int _genusID)
        {
            var genusID = _genusID.ToString();

            if (_genusID == -1)
                genusID = string.Empty;

            DB.Execute("UPDATE Plants SET PlantGenusID = ? WHERE PlantID = ?", genusID, _plantID.ToString());
        }

        public static void UpdatePlantCultivar(int _plantID, string _cultivar)
        {
            DB.Execute("UPDATE Plants SET PlantCultivar = ? WHERE PlantID = ?", _cultivar, _plantID.ToString());
        }

        public static void UpdatePlantWidth(int _plantID, int _width)
        {
            DB.Execute("UPDATE Plants SET PlantWidth = ? WHERE PlantID = ?", _width.ToString(), _plantID.ToString());
        }

        public static void UpdatePlantHeight(int _plantID, int _height)
        {
            DB.Execute("UPDATE Plants SET PlantHeight = ? WHERE PlantID = ?", _height.ToString(), _plantID.ToString());
        }

        private string GetPlantName()
        {
            var Plant = DB.QueryFirst("SELECT PlantName FROM Plants WHERE PlantID = ?", ID.ToString());
            return Plant["PlantName"].ToString();
        }

        private string GetPlantCultivar()
        {
            var Plant = DB.QueryFirst("SELECT PlantCultivar FROM Plants WHERE PlantID = ?", ID.ToString());
            return Plant["PlantCultivar"].ToString();
        }

        private int GetPlantWidth()
        {
            var Plant = DB.QueryFirst("SELECT PlantWidth FROM Plants WHERE PlantID = ?", ID.ToString());

            var width = Plant["PlantWidth"].ToString();

            if (width == string.Empty)
            {
                return 0;
            }

            return Convert.ToInt32(Plant["PlantWidth"]);
        }

        private int GetPlantHeight()
        {
            var Plant = DB.QueryFirst("SELECT PlantHeight FROM Plants WHERE PlantID = ?", ID.ToString());

            var height = Plant["PlantHeight"].ToString();

            if (height == string.Empty)
            {
                return 0;
            }

            return Convert.ToInt32(height);
        }
    }
}
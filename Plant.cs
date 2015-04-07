﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PlantManager.Properties;

namespace PlantManager
{
    public class Plant
    {
        public Plant(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }

        public string Name
        {
            get { return GetPlantName(); }
        }

        public Genus Genus
        {
            get
            {
                Genus item = Genus.GetGenusByPlantId(Id);
                return item;
            }
        }

        public string Description
        {
            get { return GetPlantDescription(); }
        }

        public string Cultivar
        {
            get { return GetPlantCultivar(); }
        }

        public Image Img
        {
            get
            {
                ImagePlant img = ImagePlant.GetImageByPlantId(Id);
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
                            MessageBox.Show(Resources.MSG_IMG_NOT_VALID + ex.Message);
                        }
                    }
                }

                return Image.FromFile(Constants.ImgPathNotFound);
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

        public HardinessZone HardZone
        {
            get { return HardinessZone.GetHardinessZoneByPlantId(Id); }
        }

        public SunLevel SunLvl
        {
            get { return SunLevel.GetSunLevelByPlantId(Id); }
        }

        public Shape Shape
        {
            get { return Shape.GetShapeByPlantId(Id); }
        }

        public PlantType PlantType
        {
            get { return PlantType.GetPlantTypeByPlantId(Id); }
        }

        public SoilType SoilType
        {
            get { return SoilType.GetSoilTypeByPlantId(Id); }
        }

        private string GetPlantDescription()
        {
            DataRow plant = Db.QueryFirst("SELECT PlantDescription FROM Plants WHERE PlantID = ?", Id.ToString());
            return plant["PlantDescription"].ToString();
        }

        public static Plant GetPlantById(int plantId)
        {
            DataRow plant = Db.QueryFirst("SELECT * FROM Plants WHERE PlantID = ?", plantId.ToString());
            return new Plant(Convert.ToInt32(plant["PlantID"]));
        }

        public static Plant[] GetAllPlant()
        {
            DataTable dtPlants = Db.Query("SELECT * FROM Plants");

            return (from DataRow row in dtPlants.Rows select new Plant(Convert.ToInt32(row["PlantID"]))).ToArray();
        }

        public static Plant[] GetAllPlantByNameContains(string searchString)
        {
            DataTable dtPlants = Db.Query("SELECT * FROM Plants WHERE(PlantName LIKE ?)", "%" + searchString + "%");

            return (from DataRow row in dtPlants.Rows select new Plant(Convert.ToInt32(row["PlantID"]))).ToArray();
        }

        public static void DeletePlantById(int id)
        {
            Db.Execute("DELETE FROM Plants WHERE PlantID = ?", id.ToString());
        }

        public static void AddPlant(string name, string description)
        {
            Db.Execute("INSERT INTO Plants (PlantName, PlantDescription) VALUES (?, ?)", name, description);
        }

        public static void UpdatePlantBase(int id, string name, string description)
        {
            Db.Execute("UPDATE Plants SET PlantName = ?, PlantDescription = ? WHERE PlantID = ?", name, description,
                id.ToString());
        }

        public static void UpdatePlantGenus(int plantId, int genusId)
        {
            string dataGenusId = genusId.ToString();

            if (genusId == -1)
            {
                dataGenusId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantGenusID = ? WHERE PlantID = ?", dataGenusId, plantId.ToString());
        }

        public static void UpdatePlantHardinessZone(int plantId, int hardinessZoneId)
        {
            string dataZoneId = hardinessZoneId.ToString();

            if (hardinessZoneId == -1)
            {
                dataZoneId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantHardinessZoneID = ? WHERE PlantID = ?", dataZoneId, plantId.ToString());
        }

        public static void UpdatePlantSunLevel(int plantId, int sunLevelId)
        {
            string dataSunLevelId = sunLevelId.ToString();

            if (sunLevelId == -1)
            {
                dataSunLevelId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantSunLevelID = ? WHERE PlantID = ?", dataSunLevelId, plantId.ToString());
        }

        public static void UpdatePlantShape(int plantId, int shapeId)
        {
            string dataShapeId = shapeId.ToString();

            if (shapeId == -1)
            {
                dataShapeId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantShapeID = ? WHERE PlantID = ?", dataShapeId, plantId.ToString());
        }

        public static void UpdatePlantPlantType(int plantId, int plantTypeId)
        {
            string dataPlantTypeId = plantTypeId.ToString();

            if (plantTypeId == -1)
            {
                dataPlantTypeId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantPlantTypeID = ? WHERE PlantID = ?", dataPlantTypeId, plantId.ToString());
        }

        public static void UpdatePlantSoilType(int plantId, int soilTypeId)
        {
            string dataSoilTypeId = soilTypeId.ToString();

            if (soilTypeId == -1)
            {
                dataSoilTypeId = string.Empty;
            }

            Db.Execute("UPDATE Plants SET PlantSoilTypeID = ? WHERE PlantID = ?", dataSoilTypeId, plantId.ToString());
        }

        public static void UpdatePlantCultivar(int plantId, string cultivar)
        {
            Db.Execute("UPDATE Plants SET PlantCultivar = ? WHERE PlantID = ?", cultivar, plantId.ToString());
        }

        public static void UpdatePlantWidth(int plantId, int width)
        {
            Db.Execute("UPDATE Plants SET PlantWidth = ? WHERE PlantID = ?", width.ToString(), plantId.ToString());
        }

        public static void UpdatePlantHeight(int plantId, int height)
        {
            Db.Execute("UPDATE Plants SET PlantHeight = ? WHERE PlantID = ?", height.ToString(), plantId.ToString());
        }

        private string GetPlantName()
        {
            DataRow plant = Db.QueryFirst("SELECT PlantName FROM Plants WHERE PlantID = ?", Id.ToString());
            return plant["PlantName"].ToString();
        }

        private string GetPlantCultivar()
        {
            DataRow plant = Db.QueryFirst("SELECT PlantCultivar FROM Plants WHERE PlantID = ?", Id.ToString());
            return plant["PlantCultivar"].ToString();
        }

        private int GetPlantWidth()
        {
            DataRow plant = Db.QueryFirst("SELECT PlantWidth FROM Plants WHERE PlantID = ?", Id.ToString());

            string width = plant["PlantWidth"].ToString();

            return width == string.Empty ? 0 : Convert.ToInt32(plant["PlantWidth"]);
        }

        private int GetPlantHeight()
        {
            DataRow plant = Db.QueryFirst("SELECT PlantHeight FROM Plants WHERE PlantID = ?", Id.ToString());

            string height = plant["PlantHeight"].ToString();

            return height == string.Empty ? 0 : Convert.ToInt32(height);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

namespace PlantManager
{
    public class ImagePlant
    {
        public ImagePlant(int imageId, int plantId, Image image)
        {
            ImageId = imageId;
            PlantId = plantId;
            Image = image;
        }

        public int ImageId { get; private set; }
        public int PlantId { get; private set; }
        public Image Image { get; private set; }

        public static ImagePlant[] GetImagesByPlantId(int id)
        {
            DataTable images = Db.Query("SELECT * FROM Images WHERE ImagePlantID = ?", id.ToString());

            if (images == null)
                return null;

            List<ImagePlant> lstImages = new List<ImagePlant>();
            foreach (DataRow image in images.Rows)
            {
                lstImages.Add
                    (
                    new ImagePlant(Convert.ToInt32(image["ImageID"]), Convert.ToInt32(image["ImagePlantID"]),
                                    byteArrayToImage(Convert.FromBase64String((string)image["ImageData"])))
                );
            }

            return lstImages.ToArray();
        }

        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static void AddImage(int plantId, string imagePath)
        {
            try
            {
                Image img = Image.FromFile(imagePath);
                byte[] imageData = imageToByteArray(img);
                Db.Execute("INSERT INTO Images (ImagePlantID, ImageData) VALUES (?,?)", plantId.ToString(), Convert.ToBase64String(imageData));
            }
            catch (Exception ex)
            {
                //LogManager.LogSilentError()
            }
        }

        public static void DeleteImageByPlantId(int plantId)
        {
            Db.Execute("DELETE FROM Images WHERE ImagePlantID = ?", plantId.ToString());
        }
    }
}
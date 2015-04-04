using System;

namespace PlantManager
{
    public class ImagePlant
    {
        public ImagePlant(int _imageID, int _plantID, string _filePath)
        {
            ImageID = _imageID;
            PlantID = _plantID;
            FilePath = _filePath;
        }

        public int ImageID { get; private set; }
        public int PlantID { get; private set; }
        public string FilePath { get; private set; }

        public static ImagePlant GetImageByPlantID(int _ID)
        {
            var image = DB.QueryFirst("SELECT * FROM Images WHERE ImagePlantID = ?", _ID.ToString());

            if (image == null)
                return null;

            return new ImagePlant(Convert.ToInt32(image["ImageID"]), Convert.ToInt32(image["ImagePlantID"]),
                image["ImageFilePath"].ToString());
        }

        /* public static string ImageBase64Encode(string _imagePath)
        {
            Image image = Image.FromFile(_imagePath);

            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }         
        }

        public static Image ImageBase64Decode(string _base64Data)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(_base64Data);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }*/

        public static void AddImage(int _plantID, string _imagePath)
        {
            DB.Execute("INSERT INTO Images (ImagePlantID, ImageFilePath) VALUES (?,?)", _plantID.ToString(), _imagePath);
        }

        public static void DeleteImageByPlantID(int _plantID)
        {
            DB.Execute("DELETE FROM Images WHERE ImagePlantID = ?", _plantID.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;

namespace PlantManager
{
    public class Genus
    {
        public Genus(int _ID, string _name)
        {
            ID = _ID;
            Name = _name;
        }

        public int ID { get; private set; }
        public string Name { get; private set; }

        public static Genus GetGenusByPlantID(int _genusID)
        {
            DataRow item = DB.QueryFirst(
                "SELECT * FROM Plants INNER JOIN Genus On PlantGenusID = GenusID WHERE PlantID = ?", _genusID.ToString());

            if (item == null)
                return GetDefaultGenus();

            return new Genus(Convert.ToInt32(item["GenusID"]), item["GenusName"].ToString());
        }

        public static Genus[] GetAllGenus()
        {
            DataTable dtGenus = DB.Query("SELECT * FROM Genus");
            List<Genus> lstGenus = new List<Genus>();

            lstGenus.Add(GetDefaultGenus());

            foreach (DataRow Row in dtGenus.Rows)
            {
                lstGenus.Add(new Genus(Convert.ToInt32(Row["GenusID"]), Row["GenusName"].ToString()));
            }
            return lstGenus.ToArray();
        }

        public static void DeleteGenusByID(int _ID)
        {
            if (_ID != -1)
                DB.Execute("DELETE FROM Genus WHERE GenusID = ?", _ID.ToString());
        }

        public static void AddGenus(string _name)
        {
            DB.Execute("INSERT INTO Genus (GenusName) VALUES (?)", _name);
        }

        public override string ToString()
        {
            return Name;
        }

        public static Genus GetDefaultGenus()
        {
            return new Genus(-1, Constants.STR_NONE);
        }
    }
}
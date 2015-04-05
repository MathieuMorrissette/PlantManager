using System;
using System.Collections.Generic;
using System.Data;

namespace PlantManager
{
    public class Genus
    {
        public Genus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public static Genus GetGenusByPlantId(int genusId)
        {
            DataRow item = Db.QueryFirst(
                "SELECT * FROM Plants INNER JOIN Genus On PlantGenusID = GenusID WHERE PlantID = ?", genusId.ToString());

            if (item == null)
                return GetDefaultGenus();

            return new Genus(Convert.ToInt32(item["GenusID"]), item["GenusName"].ToString());
        }

        public static Genus[] GetAllGenus()
        {
            DataTable dtGenus = Db.Query("SELECT * FROM Genus");
            List<Genus> lstGenus = new List<Genus>();

            lstGenus.Add(GetDefaultGenus());

            foreach (DataRow row in dtGenus.Rows)
            {
                lstGenus.Add(new Genus(Convert.ToInt32(row["GenusID"]), row["GenusName"].ToString()));
            }
            return lstGenus.ToArray();
        }

        public static void DeleteGenusById(int id)
        {
            if (id != -1)
                Db.Execute("DELETE FROM Genus WHERE GenusID = ?", id.ToString());
        }

        public static void AddGenus(string name)
        {
            Db.Execute("INSERT INTO Genus (GenusName) VALUES (?)", name);
        }

        public override string ToString()
        {
            return Name;
        }

        public static Genus GetDefaultGenus()
        {
            return new Genus(-1, Constants.StrNone);
        }
    }
}
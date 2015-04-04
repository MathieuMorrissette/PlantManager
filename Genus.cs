using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantManager
{
    public class Genus
    {
        int m_ID;
        string m_name;

        public Genus(int _ID, string _name)
        {
            m_ID = _ID;
            m_name = _name;
        }

        public int ID
        {
            get
            {
                return m_ID;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }
        }

        public static Genus GetGenusByPlantID(int _genusID)
        {
            DataRow item = DB.QueryFirst("SELECT * FROM Plants INNER JOIN Genus On PlantGenusID = GenusID WHERE PlantID = ?", _genusID.ToString());

            if (item == null)
                return Genus.GetDefaultGenus();

            return new Genus(Convert.ToInt32(item["GenusID"]), item["GenusName"].ToString());
        
        }

        public static Genus[] GetAllGenus()
        {
            DataTable dtGenus = DB.Query("SELECT * FROM Genus");
            List<Genus> lstGenus = new List<Genus>();

            lstGenus.Add(Genus.GetDefaultGenus());

            foreach (DataRow Row in dtGenus.Rows)
            {
                lstGenus.Add(new Genus(Convert.ToInt32(Row["GenusID"]), Row["GenusName"].ToString()));
            }
            return lstGenus.ToArray();
        }

        public static void DeleteGenusByID(int _ID)
        {
            if(_ID != -1)
                DB.Execute("DELETE FROM Genus WHERE GenusID = ?", _ID.ToString());
        }

        public static void AddGenus(string _name)
        {
            DB.Execute("INSERT INTO Genus (GenusName) VALUES (?)", _name);
        }

        public override string ToString()
        {
            return m_name;
        }

        public static Genus GetDefaultGenus()
        {
            return new Genus(-1, Constants.STR_NONE);
        }
    }
}

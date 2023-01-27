using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    public class ExistingTumorsService
    {
        public static List<ExistingTumorsCL> GetAllExistingTumors()
        {
            string query = "SELECT * FROM GynecologicalTumors;";
            DatabaseService.Connect();
            List<ExistingTumorsCL> list = new List<ExistingTumorsCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = reader["name"].ToString();
                string tumorDescription = reader["tumorDescription"].ToString();
                bool lethal = Convert.ToBoolean(reader["lethal"]);

                ExistingTumorsCL existingTumorsCL = new ExistingTumorsCL()
                {
                    Id = id,
                    Name = name,
                    TumorDescription = tumorDescription,
                    Lethal = lethal
                };
                list.Add(existingTumorsCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }

    }
}

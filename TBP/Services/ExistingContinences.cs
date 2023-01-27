using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    public class ExistingContinences
    {
        public static List<IncontinencesCL> GetAllExistingContinences()
        {
            string query = "SELECT * FROM Incontinences;";
            DatabaseService.Connect();
            List<IncontinencesCL> list = new List<IncontinencesCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = reader["name"].ToString();
                string incontinenceDescription = reader["incontinenceDescription"].ToString();
                

                IncontinencesCL existingIncontinencesCL = new IncontinencesCL()
                {
                    Incontinence_ID = id,
                    IncontinenceName = name,
                    IncontinenceDescription = incontinenceDescription
                };
                list.Add(existingIncontinencesCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

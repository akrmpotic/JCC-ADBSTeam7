using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TBP.Services
{
    public class CTGServices
    {
        public static void AddCTG(int id, DateTime date, DateTime time, string description, int infirmary, int doctor_id, int person_id)
        {
            string query = $"INSERT INTO [postgres].[CTG] VALUES ('{time}','{date}','{description}','{infirmary}', '{doctor_id}', '{person_id}')";
            DatabaseService.Connect();
            DatabaseService.ExecuteNonQuery(query);
            DatabaseService.Disconnect();
        }

        public static List<CTGCL> GetAllCTGs()
        {
            string query = "SELECT * FROM CTG;";
            DatabaseService.Connect();
            List<CTGCL> list = new List<CTGCL>();
           
            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int cTG_ID = (int)reader["id"];
                string date = reader["date"].ToString();
                string time = reader["time"].ToString();
                string description = reader["descript"].ToString();
                int infirmary = (int)reader["infirmary"];
                int doctor_id = (int)reader["doctor_id"];
                int person_id = (int)reader["person_id"];

                CTGCL cTGCL = new CTGCL()
                {
                    CTG_ID = cTG_ID,
                    Datum = date,
                    Vrijeme = time,
                    Description= description,
                    Infirmary = infirmary,
                    Person_ID = person_id,
                    Doctor_ID = doctor_id
                };
                list.Add(cTGCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

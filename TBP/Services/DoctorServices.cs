using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    public class DoctorServices
    {
        public static List<DoctorCL> GetAllDoctors()
        {
            string query = "SELECT * FROM Doctor;";
            DatabaseService.Connect();
            List<DoctorCL> list = new List<DoctorCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = reader["name"].ToString();
                string surname = reader["surname"].ToString();
                int hospitalid = (int)reader["hospital_id"];
                string password = reader["password"].ToString();

                DoctorCL doctorCL = new DoctorCL()
                {
                    Doctor_ID = id,
                    Name = name,
                    Surname = surname,
                    Hospital_ID = hospitalid,
                    Password = password,

                };
                list.Add(doctorCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

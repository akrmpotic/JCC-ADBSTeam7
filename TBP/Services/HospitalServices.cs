using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    public class HospitalServices
    {
        public static List<HospitalCL> GetAllHospitals()
        {
            string query = "SELECT * FROM Hospital;";
            DatabaseService.Connect();
            List<HospitalCL> list = new List<HospitalCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int hospital_id = (int)reader["id"];
                string name = reader["name"].ToString();
                string address = reader["address"].ToString();
                string city = reader["city"].ToString();
                string zipcode = reader["zipcode"].ToString();

                HospitalCL hospitalCL = new HospitalCL()
                {
                    Hospital_ID = hospital_id,
                    Name = name,   
                    Address = address,
                    City = city,    
                    ZipCode = zipcode   
                };
                list.Add(hospitalCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

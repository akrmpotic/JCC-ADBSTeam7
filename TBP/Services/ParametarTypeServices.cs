using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    internal class ParametarTypeServices
    {
        public static List<ParameterTypesCL> GetAllParameterTypes()
        {
            string query = "SELECT * FROM ParameterTypes;";
            DatabaseService.Connect();
            List<ParameterTypesCL> list = new List<ParameterTypesCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                string unit = reader["unit"].ToString();


                ParameterTypesCL parameterTypesCL = new ParameterTypesCL()
                {
                   Type_ID = id,
                   TypeName = name, 
                   TypeDescription = description,
                   TypeUnit = unit
                };
                list.Add(parameterTypesCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

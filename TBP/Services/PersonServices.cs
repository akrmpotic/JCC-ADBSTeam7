using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBP.DataAccess;
using TBP.Models;

namespace TBP.Services
{
    public class PersonServices
    {
        public static void AddPerson(int id, string name,string surname, string dateOfBirth, string gender, int person_id_mother, int person_id_father, string password, int numberofbornchildren)
        {
            string query = $"INSERT INTO [postgres].[Person] VALUES ('{name}','{surname}','{dateOfBirth}','{gender}', '{person_id_mother}', '{person_id_father}','{password}','{numberofbornchildren}')";
            DatabaseService.Connect();
            DatabaseService.ExecuteNonQuery(query);
            DatabaseService.Disconnect();
        }

        public static List<PersonCL> GetAllPersons()
        {
            string query = "SELECT * FROM Person;";
            DatabaseService.Connect();
            List<PersonCL> list = new List<PersonCL>();

            var reader = DatabaseService.GetDataReader(query);
            while (reader.Read())
            {
                int person_id = (int)reader["id"];
                string name = reader["name"].ToString();
                string surname = reader["surname"].ToString();
                string dateOfBirth = reader["dateOfBirth"].ToString();
                string gender = reader["gender"].ToString();
                string password = reader["password"].ToString();
                int numberOfBornChildren = (int)reader["numberofbornchildren"];
                int person_id_father = (int)reader["person_id_father"];
                int person_id_mother = (int)reader["person_id_mother"];

                PersonCL personCL = new PersonCL()
                {
                    Person_ID = person_id,  
                    Name = name,        
                    Surname = surname,
                    DateOfBirth = dateOfBirth,  
                    Gender = gender,    
                    Password = password,    
                    NumberOfBornChildren = numberOfBornChildren,    
                    Person_ID_father = person_id_father,    
                    Person_ID_mother = person_id_mother
                };
                list.Add(personCL);
            }
            reader.Close();
            DatabaseService.Disconnect();
            return list;
        }
    }
}

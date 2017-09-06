using Apttus.Assignment.MovieTicket;
using Apttus.Assignment.MovieTicket.Enum;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Apttus.MovieTicket.DAL
{
    public class DataAccessor : IDataAccessor
    {
        public List<Persons> GetMembersDetails()
        {
            List<Persons> personList = new List<Persons>();
            string p_name = "";
            int p_age = 0;
            Gender p_gender;
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBPerson.mdf;Integrated Security=True";
            //string cs =
            //    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Data\BookTicket4\BookTicket\DAL\DBPerson.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select * from Persons";
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader r = cmd1.ExecuteReader();
            while (r.Read())
            {
                p_name = r.GetString(0);
                p_age = r.GetInt32(1);
                p_gender = (Gender)r.GetInt32(2);
                personList.Add(new Persons(p_name, p_age, p_gender));
            }
            return personList;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalStudent
    {
        public static int AddStudent(EntityStudent parameter)
        {
            SqlCommand command1 = new SqlCommand("insert into TBLSTUDENT (STUDENTNAME,STUDENTSURNAME,STUDENTNUMBER,STUDENTPHOTO,STUDENTPASSWORD) values (@p1,@p2,@p3,@p4,@p5)", Connection.bgl);
            if (command1.Connection.State != ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            command1.Parameters.AddWithValue("@p1", parameter.NAME);
            command1.Parameters.AddWithValue("@p2", parameter.SURNAME);
            command1.Parameters.AddWithValue("@p3", parameter.NUMBER);
            command1.Parameters.AddWithValue("@p4", parameter.PHOTO);
            command1.Parameters.AddWithValue("@p5", parameter.PASSWORD);
            return command1.ExecuteNonQuery();
        }
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> values = new List<EntityStudent>();
            SqlCommand command2 = new SqlCommand("Select * from TBLSTUDENT", Connection.bgl);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            SqlDataReader dr =command2.ExecuteReader();
            while (dr.Read())
            {
                EntityStudent ent = new EntityStudent();
                ent.ID = Convert.ToInt32(dr["STUDENTID"].ToString());
                ent.NAME = dr["STUDENTNAME"].ToString();
                ent.SURNAME = dr["STUDENTSURNAME"].ToString();
                ent.NUMBER = dr["STUDENTNUMBER"].ToString();
                ent.PHOTO = dr["STUDENTPHOTO"].ToString();
                ent.PASSWORD = dr["STUDENTPASSWORD"].ToString();
                ent.WALLET = Convert.ToDouble(dr["STUDENTWALLET"].ToString());
                values.Add(ent);
            }
            dr.Close();
            return values;
        }
        public static bool DeleteStudent(int parameter2)
        {
            SqlCommand command3 = new SqlCommand("Delete from TBLSTUDENT where STUDENTID=@p1", Connection.bgl);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@p1", parameter2);
            return command3.ExecuteNonQuery() > 0;
        }

        public static List<EntityStudent> StudentDetail(int id)
        {
            List<EntityStudent> values = new List<EntityStudent>();
            SqlCommand command4 = new SqlCommand("Select * from TBLSTUDENT where STUDENTID=@p1", Connection.bgl);
            command4.Parameters.AddWithValue("@p1", id);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            SqlDataReader dr = command4.ExecuteReader();
            while (dr.Read())
            {
                EntityStudent ent = new EntityStudent();
                ent.NAME = dr["STUDENTNAME"].ToString();
                ent.SURNAME = dr["STUDENTSURNAME"].ToString();
                ent.NUMBER = dr["STUDENTNUMBER"].ToString();
                ent.PHOTO = dr["STUDENTPHOTO"].ToString();
                ent.PASSWORD = dr["STUDENTPASSWORD"].ToString();
                ent.WALLET = Convert.ToDouble(dr["STUDENTWALLET"].ToString());
                values.Add(ent);
            }
            dr.Close();
            return values;
        }

        public static bool UpdateStudent(EntityStudent value)
        {
            SqlCommand command5 = new SqlCommand("update TBLSTUDENT set STUDENTNAME=@p1, STUDENTSURNAME=@p2, STUDENTNUMBER=@p3,STUDENTPHOTO=@p4,STUDENTPASSWORD=@p5 WHERE STUDENTID=@p6",Connection.bgl);
            if (command5.Connection.State != ConnectionState.Open)
            {
                command5.Connection.Open();
            }
            command5.Parameters.AddWithValue("@p1",value.NAME);
            command5.Parameters.AddWithValue("@p2",value.SURNAME);
            command5.Parameters.AddWithValue("@p3",value.NUMBER);
            command5.Parameters.AddWithValue("@p4",value.PHOTO);
            command5.Parameters.AddWithValue("@p5",value.PASSWORD);
            command5.Parameters.AddWithValue("@p6",value.ID);
            return command5.ExecuteNonQuery() >0;

        }
    }
}

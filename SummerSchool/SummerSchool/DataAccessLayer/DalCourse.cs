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
    public class DalCourse
    {
        public static List<EntityCourse> ListCourse()
        {
            List<EntityCourse> values = new List<EntityCourse>();
            SqlCommand command = new SqlCommand("Select * from TBLCOURSE",Connection.bgl);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                EntityCourse ent = new EntityCourse();
                ent.ID = Convert.ToInt32( dr["COURSEID"].ToString());
                ent.COURSENAME = dr["COURSENAME"].ToString();
                ent.MIN = int.Parse(dr["COURSEMINQUOTA"].ToString());
                ent.MAX = int.Parse(dr["COURSEMAXQUOTA"].ToString());
                values.Add(ent);
            }
            dr.Close();
            return values;
        }
        public static int AddRequest(EntityApplicationForm parameter)
        {
            SqlCommand command2 = new SqlCommand("insert into TBLAPPLICATIONFORM (STUDENTID,COURSEID) values (@p1, @p2)",Connection.bgl);
            command2.Parameters.AddWithValue("@p1", parameter.APPSTUDENTID);
            command2.Parameters.AddWithValue("@p2", parameter.APPCOURSEID);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            return command2.ExecuteNonQuery();
        }
    }

}

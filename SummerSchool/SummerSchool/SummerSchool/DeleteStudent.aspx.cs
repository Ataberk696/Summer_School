using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace SummerSchool
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["STUDENTID"]);
            Response.Write(x);
            EntityStudent ent = new EntityStudent();
            ent.ID = x;
            BLLStudent.DeleteStudentBLL(ent.ID);
            Response.Redirect("StudentList.Aspx");
        }
    }
}
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityStudent ent = new EntityStudent();
            ent.NAME = TxtName.Text;
            ent.SURNAME = TxtSurname.Text;
            ent.NUMBER = TxtNumber.Text;
            ent.PASSWORD = TxtPassword.Text;
            ent.PHOTO = TxtPhoto.Text;
            BLLStudent.AddStudentBLL(ent);
        }
    }
}
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
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["STUDENTID"].ToString());
            TxtId.Text = x.ToString();
            TxtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                List<EntityStudent> StdntList = BLLStudent.BllDetail(x);
                TxtName.Text = StdntList[0].NAME.ToString();
                TxtSurname.Text = StdntList[0].SURNAME.ToString();
                TxtNumber.Text = StdntList[0].NUMBER.ToString();
                TxtPhoto.Text = StdntList[0].PHOTO.ToString();
                TxtPassword.Text = StdntList[0].PASSWORD.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EntityStudent ent = new EntityStudent();
            ent.NAME = TxtName.Text;
            ent.SURNAME = TxtSurname.Text;
            ent.NUMBER = TxtNumber.Text;
            ent.PHOTO = TxtPhoto.Text;
            ent.PASSWORD = TxtPassword.Text;
            ent.ID = Convert.ToInt32(TxtId.Text);
            BLLStudent.UpdateStudentBLL(ent);
            Response.Redirect("StudentList.aspx");
        }
    }
}
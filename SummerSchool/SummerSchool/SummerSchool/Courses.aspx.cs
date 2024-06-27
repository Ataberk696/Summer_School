using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Drawing.Imaging;

namespace SummerSchool
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityCourse> entCourse = BLLCourse.BLLList();
                DropDownList1.DataSource = BLLCourse.BLLList();
                DropDownList1.DataTextField = "COURSENAME";
                DropDownList1.DataValueField= "ID";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //I tested datavaluefield is working?
            //TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityApplicationForm ent = new EntityApplicationForm();
            ent.APPSTUDENTID = int.Parse(TextBox1.Text);
            ent.APPCOURSEID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            BLLCourse.AddRequestBLL(ent);

        }
    }
}
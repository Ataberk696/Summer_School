using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityApplicationForm
    {
        //app = application
        private int appid;
        public int APPID { get => appid; set => appid = value; }


        private int appcourseid;
        public int APPCOURSEID { get => appcourseid; set => appcourseid = value; }


        private int appstudentid;
        public int APPSTUDENTID { get => appstudentid; set => appstudentid = value; }

    }
}

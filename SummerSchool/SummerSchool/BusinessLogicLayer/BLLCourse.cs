using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLCourse
    {
        public static List<EntityCourse> BLLList()
        {
            return DalCourse.ListCourse();
        }

        public static int AddRequestBLL(EntityApplicationForm p)
        {
            if (p.APPSTUDENTID != null && p.APPCOURSEID != null)
            {
                return DalCourse.AddRequest(p);
            }
            return -1;
        }
    }
}

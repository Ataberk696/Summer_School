using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int AddStudentBLL(EntityStudent p)
        {
            if (p.NAME != null && p.SURNAME != null && p.NUMBER != null && p.PASSWORD != null && p.PHOTO != null)
            {
                return DalStudent.AddStudent(p);
            }
            return -1;
        }
        public static List<EntityStudent> BllList()
        {
            return DalStudent.StudentList();
        }
        public static bool DeleteStudentBLL(int p)
        {
            if (p >=0)
            {
                return DalStudent.DeleteStudent(p);
            }
            return false;
        }
        public static List<EntityStudent> BllDetail(int p)
        {
            return DalStudent.StudentDetail(p);
        }
        public static bool UpdateStudentBLL(EntityStudent p)
        {
            if (p.NAME != null && p.NAME != "" &&
                p.SURNAME != null && p.SURNAME != "" &&
                p.NUMBER != null && p.NUMBER != "" &&
                p.PASSWORD != null && p.PASSWORD != "" &&
                p.PHOTO != null && p.PHOTO != "" &&
                p.ID > 0)
            {
                return DalStudent.UpdateStudent(p);
            }
            return false;
        }
    }
}

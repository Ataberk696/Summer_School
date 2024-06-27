using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCourse
    {
        private string coursename;
        public string COURSENAME { get => coursename; set => coursename = value; }
        

        private int min;
        public int MIN { get => min; set => min = value; }
        

        private int max;
        public int MAX { get => max; set => max = value; }
      

        private int id;
        public int ID { get => id; set => id = value; }

    }
}

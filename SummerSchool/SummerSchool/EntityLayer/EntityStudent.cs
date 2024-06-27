using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudent
    {
        private string name;
        public string NAME { get => name; set => name = value; }


        private string surname;
        public string SURNAME { get => surname; set => surname = value; }


        private int id;
        public int ID { get => id; set => id = value; }


        private string number;
        public string NUMBER { get => number; set => number = value; }


        private string photo;
        public string PHOTO { get => photo; set => photo = value; }


        private double wallet;
        public double WALLET { get => wallet; set => wallet = value; }
        

        private string password;
        public string PASSWORD { get => password; set => password = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx2.Iteams
{
    internal class Iteam
    {
        public string Number { get; set; }
        public DateTime date { get; set; }
        public string inventory_number { get; set; }
        public string object_name { get; set; }
        public string count { get; set; }
        public string price { get; set; }

        public void save() {

            Console.WriteLine(object_name+" iteam added successfully!!");
        }
    }
}

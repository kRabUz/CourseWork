using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Name
    {
        private string name;
        public string NameShip { get { return name; } set { name = value; } }
        public Name(string name)
        {
            this.name = name;
        }
    }
}

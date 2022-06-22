using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Type
    {
        private string type;
        public string TypeShip { get { return type; } set { type = value; } }
        public Type(string type)
        {
            this.type = type;
        }
    }
}

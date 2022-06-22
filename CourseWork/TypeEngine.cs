using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class TypeEngine
    {
        private string typeengine;
        public string TypeEngineShip { get { return typeengine; } set { typeengine = value; } }
        public TypeEngine(string typeengine)
        {
            this.typeengine = typeengine;
        }
    }
}

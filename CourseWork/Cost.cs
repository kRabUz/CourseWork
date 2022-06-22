using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Cost
    {
        private string cost;
        public string CostShip { get { return cost; } set { cost = value; } }
        public Cost(string cost)
        {
            this.cost = cost;
        }
    }
}

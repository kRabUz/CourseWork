using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Route
    {
        private string route;
        public string RouteShip { get { return route; } set { route = value; } }
        public Route(string route)
        {
            this.route = route;
        }
    }
}

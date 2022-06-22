using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    abstract class Base
    {
        public abstract string Name { get; set; }
        public abstract string Type { get; set; }
        public abstract string TypeEngine { get; set; }
        public abstract string Cost { get; set; }
        public abstract string Route { get; set; }

        public Base(string name, string type, string typeengine, string cost, string route)
        {
            Name = name;
            Type = type;
            TypeEngine = typeengine;
            Cost = cost;
            Route = route;
        }
        public abstract string GetNameShip();
        public abstract string GetTypeShip();
        public abstract string GetTypeEngineShip();
        public abstract string GetCostShip();
        public abstract string GetRouteShip();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class Ship : Base
    {
        private string name;
        private string type;
        private string typeengine;
        private string cost;
        private string route;

        public Ship(string name, string type, string typeengine, string cost, string route) : base(name, type, typeengine, cost, route) { }
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override string Type
        {
            get => type;
            set => type = value;
        }
        public override string TypeEngine
        {
            get => typeengine;
            set => typeengine = value;
        }
        public override string Cost
        {
            get => cost;
            set => cost = value;
        }
        public override string Route
        {
            get => route;
            set => route = value;
        }
        public override string GetNameShip()
        {
            return name;
        }
        public override string GetTypeShip()
        {
            return type;
        }
        public override string GetTypeEngineShip()
        {
            return typeengine;
        }
        public override string GetCostShip()
        {
            return cost;
        }
        public override string GetRouteShip()
        {
            return route;
        }
    }
}

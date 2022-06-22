using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class ShipList
    {
        private List<Ship> Ships = new List<Ship>();
        public void Add(Ship item)
        {
            Ships.Add(item);
        }
        public void Remove(int index)
        {
            Ships.RemoveAt(index);
        }
        public string GNameShip(int index)
        {
            return Ships[index].GetNameShip();
        }
        public string GTypeShip(int index)
        {
            return Ships[index].GetTypeShip();
        }
        public string GTypeEngineShip(int index)
        {
            return Ships[index].GetTypeEngineShip();
        }
        public string GCostShip(int index)
        {
            return Ships[index].GetCostShip();
        }
        public string GRouteShip(int index)
        {
            return Ships[index].GetRouteShip();
        }
        public int GetCount()
        {
            return Ships.Count;
        }
    }
}

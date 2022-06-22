using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class WatchUser : Form
    {
        string path = @"C:\Education\ОП\CourseWork\CourseWork\";
        ShipList list = new ShipList();
        public WatchUser()
        {
            InitializeComponent();
            StreamReader name = new StreamReader(path + "NameList.txt");
            StreamReader type = new StreamReader(path + "TypeList.txt");
            StreamReader typeengine = new StreamReader(path + "TypeEngineList.txt");
            StreamReader cost = new StreamReader(path + "CostList.txt");
            StreamReader route = new StreamReader(path + "RouteList.txt");
            string line1 = name.ReadLine();
            string line2 = type.ReadLine();
            string line3 = typeengine.ReadLine();
            string line4 = cost.ReadLine();
            string line5 = route.ReadLine();
            while (line1 != null)
            {
                Ship ship = new Ship(line1, line2, line3, line4, line5);
                list.Add(ship);
                line1 = name.ReadLine();
                line2 = type.ReadLine();
                line3 = typeengine.ReadLine();
                line4 = cost.ReadLine();
                line5 = route.ReadLine();
            }
            name.Close();
            type.Close();
            typeengine.Close();
            cost.Close();
            route.Close();
            for (int i = 0; i < list.GetCount(); ++i)
            {
                NameList.Items.Add(list.GNameShip(i));
                TypeList.Items.Add(list.GTypeShip(i));
                TypeEngineList.Items.Add(list.GTypeEngineShip(i));
                CostList.Items.Add(Convert.ToString(list.GCostShip(i)));
                RouteList.Items.Add(list.GRouteShip(i));
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void NameList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = NameList.SelectedIndex;
            TypeList.SetSelected(index, true);
            TypeEngineList.SetSelected(index, true);
            CostList.SetSelected(index, true);
            RouteList.SetSelected(index, true);
        }

        private void TypeList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = TypeList.SelectedIndex;
            NameList.SetSelected(index, true);
            TypeEngineList.SetSelected(index, true);
            CostList.SetSelected(index, true);
            RouteList.SetSelected(index, true);
        }

        private void TypeEngineList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = TypeEngineList.SelectedIndex;
            NameList.SetSelected(index, true);
            TypeList.SetSelected(index, true);
            CostList.SetSelected(index, true);
            RouteList.SetSelected(index, true);
        }

        private void CostList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = CostList.SelectedIndex;
            NameList.SetSelected(index, true);
            TypeEngineList.SetSelected(index, true);
            TypeList.SetSelected(index, true);
            RouteList.SetSelected(index, true);
        }

        private void RouteList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = RouteList.SelectedIndex;
            NameList.SetSelected(index, true);
            TypeEngineList.SetSelected(index, true);
            CostList.SetSelected(index, true);
            TypeList.SetSelected(index, true);
        }
    }
}

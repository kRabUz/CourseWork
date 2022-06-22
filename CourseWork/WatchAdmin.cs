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
    public partial class WatchAdmin : Form
    {
        string path = @"C:\Education\ОП\CourseWork\CourseWork\";
        ShipList list = new ShipList();
        public WatchAdmin()
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
        public void Save()
        {
            TextWriter w1 = new StreamWriter(path + "NameList.txt");
            foreach (var item in NameList.Items)
                w1.WriteLine(item.ToString());
            w1.Close();
            TextWriter w2 = new StreamWriter(path + "TypeList.txt");
            foreach (var item in TypeList.Items)
                w2.WriteLine(item.ToString());
            w2.Close();
            TextWriter w3 = new StreamWriter(path + "TypeEngineList.txt");
            foreach (var item in TypeEngineList.Items)
                w3.WriteLine(item.ToString());
            w3.Close();
            TextWriter w4 = new StreamWriter(path + "CostList.txt");
            foreach (var item in CostList.Items)
                w4.WriteLine(item.ToString());
            w4.Close();
            TextWriter w5 = new StreamWriter(path + "RouteList.txt");
            foreach (var item in RouteList.Items)
                w5.WriteLine(item.ToString());
            w5.Close();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu();
            menu.Show();
        }

        private void ShipAdd_Click(object sender, EventArgs e)
        {
            bool flag1 = true, flag2 = true;
            long f = 0;
            if (NameBox.Text == "" || TypeBox.Text == "" || TypeEngineBox.Text == "" || CostBox.Text == "" || RouteBox.Text == "")
            {
                flag1 = false;
                MessageBox.Show("Введено не всі дані, перевірте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    f = Convert.ToInt64(CostBox.Text);
                }
                catch
                {
                    flag2 = false;
                }
                if (f <= 0 || !flag2)
                {
                    flag2 = false;
                    MessageBox.Show("Неправильно введено вартість, перевірте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (flag1 && flag2)
            {
                Name name = new Name(Convert.ToString(NameBox.Text));
                Type type = new Type(Convert.ToString(TypeBox.Text));
                TypeEngine typeengine = new TypeEngine(Convert.ToString(TypeEngineBox.Text));
                Cost cost = new Cost(CostBox.Text + " uah");
                Route route = new Route(RouteBox.Text);
                Ship ship = new Ship(name.NameShip, type.TypeShip, typeengine.TypeEngineShip, cost.CostShip, route.RouteShip);
                list.Add(ship);
                for (int i = list.GetCount() - 1; i < list.GetCount(); ++i)
                {
                    NameList.Items.Add(list.GNameShip(i));
                    TypeList.Items.Add(list.GTypeShip(i));
                    TypeEngineList.Items.Add(list.GTypeEngineShip(i));
                    CostList.Items.Add(Convert.ToString(list.GCostShip(i)));
                    RouteList.Items.Add(list.GRouteShip(i));
                }
                Save();
                NameBox.Text = "";
                TypeBox.Text = "";
                TypeEngineBox.Text = "";
                CostBox.Text = "";
                RouteBox.Text = "";
            }
        }

        private void ShipRemove_Click(object sender, EventArgs e)
        {
            int index = NameList.SelectedIndex;
            if (index != -1)
            {
                NameList.Items.RemoveAt(index);
                TypeList.Items.RemoveAt(index);
                TypeEngineList.Items.RemoveAt(index);
                CostList.Items.RemoveAt(index);
                RouteList.Items.RemoveAt(index);
                list.Remove(index);
                Save();
            }
            else if (index == -1)
            {
                MessageBox.Show("Ніякий елемент не вибрано.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

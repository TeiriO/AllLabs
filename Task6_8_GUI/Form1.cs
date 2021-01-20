using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task6_8_Lib;

namespace Task6_8_GUI
{
    public partial class Form1 : Form
    {
        List<IShip> ships = new List<IShip>();

        public Form1()
        {
            InitializeComponent();
            typeCB.Items.AddRange(Enum.GetNames(typeof(TankerType)));
            typeCB.SelectedIndex = 0;

            shipLB.DisplayMember = "Name";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string name = nameTB.Text;
            float lifting = (float)liftingNUD.Value;
            int staff = (int)staffCountNUD.Value;
            string transportedLiquid = transportedLiquidTB.Text;
            TankerType tankerType = (TankerType )Enum.Parse(typeof(TankerType), (string)typeCB.SelectedItem);
            ships.Add(new Tanker(name, lifting, staff, transportedLiquid, tankerType));

            ReloadList();
            Print($"Корабль {name} добавлен.");
        }

        private void SailBtn_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.Sail());
            }
        }

        private void SinkBtn_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.Sink());
            }
        }
        private void ToStringBtn_Click(object sender, EventArgs e)
        {
            IShip ship = GetSelectedShip(); ;
            if (ship != null)
            {
                Print(ship.ToString());
            }
        }

        private IShip GetSelectedShip()
        {
            IShip ship = (IShip)shipLB.SelectedItem;
            if (ship == null)
            {
                Print("Корабль не выбран");
            }
            return ship;
        }

        private void Print(string message)
        {
            outputTB.Text += message + Environment.NewLine;
        }

        private void ReloadList()
        {
            shipLB.Items.Clear();
            ships.ForEach(s => shipLB.Items.Add(s));
        }

        
    }
}

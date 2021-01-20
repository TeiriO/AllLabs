using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using Task8_8_GUI.Properties;
using Task8_8_Lib;

namespace Task8_8_GUI
{
    public partial class Form1 : Form
    {

        private Emulation Emulation { get; set; }
        private Thread RepaintThread { get; set; } = null;
        private Random Random { get; set; }
        private Image Human { get; set; }
        private Image Shop { get; set; }
        private Image Delivery { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeImage();
            
            
            courierCB.SelectedIndex = 0;
            Random = new Random();
            panel1.Paint += Panel1_Paint;
            panel1.Invalidate();
        }

        private void InitializeImage()
        {
            ResourceManager rm = Resources.ResourceManager;

            Human = (Image)rm.GetObject("human");
            Shop = (Image)rm.GetObject("shop");
            Delivery = (Image)rm.GetObject("delivery");
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            Brush brush = new SolidBrush(Color.DarkGray);

            try
            {
                if (Emulation != null)
                {
                    Coordinates courierCoord = Emulation.Courier.TargetCoordinates;
                    g.DrawImage(Delivery, courierCoord.X, courierCoord.Y, 100, 100);

                    Emulation.Courier.Customers
                        .FindAll(h => h.IsWait)
                        .ForEach(h => g.DrawImage(Human, h.Coordinates.X, h.Coordinates.Y, 20, 40));

                    foreach (var shop in Emulation.Shops)
                    {
                        g.DrawImage(Shop, shop.Coordinates.X, shop.Coordinates.Y, 50, 50);

                        foreach (var human in shop.Customers)
                        {
                            if (human.IsWait)
                            {
                                g.DrawImage(Human, human.Coordinates.X, human.Coordinates.Y, 20, 40);
                            }
                        }
                    }
                }
            }
            catch
            {
                panel1.Invalidate();
            }

        }

        private void PanelRepaint()
        {
            while (true)
            {
                Thread.Sleep(250);
                panel1.Invalidate();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (RepaintThread == null)
            {
                ICourier courier = GetCourier();
                if (courier == null) return;

                List<Shop> shops = GetShops();

                Coordinates min = new Coordinates(0, panel1.Height - 100);
                Coordinates max = new Coordinates(panel1.Width - 100, (int)(panel1.Height * 0.3));

                Emulation = new Emulation(shops, courier, min, max);
                Emulation.Start();

                RepaintThread = new Thread(PanelRepaint);
                RepaintThread.Start();
                start.Text = "Stop";
            }
            else
            {
                AllStop();
            }
        }

        private List<Shop> GetShops()
        {
            List<Shop> shops = new List<Shop>();

            int shopCount = (int)shopCountNUD.Value;
            int orderChance = (int)orderChanceNUD.Value;

            if(shopCount != 0)
            {
                Coordinates coordinates = new Coordinates((int)(panel1.Width * 0.5), 10);
                Shop shop = new Shop(coordinates, Random, orderChance);
                shops.Add(shop);
                shopCount--;
            }

            if(shopCount != 0)
            {
                Coordinates coordinates = new Coordinates((int)(panel1.Width * 0.25), 10);
                Shop shop = new Shop(coordinates, Random, orderChance);
                shops.Add(shop);
                shopCount--;
            }

            if(shopCount != 0)
            {
                Coordinates coordinates = new Coordinates((int)(panel1.Width * 0.75), 10);
                Shop shop = new Shop(coordinates, Random, orderChance);
                shops.Add(shop);
            }

            return shops;
        }

        private ICourier GetCourier()
        {
            String courierString = courierCB.SelectedItem.ToString();
            Coordinates baseCoordinates = new Coordinates(panel1.Width / 2, panel1.Height / 2);
            switch (courierString)
            {
                case "Доставка по очереди":
                    return new Courier(baseCoordinates);
                case "Доставка по расстоянию":
                    return new MinDistCourier(baseCoordinates);
                case "Очень быстрая доставка":
                    return new FastCourier(baseCoordinates);
                default:
                    AllStop();
                    return null;
            }
        }

        private void AllStop()
        {
            Emulation.Stop();
            RepaintThread.Abort();
            RepaintThread = null;
            start.Text = "Start";
        }


    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task8_8_Lib
{
    public class Shop
    {
        public delegate void NewOrder(Shop shop, Human human);
        public event NewOrder OnNewOrder;

        public Coordinates Coordinates { get; set; }

        //public List<Human> Customers { get; set; }

        public ConcurrentQueue<Human> Customers { get; set; }

        private Random Random { get; set; }

        public int NewOrderChance { get; set; }

        public Shop(Coordinates coordinates, Random random, int newOrderChance)
        {
            Coordinates = coordinates;
            Random = random;
            NewOrderChance = newOrderChance;
            //Customers = new List<Human>();
            Customers = new ConcurrentQueue<Human>();
        }

        public void Start()
        {
            while (true)
            {
                if (IsNewOrder())
                {
                    Human h = new Human();
                    Customers.Enqueue(h);
                    //Customers.Add(h);
                    OnNewOrder.Invoke(this, h);
                }
                Thread.Sleep(1000);
            }
        }

        private bool IsNewOrder()
        {
            int x = Random.Next(0, 100);
            return x < NewOrderChance;
        }

    }
}

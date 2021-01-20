using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task8_8_Lib
{
    public class Emulation
    {

        public List<Shop> Shops { get; set; } = new List<Shop>();

        public ICourier Courier { get; set; }

        private List<Thread> _threads = new List<Thread>();

        private Coordinates HumanMinCoordinate { get; set; }
        private Coordinates HumanMaxCoordinate { get; set; }

        private Random Random { get; set; } = new Random();

        public Emulation(List<Shop> shops, ICourier courier, Coordinates humanMinCoordinate, Coordinates humanMaxCoordinate)  
        {
            Shops = shops;
            Courier = courier;
            HumanMinCoordinate = humanMinCoordinate;
            HumanMaxCoordinate = humanMaxCoordinate;
        }

        public void Start()
        {

            foreach(var shop in Shops)
            {
                shop.OnNewOrder += OnNewOrder;

                Thread shopThread = new Thread(shop.Start);
                shopThread.Start();
                _threads.Add(shopThread);
            }

            Thread thread = new Thread(Courier.Start);
            thread.Start();
            _threads.Add(thread);
        }

        public void Stop()
        {
            _threads.ForEach(th => th.Abort());
        }

        private void OnNewOrder(Shop shop, Human human)
        {
            Coordinates coordinates = GenerateCoordinates();
            human.Coordinates = coordinates;
            if (!Courier.Shops.Contains(shop))
            {
                Courier.AddShop(shop);
            }
        }

        private Coordinates GenerateCoordinates()
        {
            int deltaX = Math.Abs(HumanMaxCoordinate.X - HumanMinCoordinate.X);
            int deltaY = Math.Abs(HumanMaxCoordinate.Y - HumanMinCoordinate.Y);

            int x = Random.Next(deltaX);
            int y = Random.Next(deltaY);

            return new Coordinates(HumanMinCoordinate.X + x, HumanMinCoordinate.Y - y);
        }

    }
}

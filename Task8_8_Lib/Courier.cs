using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task8_8_Lib
{
    public class Courier : ICourier
    {
        public Coordinates TargetCoordinates { get; set; }
        public Coordinates BaseCoordinates { get; set; }
        public List<Human> Customers { get; set; }
        public List<Shop> Shops { get; set; }
        public int GetOrderTime { get; set; }
        public int GiveOrderTime { get; set; }

        public Courier(Coordinates baseCoordinates)
        {
            BaseCoordinates = baseCoordinates;
            TargetCoordinates = baseCoordinates.Copy();
            GetOrderTime = 1500;
            GiveOrderTime = 500;
            Shops = new List<Shop>();
            Customers = new List<Human>();
        }

        public void AddCustomers(Human human)
        {
            Customers.Add(human);
        }

        public void AddShop(Shop shop)
        {
            Shops.Add(shop);
        }

        public void GetOrders(Shop shop)
        {
            while (!TargetCoordinates.IsOn(shop.Coordinates))
            {
                MoveTo(shop.Coordinates);
            }
            Thread.Sleep(GetOrderTime);

            foreach(var c in shop.Customers)
            {
                Customers.Add(c);
            }

            shop.Customers = new ConcurrentQueue<Human>();
            Shops.Remove(shop);
        }

        public void DeliveryOrder(Human human)
        {
            while (!TargetCoordinates.IsOn(human.Coordinates))
            {
                MoveTo(human.Coordinates);
            }
            Thread.Sleep(GiveOrderTime);
            human.IsWait = false;

            Customers.Remove(human);
        }

        public bool IsWaiting()
        {
            return TargetCoordinates.IsOn(BaseCoordinates);
        }

        public void Start()
        {
            while (true)
            {
                
                if(Customers.Count == 0)
                {
                    if(Shops.Count == 0)
                    {
                        MoveTo(BaseCoordinates);
                    }
                    else
                    {
                        GetOrders(Shops[0]);
                    }
                }
                else
                {
                    DeliveryOrder(Customers[0]);
                }
            }
        }

        private void MoveTo(Coordinates coordinates)
        {
            Thread.Sleep(100);
            if (!TargetCoordinates.IsOn(coordinates))
            {
                TargetCoordinates.MoveTo(coordinates);
            }
        }

    }
}

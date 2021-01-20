using System;
using System.Collections.Generic;
using System.Text;

namespace Task8_8_Lib
{
    public interface ICourier
    {
        Coordinates TargetCoordinates { get; set; }

        Coordinates BaseCoordinates { get; set; }

        List<Human> Customers { get; set; }

        List<Shop> Shops { get; set; }

        int GetOrderTime { get; set; }

        int GiveOrderTime { get; set; }

        void Start();

        bool IsWaiting();

        void AddShop(Shop shop);

        void AddCustomers(Human human);

        void GetOrders(Shop shop);

        void DeliveryOrder(Human human);

    }
}

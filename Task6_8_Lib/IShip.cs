using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_8_Lib
{
    public interface IShip
    {
        string Name { get; set; }

        string Sail();

        string Sink();

    }
}

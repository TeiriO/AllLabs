using System;
using System.Collections.Generic;
using System.Text;

namespace Task8_8_Lib
{
    public class Human
    {

        public Coordinates Coordinates { get; set; }

        public bool IsWait { get; set; }

        public Human()
        {
            IsWait = true;
        }

        public Human(Coordinates coordinates) : this()
        {
            Coordinates = coordinates;
        }


    }
}

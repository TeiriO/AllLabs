using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_8_Lib
{
    public abstract class CargoShip : IShip
    {
        public string Name { get; set; }

        public float LiftingCapacity { get; set; }

        public int NumberOfStaff { get; set; }

        public virtual string Sail()
        {
            return $"Грузовой корабль {Name} поплыл.";
        }

        public virtual string Sink()
        {
            return $"Грузовой корабль {Name} утонул.";
        }

        public virtual string Load()
        {
            return $"Грузовой корабль {Name} загружен.";
        }
    }
}

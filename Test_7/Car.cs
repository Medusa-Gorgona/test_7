using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7
{
    public class Car
    {      
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public int Power { get; set; }
        public bool AirBag { get; set; }
        public bool Sport { get; set; }
        public bool Family { get; set; }

        public Car()
        {
            Brand = "Мазда";
            Model = "323";
            Color = "Серебристый металлик";
            Doors = 5;
            Power=50;
            AirBag = false;
            Sport = true;
            Family = true;
        }

        public Car(string _brand, string _model, string _color, int _doors, int _power, bool _airbag, 
            bool _sport, bool _family)
        {
            Brand = _brand;
            Model = _model;
            Color = _color;
            Doors = _doors;
            Power = _power;
            AirBag = _airbag;
            Sport = _sport;
            Family = _family;
        }
    }
}

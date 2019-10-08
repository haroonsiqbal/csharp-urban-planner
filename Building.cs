using System;

namespace urban_planner
{
    public class Building {
        public Building(string address)
        {
            _address = address;
        }
        private string _designer = "Haroon Iqbal";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int stories {get; set;}

        public double width {get; set;}

        public double depth {get; set;}

        public double getVolume() {
            return width * depth * (3 * stories);

        }

        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner) {
            _owner = owner;
        }

        public void Print() {
            Console.WriteLine(this._address);
            Console.WriteLine("--------------");
            Console.WriteLine($"Designed by {this._designer}");
            Console.WriteLine($"Constructed on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{getVolume()} cubic meters of space");
        }

    }
}
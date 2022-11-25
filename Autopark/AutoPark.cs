using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace автопарк
{
    class AutoPark
    {
        public string Name { get; set; }
        List<Car> cars = new List<Car>();
        public AutoPark(string name, List<Car> cars)
        {
            Name = name;
            this.cars = cars;
        }

        public override string ToString()
        {
            string print = "";
            for(int i = 0; i < cars.Count; i++)
            {
                print += cars[i] + "\n";
            }
            return $"Name of autopark: {Name} \n" + print;
        }
    }
}

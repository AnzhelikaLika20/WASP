namespace автопарк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Car> Bip = new List<Car>();
                Dictionary<string, int> dict1 = new Dictionary<string, int>() { { "potatoes", 7 }, { "bananas", 15 }, { "papers", 14 } };
                Dictionary<string, int> dict2 = new Dictionary<string, int>() { { "wheel", 2015 }, { "sealbelt", 2015 }, { "motor", 2017 } };
                Bip.Add(new Truck("Mers", 1000, 1995, 1200, "Maxim", dict1));
                Bip.Add(new PassengerCar("BMW", 900, 2010, 5, dict2));
                AutoPark park = new AutoPark("MoscowPark", Bip);
                Console.WriteLine(park + "\n");

                ///пример использования методов
                for (int i = 0; i < Bip.Count; i++)
                {
                    if (Bip[i] is PassengerCar)
                    {
                        PassengerCar car = Bip[i] as PassengerCar;
                        car.AddNewDetail("engine", 2022);
                        car.PrintRepairBook();
                        Console.WriteLine($"Year of rapairing a wheel is {car.GetYearOfRepair("wheel")}");
                        Console.WriteLine(car + "\n");
                    }
                    else
                    {
                        Truck car = Bip[i] as Truck;
                        car.ChangeDriver("Alex");
                        car.DeleteGoods("bananas");
                        car.AddGoods("apples", 12);
                        car.PrintGoods();
                        Console.WriteLine(car + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
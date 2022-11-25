using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace автопарк
{
    class Car
    {
        public string Brand { get; }
        public int Power { get; }
        public int Production { get; }
        public Car(string brand, int power, int production)
        {
            Brand = brand;
            Power = power;
            Production = production;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, power: {Power}, production: {Production}";
        }
    }
    class PassengerCar : Car
    {
        public int Capacity { get; }
        public Dictionary<string, int> RepairBook { get; }
        public PassengerCar(string brand, int power, int production, int countPassengers, Dictionary<string, int> repairBook)
            : base(brand, power, production)
        {
            Capacity = countPassengers;
            RepairBook = repairBook;
        }
        /// <summary>
        /// Добавление замененной детали
        /// </summary>
        /// <param name="detail">название детали</param>
        /// <param name="year">год замены</param>
        public void AddNewDetail(string detail, int year)
        {
            RepairBook.Add(detail, year);
        }
        /// <summary>
        /// Вычисление года замены детали
        /// </summary>
        /// <param name="detail">название детали</param>
        /// <returns>год замены</returns>
        public int GetYearOfRepair(string detail)
        {
            return RepairBook[detail];
        }
        /// <summary>
        /// Вывод книги учета замены деталей на экран
        /// </summary>
        public void PrintRepairBook()
        {
            foreach (var i in RepairBook)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", count of passengers: {Capacity}";
        }
    }
    class Truck : Car
    {
        public int LoadCapacity { get; }
        public string DriverName { get; private set; }
        public Dictionary<string, int> Goods { get; }
        public Truck(string brand, int power, int production, int loadCapacity, string driverName, Dictionary<string, int> goods)
            : base(brand, power, production)
        {
            LoadCapacity = loadCapacity;
            DriverName = driverName;
            Goods = goods;
        }
        /// <summary>
        /// Смена имени водителя
        /// </summary>
        /// <param name="name">имя нового водителя</param>
        public void ChangeDriver(string name)
        {
            DriverName = name;
        }
        /// <summary>
        /// Добавление нового преревозимого товара 
        /// </summary>
        /// <param name="good">название товара</param>
        /// <param name="weight">вес товара</param>
        public void AddGoods(string good, int weight)
        {
            Goods.Add(good, weight);
        }
        /// <summary>
        /// Удаление перевозимого товара
        /// </summary>
        /// <param name="good">название товара</param>
        public void DeleteGoods(string good)
        {
            Goods.Remove(good);
        }
        /// <summary>
        /// Вывод текущих перевозимых товаров с названием и весом на экран
        /// </summary>
        public void PrintGoods()
        {
            foreach (var i in Goods)
                Console.WriteLine($"{i.Key} -> {i.Value}");
        }
        public override string ToString()
        {
            return base.ToString() + $", driver's name: {DriverName}, load capacity: {LoadCapacity}";
        }
    }
}

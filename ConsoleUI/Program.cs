using Business.Concrete;
using DataAccess.Abtract;
using DataAccess.Concrete.EntityFremework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAllByCarId(1))
            //{
            //    Console.WriteLine(car.ToString());
            //}
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " " + car.BrandName);
            }
            
        }
    }
}

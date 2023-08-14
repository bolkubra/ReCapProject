using Business.Concrete;
using DataAccess.Abtract;
using DataAccess.Concrete.EntityFremework;

using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCars\n\n");
            EfCarDal efCarDal = new EfCarDal();
            CarManager carManager = new CarManager(efCarDal);



            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }


            Console.WriteLine("\nCar Details\n\n");
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item);
            }
        }


        


    }
}

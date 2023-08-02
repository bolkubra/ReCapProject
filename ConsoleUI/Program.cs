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
            UserManager userManager = new UserManager(new EfUserDal());
           
            var result = carManager.GetCarDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data )
                {
                    Console.WriteLine(car.CarName + " " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }


        private static UserManager AddUser(UserManager userManager)
        {
            userManager.Add(new User
            {
                FirstName = "Max",
                LastName = "Mustermann",
                Email = "max@test.de",
                Password = "123456",
               
            });
            return userManager;
            
        }


    }
}

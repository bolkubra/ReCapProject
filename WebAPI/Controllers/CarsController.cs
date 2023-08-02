using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFremework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public List<Car> Get()
        {
            ICarService carService = new CarManager (new EfCarDal());
            var result = carService.GetAll();
            return result.Data;

        }
    }
}

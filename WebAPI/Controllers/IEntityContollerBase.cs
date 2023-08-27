using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public interface IEntityControllerBase<T>
    {
       

        [HttpPost("delete")]
        public IActionResult Delete(T entity);

        [HttpGet("getall")]
        public IActionResult GetAll();

        [HttpGet("getbyid")]
        public IActionResult GetById(int id);

        [HttpPost("insert")]
        public IActionResult Insert(T entity);

        [HttpPost("update")]
        public IActionResult Update(T entity);



    }
}

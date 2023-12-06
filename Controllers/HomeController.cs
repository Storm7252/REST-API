using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Web_api.Models;
using Web_api.Repos;

namespace Web_api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HomeController : ControllerBase
    {
        private readonly Irepo repoo;

        public HomeController(Irepo repoo)
        {
            this.repoo = repoo;
        }

        [Route("/get")]
        [HttpGet]
        public String Get()
        {
            var res = JsonSerializer.Serialize(repoo.get());
            return res;
        }

        [Route("/Add")]
        [HttpPost]
        public void Add(Student stu)
        {
            repoo.Add(stu);
            
        }
        [Route("/Update")]
        [HttpPost]
        public void Update(Student stu)
        {
            repoo.Update(stu);
        }
        [Route("/delete/{Id:int}")]
        [HttpPost]
        public void Delete(int Id)
        {
            repoo.delete(Id);
        }
    }
}

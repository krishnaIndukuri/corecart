using corecart.Models;
using Microsoft.AspNetCore.Mvc;

namespace corecart.Controllers
{
    public class ObjectController : Controller
    {
        public ObjectResult Index()
        {
            Restaurant obj = new Restaurant { Id = 201, Name = "Hyderabad House" };
            return new ObjectResult(obj);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace service.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var version = new Version {value = "7"} ;

            return Json(version);
        }
    }

    public class Version {
        public string value {get;set;}
    }
}

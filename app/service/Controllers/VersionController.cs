using Microsoft.AspNetCore.Mvc;
using wvse.Service.Data;

namespace service.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
        FileDataProvider _dataProvider;

        public VersionController()
        {
            _dataProvider = new FileDataProvider();
        }

        [HttpGet]
        public JsonResult Get()
        {
            //var version = new Version {Value = "7"} ;

            var version = _dataProvider.GetVersion();           

            return Json(version);
        }
    }
}

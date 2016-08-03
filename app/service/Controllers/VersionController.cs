using Microsoft.AspNetCore.Mvc;
using wvse.service.Data;
using wvse.service.Data.Entities;

namespace service.Controllers
{
    [Route("api/[controller]")]
    public class VersionController : Controller
    {
	FileDataProvider _dataProvider;

	public VersionController()
	{
	    _dataProvider = new FileDataProvider();
	{

        [HttpGet]
        public JsonResult Get()
        {
            var version = new Version {value = "7"} ;

 	    var version2 = _dataProvider.GetVersion();           

            return Json(version2);
        }
    }
}

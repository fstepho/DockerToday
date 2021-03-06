using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using wvse.Proxies;

namespace wvse.Controllers
{
    public class HomeController : Controller
    {
        private VersionServiceProxy _versionServiceProxy;

        public HomeController()
        {
            _versionServiceProxy = new VersionServiceProxy();
        }
        public IActionResult Index()
        {
            var version = "1.0.1";

            //var version = await _versionServiceProxy.GetVersion();

            return View("Index", version);
        }
    }
}

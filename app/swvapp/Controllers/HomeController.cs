using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using swvapp.Proxies;

namespace swvapp.Controllers
{
    public class HomeController : Controller
    {
        private VersionServiceProxy _versionServiceProxy;

        public HomeController()
        {
            _versionServiceProxy = new VersionServiceProxy();
        }
        public async Task<IActionResult> Index()
        {
            //var version = 6;

            var version = await _versionServiceProxy.GetVersion();

            return View(version);
        }
    }
}

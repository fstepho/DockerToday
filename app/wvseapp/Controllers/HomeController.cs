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
        public async Task<IActionResult> Index()
        {
            //var version = 6;

            var version = await _versionServiceProxy.GetVersion();

            return View(version);
        }
    }
}

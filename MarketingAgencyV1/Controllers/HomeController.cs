using Microsoft.AspNetCore.Mvc;
using Website.Controllers;

namespace MarketingAgencyV1.Controllers;

[Route("")]
public class HomeController : BaseController
{
    [Route("")]
    public IActionResult Index()
    {
        CloudPage();

        return View();
    }
}

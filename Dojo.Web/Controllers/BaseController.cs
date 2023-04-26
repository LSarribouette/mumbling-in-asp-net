using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dojo.Web.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {

    }
}

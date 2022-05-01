using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Areas.Admin;

namespace MountainTrip.Areas.Admin.Controllers
{
    using static AdminConstants;

    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public abstract class AdminController : Controller
    {

    }
}

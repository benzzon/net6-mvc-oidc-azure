using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace mvc_app.Controllers
{
    [Authorize]
    public class ClaimsController : Controller
    {
        public IActionResult Index()
        {
            // Get all claims from the current user
            var claims = User.Claims;

            // Pass the claims to the view
            return View(claims);
        }
    }
}

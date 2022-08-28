using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MealTracker.Controllers
{
    [Authorize(Roles = "Verified,Administrator")]
    [ApiController]
    [Route("api/[controller]")]
    public class MealController : ControllerBase
    {
        //public IActionResult Index(){ return View(); }

        public async Task<IEnumerable<Models.MealItem>> GetToday()
        {
        }

         public async Task<Models.MealItem> Add(Models.MealItem item)
        {
        }
    }
}

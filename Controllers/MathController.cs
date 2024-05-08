using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_LeardiniGioele_WebAPI.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : Controller
    {

        [HttpGet("GetFibonacci")]
        public JsonResult GetMultiplointero(int n1)
        {
            if (n1 <= 1)
                return Json(new { output = n1, status = "OK" });
            else
                return Json(new { output = (n1 - 1) + (n1 - 2), status = "OK" });

        }

        [HttpGet("GetFibonacci")]
        public JsonResult GetFibonacci(int n1)
        {
            if (n1 <= 1)
                return Json(new { output = n1, status = "OK" });
            else
                return Json(new { output = (n1 - 1) + (n1 - 2), status = "OK" });

        }



    }
}

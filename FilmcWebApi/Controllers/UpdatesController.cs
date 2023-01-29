using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmcWebApi.Controllers
{
    [Route("FilmcApi/[controller]")]
    [ApiController]
    public class UpdatesController : Controller
    {
        [HttpGet]
        public byte[] GetLastFile()
        {
            return null;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrometheusLegacyApi.Persistence;

namespace PrometheusLegacyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/usuario")]
    public class AstorgaController : Controller
    {
        private readonly AstorgaDbContext _context;

        public AstorgaController(AstorgaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAstorgaUsuario(){
            var astorgaUsuario = await _context.Usuarios.ToListAsync();

            return Ok(astorgaUsuario);
        }
    }
}

using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;
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
        public async Task<IActionResult> GetAstorgaUsuario() {
            var astorgaUsuario = await _context.Usuarios.ToListAsync();

            return Ok(astorgaUsuario);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAstorgaUsuarioId(int id)
        {
            var usuarioId = await _context.Usuarios.FindAsync(id);

            if (usuarioId == null)
            {
                return NotFound();
            }

            return Ok(usuarioId);
        }
    }
}

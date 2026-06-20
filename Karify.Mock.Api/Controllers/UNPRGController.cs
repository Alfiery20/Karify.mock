using Karify.Mock.Application.Entity;
using Karify.Mock.Persistence.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Karify.Mock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UNPRGController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = Database.Tesis
                .Select(t => ToDto(t));

            return Ok(result);
        }

        [HttpGet("facultad/{facultadId}")]
        public IActionResult GetByFacultad(int facultadId)
        {
            var facultad = Database.Facultades.FirstOrDefault(f => f.Id == facultadId);
            if (facultad is null)
                return NotFound($"No se encontró la facultad con Id {facultadId}.");

            var result = Database.Tesis
                .Where(t => t.Escuela.Facultad.Id == facultadId)
                .Select(t => ToDto(t));

            return Ok(result);
        }

        [HttpGet("escuela/{escuelaId}")]
        public IActionResult GetByEscuela(int escuelaId)
        {
            var escuela = Database.Escuelas.FirstOrDefault(e => e.Id == escuelaId);
            if (escuela is null)
                return NotFound($"No se encontró la escuela con Id {escuelaId}.");

            var result = Database.Tesis
                .Where(t => t.EscuelaId == escuelaId)
                .Select(t => ToDto(t));

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tesis = Database.Tesis.FirstOrDefault(t => t.Id == id);
            if (tesis is null)
                return NotFound($"No se encontró la tesis con Id {id}.");

            return Ok(ToDto(tesis));
        }

        private static object ToDto(Tesis t) => new
        {
            t.Id,
            t.DOI,
            t.Titulo,
            t.Resumen,
            t.FechaPublicacion,
            t.Idioma,
            t.Uri,
            t.UrlPdf,
            t.TipoAcceso,
            t.TipoTesis,
            t.AreaOcde,
            t.PalabrasClave,
            Escuela = new
            {
                t.Escuela.Id,
                t.Escuela.Nombre,
                Facultad = new
                {
                    t.Escuela.Facultad.Id,
                    t.Escuela.Facultad.Nombre,
                    t.Escuela.Facultad.Codigo
                }
            },
            Autores = t.TesisAutores.Select(ta => new
            {
                ta.Autor.Id,
                ta.Autor.Nombre,
                ta.Autor.ApellidoPaterno,
                ta.Autor.ApellidoMaterno
            })
        };
    }
}
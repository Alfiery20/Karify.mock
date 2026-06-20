using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karify.Mock.Application.Entity
{
    public class Tesis
    {
        public int Id { get; set; }
        public string DOI { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Resumen { get; set; } = string.Empty;
        public DateOnly FechaPublicacion { get; set; }
        public string Idioma { get; set; } = "spa";
        public string Uri { get; set; } = string.Empty;
        public string UrlPdf { get; set; } = string.Empty;
        public string TipoAcceso { get; set; } = string.Empty;   // "openAccess"
        public string TipoTesis { get; set; } = string.Empty;    // "bachelorThesis"
        public string? AreaOcde { get; set; }
        public List<string> PalabrasClave { get; set; } = [];

        // FK
        public int EscuelaId { get; set; }
        public Escuela Escuela { get; set; } = null!;

        public List<TesisAutor> TesisAutores { get; set; } = [];
    }
}

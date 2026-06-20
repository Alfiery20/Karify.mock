using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karify.Mock.Application.Entity
{
    public class Escuela
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public Facultad Facultad { get; set; } = null!;
        public List<Tesis> Tesis { get; set; } = [];
    }
}

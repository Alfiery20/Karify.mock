using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karify.Mock.Application.Entity
{
    public class TesisAutor
    {
        public int Id { get; set; }
        public Tesis Tesis { get; set; } = null!;

        public Autor Autor { get; set; } = null!;
    }
}

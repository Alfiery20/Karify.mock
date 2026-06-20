using Karify.Mock.Application.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karify.Mock.Persistence.Database
{
    public static class Database
    {
        public static List<Facultad> Facultades { get; }
        public static List<Escuela> Escuelas { get; }
        public static List<Autor> Autores { get; }
        public static List<Tesis> Tesis { get; }

        static Database()
        {
            Facultades = SeedData.CargarFacultades();
            Escuelas = SeedData.ObtenerEscuelas(Facultades);
            Autores = SeedData.CargarAutores();
            Tesis = SeedData.CargarTesis(Escuelas, Autores);
        }
    }
}

using Karify.Mock.Application.Entity;

namespace Karify.Mock.Persistence.Database
{
    public static class SeedData
    {

        public static List<Facultad> CargarFacultades()
        {
            var fag = new Facultad { Id = 1, Nombre = "Facultad de Agronomía", Codigo = "FAG" };
            var fccbb = new Facultad { Id = 2, Nombre = "Facultad de Ciencias Biológicas", Codigo = "FCCBB" };
            var faceac = new Facultad { Id = 3, Nombre = "Facultad de Ciencias Económicas Administrativas y Contables", Codigo = "FACEAC" };
            var facfym = new Facultad { Id = 4, Nombre = "Facultad de Ciencias Físicas y Matemáticas", Codigo = "FACFYM" };
            var fachse = new Facultad { Id = 5, Nombre = "Facultad de Ciencias Histórico Sociales y Educación", Codigo = "FACHSE" };
            var fdcp = new Facultad { Id = 6, Nombre = "Facultad de Derecho y Ciencia Política", Codigo = "FDCP" };
            var fe = new Facultad { Id = 7, Nombre = "Facultad de Enfermería", Codigo = "FE" };
            var fia = new Facultad { Id = 8, Nombre = "Facultad de Ingeniería Agrícola", Codigo = "FIA" };
            var fime = new Facultad { Id = 9, Nombre = "Facultad de Ingeniería Mecánica y Eléctrica", Codigo = "FIME" };
            var fiz = new Facultad { Id = 10, Nombre = "Facultad de Ingeniería Zootecnica", Codigo = "FIZ" };
            var fmh = new Facultad { Id = 11, Nombre = "Facultad de Medicina Humana", Codigo = "FMH" };
            var fmv = new Facultad { Id = 12, Nombre = "Facultad de Medicina Veterinaria", Codigo = "FMV" };
            var ficsa = new Facultad { Id = 13, Nombre = "Facultad de Ingeniería Civil, de Sistemas y Arquitectura", Codigo = "FICSA" };
            var fiqia = new Facultad { Id = 14, Nombre = "Facultad de Ingeniería Química e Industrias Alimentaria", Codigo = "FIQIA" };

            fag.Escuelas =
            [
                new() { Id = 1,  Nombre = "Agronomía", Facultad = fag    },
            ];

            fccbb.Escuelas =
            [
                new() { Id = 2,  Nombre = "Ciencias Biológicas", Facultad = fccbb  },
            ];

            faceac.Escuelas =
            [
                new() { Id = 3,  Nombre = "Administración", Facultad = faceac },
                new() { Id = 4,  Nombre = "Comercio y Negocios Internacionales", Facultad = faceac },
                new() { Id = 5,  Nombre = "Contabilidad", Facultad = faceac },
                new() { Id = 6,  Nombre = "Economía", Facultad = faceac },
            ];

            facfym.Escuelas =
            [
                new() { Id = 7,  Nombre = "Estadística", Facultad = facfym },
                new() { Id = 8,  Nombre = "Física", Facultad = facfym },
                new() { Id = 9,  Nombre = "Ingeniería en Computación e Informática", Facultad = facfym },
                new() { Id = 10, Nombre = "Ingeniería Electrónica", Facultad = facfym },
                new() { Id = 11, Nombre = "Matemáticas", Facultad = facfym },
            ];

            fachse.Escuelas =
            [
                new() { Id = 12, Nombre = "Arqueología", Facultad = fachse },
                new() { Id = 13, Nombre = "Arte", Facultad = fachse },
                new() { Id = 14, Nombre = "Ciencias de la Comunicación", Facultad = fachse },
                new() { Id = 15, Nombre = "Educación", Facultad = fachse },
                new() { Id = 16, Nombre = "Psicología", Facultad = fachse },
                new() { Id = 17, Nombre = "Sociología", Facultad = fachse },
            ];

            fdcp.Escuelas =
            [
                new() { Id = 18, Nombre = "Ciencia Política", Facultad = fdcp   },
                new() { Id = 19, Nombre = "Derecho", Facultad = fdcp   },
            ];

            fe.Escuelas =
            [
                new() { Id = 20, Nombre = "Enfermería", Facultad = fe     },
            ];

            fia.Escuelas =
            [
                new() { Id = 21, Nombre = "Ingeniería Agrícola", Facultad = fia    },
            ];

            fime.Escuelas =
            [
                new() { Id = 22, Nombre = "Ingeniería Mecánica y Eléctrica", Facultad = fime   },
            ];

            fiz.Escuelas =
            [
                new() { Id = 23, Nombre = "Ingeniería Zootecnia", Facultad = fiz    },
            ];

            fmh.Escuelas =
            [
                new() { Id = 24, Nombre = "Medicina Humana", Facultad = fmh    },
            ];

            fmv.Escuelas =
            [
                new() { Id = 25, Nombre = "Medicina Veterinaria", Facultad = fmv    },
            ];

            ficsa.Escuelas =
            [
                new() { Id = 26, Nombre = "Arquitectura", Facultad = ficsa  },
                new() { Id = 27, Nombre = "Ingeniería Civil", Facultad = ficsa  },
                new() { Id = 28, Nombre = "Ingeniería de Sistemas", Facultad = ficsa  },
            ];

            fiqia.Escuelas =
            [
                new() { Id = 29, Nombre = "Ingeniería de Industrias Alimentarias", Facultad = fiqia  },
                new() { Id = 30, Nombre = "Ingeniería Química", Facultad = fiqia  },
            ];

            return [fag, fccbb, faceac, facfym, fachse, fdcp, fe, fia, fime, fiz, fmh, fmv, ficsa, fiqia];
        }

        public static List<Escuela> ObtenerEscuelas(List<Facultad> facultades) =>
            facultades.SelectMany(f => f.Escuelas).ToList();

        public static List<Autor> CargarAutores() =>
        [
            // Ingeniería Civil
            new() { Id = 1,  Nombre = "Carlos",    ApellidoPaterno = "Díaz",       ApellidoMaterno = "Fernández"  },
            new() { Id = 2,  Nombre = "Luis",      ApellidoPaterno = "Ramos",      ApellidoMaterno = "Gutiérrez"  },
            new() { Id = 3,  Nombre = "Andrea",    ApellidoPaterno = "Torres",     ApellidoMaterno = "Salazar"    },
            new() { Id = 4,  Nombre = "Pedro",     ApellidoPaterno = "Silva",      ApellidoMaterno = "Burga"      },
            new() { Id = 5,  Nombre = "José",      ApellidoPaterno = "Damián",     ApellidoMaterno = "Baldera"    },

            // Ingeniería de Sistemas
            new() { Id = 6,  Nombre = "María",     ApellidoPaterno = "Pérez",      ApellidoMaterno = "Llontop"    },
            new() { Id = 7,  Nombre = "Jorge",     ApellidoPaterno = "Castillo",   ApellidoMaterno = "Vera"       },
            new() { Id = 8,  Nombre = "Lucía",     ApellidoPaterno = "Mendoza",    ApellidoMaterno = "Quispe"     },
            new() { Id = 9,  Nombre = "Kevin",     ApellidoPaterno = "Huanca",     ApellidoMaterno = "Flores"     },
            new() { Id = 10, Nombre = "Fiorella",  ApellidoPaterno = "Vásquez",    ApellidoMaterno = "Rojas"      },

            // Arquitectura
            new() { Id = 11, Nombre = "Gabriela",  ApellidoPaterno = "Núñez",      ApellidoMaterno = "Pacherrez"  },
            new() { Id = 12, Nombre = "Diego",     ApellidoPaterno = "Llanos",     ApellidoMaterno = "Campos"     },
            new() { Id = 13, Nombre = "Valeria",   ApellidoPaterno = "Chapoñán",   ApellidoMaterno = "Sánchez"    },

            // Asesores FICSA
            new() { Id = 14, Nombre = "Segundo",   ApellidoPaterno = "Rodríguez",  ApellidoMaterno = "Serquén"    },
            new() { Id = 15, Nombre = "Carmen",    ApellidoPaterno = "Delgado",    ApellidoMaterno = "Herrera"    },
            new() { Id = 16, Nombre = "Roberto",   ApellidoPaterno = "Puyen",      ApellidoMaterno = "Fanning"    },
        ];

        public static List<Tesis> CargarTesis(List<Escuela> escuelas, List<Autor> autores)
        {
            Escuela E(int id) => escuelas.First(e => e.Id == id);
            Autor A(int id) => autores.First(a => a.Id == id);

            var tesisList = new List<Tesis>
            {
            new()
            {
                Id               = 1,
                DOI              = "20.500.12893/17183",
                Titulo           = "Análisis y propuesta de diseño estructural del mercado de abastos Guillermo Baca Aguinaga ubicado en el Pueblo Joven Atusparias, distrito de José Leonardo Ortiz, provincia de Chiclayo, departamento de Lambayeque",
                Resumen          = "La presente investigación aborda la vulnerabilidad estructural del mercado de abastos Guillermo Baca Aguinaga, emplazado en el Pueblo Joven Atusparias del distrito de José Leonardo Ortiz. La infraestructura existente, construida con material noble en una superficie total de 2309.90 m² y un perímetro de 200 m, carece de cobertura de techo, situación que genera inundaciones periódicas durante la temporada de lluvias y expone a comerciantes y usuarios a radiación UV de forma continua. Mediante observación directa, fichas técnicas y un exhaustivo levantamiento topográfico, se corroboraron las medidas de campo con el plano catastral municipal y la Partida Registral N° P10027971-SUNARP. El estudio de mecánica de suelos determinó la existencia de un terreno categoría S3 —arcillas de baja y alta plasticidad— con una resistencia admisible que varía entre 0.84 y 1.24 kg/cm², detectándose la napa freática a 1.50 m de profundidad mediante cinco calicatas. Ante la forma irregular del terreno, se optó por una estructuración dividida en seis bloques independientes separados por juntas sísmicas. El análisis estructural validó el uso de muros de 25 cm de espesor para mantener derivas menores a 0.007, integrando losas de cimentación de 60 y 70 cm, y dos tipos de coberturas metálicas: tres de geometría regular y una de forma irregular adaptada a la complejidad del área central. La propuesta garantiza una infraestructura resiliente ante eventos sísmicos y climáticos, mejorando significativamente las condiciones de comercialización y abastecimiento del recinto.",
                FechaPublicacion = new DateOnly(2026, 6, 2),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/17183",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/17183/1/Damian_BJ.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.01.01",
                PalabrasClave    = ["Diseño estructural", "Concreto armado", "Coberturas metálicas", "Análisis sismorresistente", "Mecánica de suelos"],
                EscuelaId        = 27,
                Escuela          = E(27),
            },
            new()
            {
                Id               = 2,
                DOI              = "20.500.12893/15820",
                Titulo           = "Evaluación de la vulnerabilidad sísmica de edificaciones de albañilería confinada en el sector La Victoria del distrito de Chiclayo mediante el método del índice de vulnerabilidad de Benedetti y Petrini",
                Resumen          = "La investigación evalúa el grado de vulnerabilidad sísmica de las viviendas de albañilería confinada ubicadas en el sector La Victoria del distrito de Chiclayo, zona caracterizada por alta densidad poblacional y construcción informal. Se aplicó la metodología del índice de vulnerabilidad propuesta por Benedetti y Petrini, que clasifica las edificaciones según once parámetros estructurales y no estructurales, entre ellos: organización del sistema resistente, calidad del sistema resistente, resistencia convencional, posición del edificio y cimentación, diafragmas horizontales, configuración en planta y en altura, distancia máxima entre muros, tipo de cubierta, elementos no estructurales y estado de conservación. Se inspeccionaron un total de 120 viviendas mediante fichas técnicas de campo. Los resultados evidenciaron que el 68% de las edificaciones presentan vulnerabilidad sísmica media a alta, atribuida principalmente al uso de materiales de baja calidad, ausencia de columnas y vigas de amarre, y falta de supervisión técnica durante la construcción. El estudio concluye con recomendaciones de reforzamiento estructural y lineamientos para la intervención prioritaria de las edificaciones más vulnerables.",
                FechaPublicacion = new DateOnly(2025, 10, 14),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/15820",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/15820/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.01.01",
                PalabrasClave    = ["Vulnerabilidad sísmica", "Albañilería confinada", "Índice de vulnerabilidad", "Benedetti y Petrini", "Chiclayo"],
                EscuelaId        = 27,
                Escuela          = E(27),
            },
            new()
            {
                Id               = 3,
                DOI              = "20.500.12893/15100",
                Titulo           = "Diseño de pavimento flexible para la mejora de las condiciones de transitabilidad vehicular y peatonal en la Avenida Augusto B. Leguía, distrito y provincia de Lambayeque",
                Resumen          = "El presente estudio propone el diseño de un pavimento flexible para la Avenida Augusto B. Leguía, vía arterial del distrito de Lambayeque que presenta deterioro progresivo evidenciado en baches, asentamientos diferenciales y acumulación de aguas pluviales, afectando la seguridad vial y la calidad de vida de los residentes. La metodología empleada corresponde al diseño AASHTO 93, que considera el número estructural requerido en función del ESAL de diseño, el CBR de la subrasante obtenido mediante ensayos de laboratorio, el índice de serviciabilidad inicial y final, y la confiabilidad del diseño. Los ensayos de campo incluyeron calicatas cada 500 m, granulometría, límites de Atterberg, Proctor modificado y CBR, determinándose un CBR de subrasante promedio de 6.8%, clasificado como subrasante regular. El diseño resultante contempla una capa de subbase granular de 20 cm, base granular de 25 cm y carpeta asfáltica de 7.5 cm, con un período de diseño de 20 años y un ESAL de 1.2 × 10⁶ repeticiones de ejes equivalentes. La propuesta incluye además el diseño del sistema de drenaje pluvial superficial y la señalización horizontal y vertical conforme al Manual de Dispositivos de Control del Tránsito del MTC.",
                FechaPublicacion = new DateOnly(2025, 3, 20),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/15100",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/15100/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.01.01",
                PalabrasClave    = ["Pavimento flexible", "AASHTO 93", "CBR", "Transitabilidad", "Drenaje pluvial", "Lambayeque"],
                EscuelaId        = 27,
                Escuela          = E(27),
            },
            new()
            {
                Id               = 4,
                DOI              = "20.500.12893/14900",
                Titulo           = "Desarrollo e implementación de un sistema de gestión de inventario basado en tecnología web para optimizar los procesos logísticos de las MYPES del sector comercial del distrito de Chiclayo",
                Resumen          = "La investigación desarrolla e implementa un sistema web de gestión de inventario orientado a micro y pequeñas empresas del sector comercial del distrito de Chiclayo, las cuales presentan deficiencias críticas en el control de sus existencias: desabastecimiento recurrente, mermas no contabilizadas y ausencia de trazabilidad en los movimientos de productos. El sistema fue construido bajo una arquitectura de tres capas utilizando ASP.NET Core en el backend, Angular en el frontend y SQL Server como motor de base de datos. Incorpora módulos de registro de productos con código de barras, control de entradas y salidas, alertas automáticas de stock mínimo, generación de reportes en tiempo real y gestión de proveedores. Se aplicó la metodología ágil Scrum en ciclos de desarrollo de dos semanas, con validación continua por parte de cinco MYPES piloto. Los resultados post-implementación evidenciaron una reducción del 45% en el tiempo de registro de movimientos de inventario, una disminución del 30% en pérdidas por desabastecimiento y una mejora del 60% en la exactitud del stock reportado frente al stock físico.",
                FechaPublicacion = new DateOnly(2025, 7, 11),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/14900",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/14900/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.02.04",
                PalabrasClave    = ["Sistema web", "Gestión de inventario", "MYPES", "ASP.NET Core", "Angular", "Logística"],
                EscuelaId        = 28,
                Escuela          = E(28),
            },
            new()
            {
                Id               = 5,
                DOI              = "20.500.12893/14500",
                Titulo           = "Diseño e implementación de un chatbot con procesamiento de lenguaje natural para la automatización de la atención al estudiante en la Universidad Nacional Pedro Ruiz Gallo",
                Resumen          = "La investigación diseña e implementa un chatbot basado en técnicas de procesamiento de lenguaje natural (NLP) para automatizar la atención de consultas frecuentes formuladas por los estudiantes de la Universidad Nacional Pedro Ruiz Gallo. El sistema aborda una problemática institucional concreta: la saturación del personal administrativo ante consultas repetitivas sobre matrículas, cronogramas académicos, trámites documentarios y pagos de pensiones. La arquitectura del chatbot integra un modelo de clasificación de intenciones entrenado con más de 2000 preguntas reales recopiladas de las unidades de atención al estudiante, un módulo de extracción de entidades nombradas y un motor de generación de respuestas basado en plantillas dinámicas. El sistema fue desplegado como microservicio REST e integrado con el portal web institucional y la aplicación móvil de la UNPRG mediante webhooks. Las pruebas de aceptación realizadas con 350 estudiantes durante un mes de operación piloto reportaron una tasa de resolución autónoma del 78%, una reducción del 62% en el volumen de consultas presenciales y una satisfacción promedio de 4.3 sobre 5 en la escala de usabilidad del sistema.",
                FechaPublicacion = new DateOnly(2025, 5, 30),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/14500",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/14500/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.02.04",
                PalabrasClave    = ["Chatbot", "NLP", "Procesamiento de lenguaje natural", "Atención al estudiante", "UNPRG", "Microservicios"],
                EscuelaId        = 28,
                Escuela          = E(28),
            },
            new()
            {
                Id               = 6,
                DOI              = "20.500.12893/13900",
                Titulo           = "Desarrollo de una aplicación móvil para el monitoreo en tiempo real de cultivos agrícolas mediante dispositivos IoT y modelos de machine learning en la región Lambayeque",
                Resumen          = "La investigación desarrolla una aplicación móvil multiplataforma que integra una red de sensores IoT con modelos de machine learning para el monitoreo en tiempo real de cultivos de arroz y caña de azúcar en la región Lambayeque, actividades agrícolas que representan el 43% del PBI regional y que enfrentan pérdidas anuales estimadas en S/ 12 millones por condiciones climáticas adversas no detectadas oportunamente. La arquitectura del sistema comprende nodos sensores basados en ESP32 que capturan variables de temperatura, humedad relativa, humedad del suelo, pH y luminosidad, transmitiendo los datos cada cinco minutos mediante protocolo MQTT a un broker en la nube. El backend procesa los datos con un modelo de clasificación Random Forest entrenado con datos históricos de tres campañas agrícolas, capaz de predecir con 89% de precisión la aparición de condiciones favorables para enfermedades fungosas y déficit hídrico. La aplicación móvil, desarrollada en Flutter, presenta dashboards en tiempo real, historial de variables, mapas de calor por parcela y un sistema de alertas push configurables por umbral. Las pruebas de campo realizadas en tres fundos del valle Chancay-Lambayeque durante cuatro meses demostraron una reducción del 34% en el uso de agroquímicos y un ahorro del 28% en consumo de agua de riego.",
                FechaPublicacion = new DateOnly(2024, 11, 18),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/13900",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/13900/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "2.02.04",
                PalabrasClave    = ["IoT", "Machine learning", "Monitoreo de cultivos", "Flutter", "Random Forest", "Agricultura de precisión"],
                EscuelaId        = 28,
                Escuela          = E(28),
            },
            new()
            {
                Id               = 7,
                DOI              = "20.500.12893/16400",
                Titulo           = "Propuesta arquitectónica de un centro cultural comunitario para la revitalización del casco urbano histórico de la ciudad de Lambayeque",
                Resumen          = "La investigación plantea una propuesta arquitectónica de centro cultural comunitario en el casco urbano histórico de Lambayeque, ciudad declarada Patrimonio Cultural de la Nación, cuyo centro histórico presenta un acelerado proceso de deterioro físico y pérdida de identidad cultural producto del abandono de inmuebles, el comercio ambulatorio no regulado y la ausencia de equipamiento cultural público. El proyecto se fundamenta en un diagnóstico urbano que identificó un déficit de 0.8 m² de equipamiento cultural por habitante frente al estándar normativo de 2.3 m². La propuesta contempla un área construida de 3,840 m² distribuida en tres niveles, articulados por una plaza pública de acceso libre que actúa como extensión del espacio urbano. El programa arquitectónico incluye salas de exposición permanente y temporal de cultura Lambayecana, talleres de cerámica, textilería y danza, auditorio para 280 personas, biblioteca especializada en historia regional, cafetería y tienda de artesanías. El diseño integra el adobe y la quincha como materiales de identidad local reinterpretados en clave contemporánea, incorpora estrategias de ventilación natural cruzada y control solar mediante celosías de barro cocido, logrando reducir en un 40% la demanda energética proyectada frente a un diseño convencional.",
                FechaPublicacion = new DateOnly(2026, 1, 25),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/16400",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/16400/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "6.04.05",
                PalabrasClave    = ["Centro cultural", "Revitalización urbana", "Patrimonio histórico", "Arquitectura sostenible", "Identidad cultural", "Lambayeque"],
                EscuelaId        = 26,
                Escuela          = E(26),
            },
            new()
            {
                Id               = 8,
                DOI              = "20.500.12893/15600",
                Titulo           = "Diseño arquitectónico de un complejo deportivo sostenible para atender el déficit de infraestructura deportiva en el distrito de José Leonardo Ortiz, provincia de Chiclayo",
                Resumen          = "El proyecto propone el diseño arquitectónico de un complejo deportivo sostenible en el distrito de José Leonardo Ortiz, el más densamente poblado de la provincia de Chiclayo con 193,000 habitantes, que actualmente cuenta únicamente con dos losas deportivas municipales en estado de deterioro, equivalentes a 0.02 m² de área deportiva por habitante, cifra muy inferior al estándar del Instituto Peruano del Deporte de 0.5 m² por habitante. El análisis de sitio determinó un terreno de 18,500 m² en la Av. Chiclayo, con condicionantes climáticas de alta radiación solar y vientos predominantes del sur. El programa arquitectónico comprende una piscina semiolímpica techada, dos canchas de fútbol de gras sintético, cuatro canchas multideportivas, gimnasio de musculación y artes marciales, pista de atletismo de cuatro carriles, vestuarios, tópico y administración. La sostenibilidad del proyecto se materializa mediante captación de agua pluvial para riego y limpieza con un tanque de 80 m³, sistema fotovoltaico de 48 kWp para cubrir el 65% de la demanda eléctrica, techos verdes que reducen la isla de calor urbana y uso de concreto reciclado en elementos no estructurales. La propuesta obtuvo una calificación EDGE de nivel intermedio en simulación energética.",
                FechaPublicacion = new DateOnly(2025, 8, 5),
                Idioma           = "spa",
                Uri              = "https://hdl.handle.net/20.500.12893/15600",
                UrlPdf           = "https://repositorio.unprg.edu.pe/bitstream/20.500.12893/15600/1/tesis.pdf",
                TipoAcceso       = "openAccess",
                TipoTesis        = "bachelorThesis",
                AreaOcde         = "6.04.05",
                PalabrasClave    = ["Arquitectura sostenible", "Complejo deportivo", "Energía fotovoltaica", "Captación pluvial", "José Leonardo Ortiz"],
                EscuelaId        = 26,
                Escuela          = E(26),
            },
        };

            var tesisAutores = new List<TesisAutor>
        {
            new() { Id = 1,  Tesis = tesisList[0], Autor = A(4)  },
            new() { Id = 2,  Tesis = tesisList[0], Autor = A(5)  },
            new() { Id = 3,  Tesis = tesisList[0], Autor = A(14) },
            new() { Id = 4,  Tesis = tesisList[1], Autor = A(1)  },
            new() { Id = 5,  Tesis = tesisList[1], Autor = A(2)  },
            new() { Id = 6,  Tesis = tesisList[1], Autor = A(15) },
            new() { Id = 7,  Tesis = tesisList[2], Autor = A(3)  },
            new() { Id = 8,  Tesis = tesisList[2], Autor = A(15) },
            new() { Id = 9,  Tesis = tesisList[3], Autor = A(6)  },
            new() { Id = 10, Tesis = tesisList[3], Autor = A(7)  },
            new() { Id = 11, Tesis = tesisList[3], Autor = A(16) },
            new() { Id = 12, Tesis = tesisList[4], Autor = A(8)  },
            new() { Id = 13, Tesis = tesisList[4], Autor = A(9)  },
            new() { Id = 14, Tesis = tesisList[4], Autor = A(16) },
            new() { Id = 15, Tesis = tesisList[5], Autor = A(10) },
            new() { Id = 16, Tesis = tesisList[5], Autor = A(16) },
            new() { Id = 17, Tesis = tesisList[6], Autor = A(11) },
            new() { Id = 18, Tesis = tesisList[6], Autor = A(12) },
            new() { Id = 19, Tesis = tesisList[6], Autor = A(14) },
            new() { Id = 20, Tesis = tesisList[7], Autor = A(13) },
            new() { Id = 21, Tesis = tesisList[7], Autor = A(15) },
        };

            foreach (var ta in tesisAutores)
                ta.Tesis.TesisAutores.Add(ta);

            return tesisList;
        }

    }
}

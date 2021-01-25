using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRest.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Creador { get; set; }
        public string Texto { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}

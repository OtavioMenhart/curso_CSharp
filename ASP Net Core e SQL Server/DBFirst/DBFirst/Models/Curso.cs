using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Curso
    {
        public Curso()
        {
            EstudantesCurso = new HashSet<EstudantesCurso>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<EstudantesCurso> EstudantesCurso { get; set; }
    }
}

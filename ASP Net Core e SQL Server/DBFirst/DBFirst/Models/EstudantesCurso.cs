using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class EstudantesCurso
    {
        public int CursoId { get; set; }
        public int EstudanteId { get; set; }
        public bool Ativo { get; set; }

        public Curso Curso { get; set; }
        public Estudantes Estudante { get; set; }
    }
}

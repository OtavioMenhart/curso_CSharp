using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Enderecos
    {
        public int Id { get; set; }
        public int EstudanteId { get; set; }
        public string Rua { get; set; }

        public Estudantes Estudante { get; set; }
    }
}

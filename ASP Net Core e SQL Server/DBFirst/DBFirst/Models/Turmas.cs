using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Turmas
    {
        public Turmas()
        {
            Estudantes = new HashSet<Estudantes>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Estudantes> Estudantes { get; set; }
    }
}

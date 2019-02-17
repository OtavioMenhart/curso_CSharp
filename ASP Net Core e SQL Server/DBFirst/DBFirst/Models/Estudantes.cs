using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Estudantes
    {
        public Estudantes()
        {
            EstudantesCurso = new HashSet<EstudantesCurso>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int TurmaId { get; set; }
        public bool EstaExcluido { get; set; }
        public string Area { get; set; }
        public int CategoriaPagamento { get; set; }
        public bool Debito { get; set; }
        public string Sobrenome { get; set; }

        public Turmas Turma { get; set; }
        public Enderecos Enderecos { get; set; }
        public ICollection<EstudantesCurso> EstudantesCurso { get; set; }
    }
}

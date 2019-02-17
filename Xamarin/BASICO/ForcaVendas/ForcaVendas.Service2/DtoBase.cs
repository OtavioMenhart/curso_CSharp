using System;
using System.Collections.Generic;
using System.Text;

namespace ForcaVendas.Service2
{
    abstract class DtoBase<TPrimaryKey>
        where TPrimaryKey : struct
    {
        public TPrimaryKey Id { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.UtcNow;
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
    }
}

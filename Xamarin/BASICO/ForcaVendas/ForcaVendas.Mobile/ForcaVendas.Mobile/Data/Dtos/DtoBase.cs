using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForcaVendas.Mobile.Data.Dtos
{
    abstract class DtoBase<TPrimaryKey>
        where TPrimaryKey : struct
    {
        [PrimaryKey]
        public TPrimaryKey Id { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.UtcNow;
        public DateTime DataAlteracao { get; set; } = DateTime.UtcNow;
        [JsonIgnore]
        public DateTime? Sincronizado { get; set; } = null;
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForcaVendas.Mobile.Data.Dtos
{
    [Table("Cliente")]
    sealed class ClienteDto : DtoBase<Guid>
    {
        public string ApelidoNomeFantasia { get; set; }
        public string NomeCompletoRazaoSocial { get; set; }
        public string CPFCNPJ { get; set; }
    }
}

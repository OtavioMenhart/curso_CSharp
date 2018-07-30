using System;
using System.Collections.Generic;
using System.Text;

namespace ForcaVendas.Service2
{
    sealed class ClienteDto : DtoBase<Guid>
    {
        public string ApelidoNomeFantasia { get; set; }
        public string NomeCompletoRazaoSocial { get; set; }
        public string CPFCNPJ { get; set; }
    }
}

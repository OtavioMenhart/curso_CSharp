using System;
using System.Collections.Generic;
using System.Text;

namespace App15_JWTAsync.Model
{
    public class RespostaVerificar
    {
        public string JWT { get; set; }
        public Usuario usuario { get; set; }
    }
}

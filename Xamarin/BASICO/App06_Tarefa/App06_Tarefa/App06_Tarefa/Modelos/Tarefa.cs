﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App06_Tarefa.Modelos
{
    public class Tarefa
    {
        public string Nome { get; set; }
        //para aceitar valor null "?"
        public DateTime? DataFinalizacao { get; set; }
        public byte Prioridade { get; set; }

    }
}
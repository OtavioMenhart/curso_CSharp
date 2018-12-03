namespace EngReversa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_OS
    {
        [Key]
        public int TB_OS_ID { get; set; }

        public int TB_SERVICO_CODIGO { get; set; }

        public int TB_CLIENTE_CODIGO { get; set; }

        [Column(TypeName = "text")]
        public string TB_OS_DESCRICAO_PROBLEMA { get; set; }

        public DateTime? TB_OS_DATA_ABERTURA { get; set; }

        public DateTime? TB_OS_DATA_CONCLUSAO { get; set; }

        [StringLength(40)]
        public string TB_OS_STATUS_OS { get; set; }

        [Column(TypeName = "text")]
        public string TB_OS_PARECER_TECNICO { get; set; }

        public virtual TB_CLIENTE TB_CLIENTE { get; set; }

        public virtual TB_SERVICO TB_SERVICO { get; set; }
    }
}

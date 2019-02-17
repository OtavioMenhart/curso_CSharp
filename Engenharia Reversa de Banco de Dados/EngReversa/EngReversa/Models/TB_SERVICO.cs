namespace EngReversa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SERVICO()
        {
            TB_OS = new HashSet<TB_OS>();
        }

        [Key]
        public int TB_SERVICO_CODIGO { get; set; }

        [StringLength(200)]
        public string TB_SERVICO_DESCRICAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TB_SERVICO_PECRO { get; set; }

        public DateTime? TB_SERVICO_DATA_CADASTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_OS> TB_OS { get; set; }
    }
}

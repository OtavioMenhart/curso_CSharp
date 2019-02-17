namespace EngReversa.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_CLIENTE()
        {
            TB_OS = new HashSet<TB_OS>();
        }

        [Key]
        public int TB_CLIENTE_CODIGO { get; set; }

        [StringLength(100)]
        public string TB_CLIENTE_NOME { get; set; }

        [StringLength(100)]
        public string TB_CLIENTE_ENDERECO { get; set; }

        [StringLength(100)]
        public string TB_CLIENTE_PONTO_REFERENCIA { get; set; }

        public int? TB_CLIENTE_NUMERO { get; set; }

        [StringLength(12)]
        public string TB_CLIENTE_CEP { get; set; }

        [StringLength(11)]
        public string TB_CLIENTE_CPF { get; set; }

        [StringLength(20)]
        public string TB_CLIENTE_RG { get; set; }

        [StringLength(50)]
        public string TB_CLIENTE_BAIRRO { get; set; }

        [StringLength(40)]
        public string TB_CLIENTE_CIDADE { get; set; }

        [StringLength(12)]
        public string TB_CLIENTE_TELEFONE { get; set; }

        [StringLength(80)]
        public string TB_CLIENTE_EMAIL { get; set; }

        public DateTime? TB_CLIENTE_DATA_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TB_CLIENTE_DATA_NASCIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_OS> TB_OS { get; set; }
    }
}

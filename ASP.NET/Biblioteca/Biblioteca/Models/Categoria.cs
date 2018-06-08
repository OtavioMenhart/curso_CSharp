using Biblioteca.DataContext;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Biblioteca.Models
{
    public class Categoria
    {
        
        public int Id { get; set; }
        [Required]
        [DisplayName("Categoria")]
        public virtual string Nome { get; set; }
        
    }
}
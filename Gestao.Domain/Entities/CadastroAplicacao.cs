using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao.Domain.Entities
{
    public class CadastroAplicacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Classe { get; set; }
        
    }
}

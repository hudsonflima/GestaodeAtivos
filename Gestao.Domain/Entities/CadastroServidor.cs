using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao.Domain.Entities
{
    public class CadastroServidor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServidorId { get; set; }
        [Required]
        public string Hostname { get; set; }
    }
}

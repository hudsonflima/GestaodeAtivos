using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao.Domain.Entities
{
    public class CadastroComputador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComputadorId { get; set; }
        [Required]
        public string Hostname { get; set; }
        [Required]
        public string Enderecoip { get; set; }
        [Required]
        public string Mac { get; set; }
        [Required]
        public string Setor { get; set; }
    }
}

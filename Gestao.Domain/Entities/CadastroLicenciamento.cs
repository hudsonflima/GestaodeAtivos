using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao.Domain.Entities
{
    public class CadastroLicenciamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LicenciamentoId { get; set; }
        [Required]
        public string SistemaOperacional { get; set; }
        [Required]
        public string Versao { get; set; }
        [Required]
        public string Serial { get; set; }
    }
}

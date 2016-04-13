using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestao.Domain.Entities
{
    public class CadastroFuncao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FuncaoId { get; set; }
        [Required]
        public string NomeFuncao { get; set; }
        [Required]
        public string Aplicacoes { get; set; }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestor.ViewModels
{
    public class EstacaoViewModel
    {
        [Key]
        public int EstacaoId { get; set; }

        [Required (ErrorMessage = "Preencha o Hostname")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Hostname { get; set; }

        [Required(ErrorMessage = "Preencha o Setor")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "Preencha o Endereço IP")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string EnderecoIp { get; set; }

        [Required(ErrorMessage = "Preencha o Sistema Operacional")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(7, ErrorMessage = "Mínimo {0} caracteres")]
        public string SistemaOperacional { get; set; }

        [Required(ErrorMessage = "Preencha a Chave de Ativação do Produto")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres. Ex: ABCDE-FGHIJ-KLMNO-PQRST-WUVXY")]
        [MinLength(30, ErrorMessage = "Mínimo {0} caracteres. Ex: ABCDE-FGHIJ-KLMNO-PQRST-WUVXY")]
        public string ChavedeAtivacao { get; set; }


        public bool Ativo { get; set; }

        public virtual IEnumerable<ImpressoraViewModel> Impressoras { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestor.ViewModels
{
    public class ImpressoraViewModel
    {
        [Key]
        public int ImpressoraId { get; set; }

        [Required(ErrorMessage = "Preencha o nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o setor")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Setor { get; set; }

        [Required(ErrorMessage = "Preencha o endereço IP")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string EnderecoIp { get; set; }

        [Required(ErrorMessage = "Preencha a marca")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Preencha o modelo da impressora")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Preencha o modelo da impressora")]
        [MaxLength(16, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
        public string NumerodeSerie { get; set; }

        public bool Monocromatica { get; set; }

        public bool Colorida { get; set; }
        //Chave Estrangeira
        public int EstacaoId { get; set; }
        public bool Ativo { get; set; }

        //Lazy Loading EF
        public virtual IEnumerable<EstacaoViewModel> Estacoes { get; set; }
    }
}
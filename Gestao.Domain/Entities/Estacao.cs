using System.Collections.Generic;

namespace Gestao.Domain.Entities
{
    public class Estacao
    {
        public int EstacaoId { get; set; }
        public string Hostname { get; set; }
        public string Setor { get; set; }
        public string EnderecoIp { get; set; }
        public string SistemaOperacional { get; set; }
        public string ChavedeAtivacao { get; set; }
        public bool Ativo { get; set; }

        //Coleção - Impressoras
        public virtual IEnumerable<Impressora> Impressoras { get; set; }
    }
}

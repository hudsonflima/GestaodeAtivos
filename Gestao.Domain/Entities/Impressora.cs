namespace Gestao.Domain.Entities
{
    public class Impressora
    {
        public int ImpressoraId { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public string EnderecoIp { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Monocromatica { get; set; }
        public bool Colorida { get; set; }
        //Chave Estrangeira
        public int EstacaoId { get; set; }
        public bool Ativo { get; set; }

        //Lazy Loading EF
        public virtual Estacao Estacao { get; set; }
    }
}

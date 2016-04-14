namespace Gestao.Domain.Entities
{
    public class Servidor
    {
        public int ServidorId { get; set; }
        public string Hostname { get; set; }
        public string Funcao { get; set; }
        public string EnderecoIp { get; set; }
        public string SistemaOperacional { get; set; }
        public string ChavedeAtivacao { get; set; }
    }
}

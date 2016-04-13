namespace GestaodeAtivos.Models
{
    public class Computador
    {
        public int ComputadorID { get; set; }

        public string Hostname { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string EnderecoIP { get; set; }

        public string EnderecoMAC { get; set; }

        public bool Ativo { get; set; }

    }
}
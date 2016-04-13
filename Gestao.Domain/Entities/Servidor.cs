using System.Collections;
using System.Collections.Generic;

namespace Gestao.Domain.Entities
{
    public class Servidor
    {
        public int CadastroId { get; set; }
        public int Hostname { get; set; }
        public int Funcao { get; set; }
        public int Aplicacao { get; set; }
        public int Licenciamento { get; set; }


        public IEnumerable<CadastroServidor> CadastroServidor { get; set; }
        public IEnumerable<CadastroFuncao> CadastroFuncao { get; set; }
        public IEnumerable<CadastroAplicacao> CadastroAplicacao { get; set; }
        public IEnumerable<CadastroLicenciamento> CadastroLicenciamento { get; set; }

       
    }
}

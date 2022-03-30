using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class Servicos{
        private int idServico;
        private string nomeServico;
        private string descricao;
        // chaves estrangeiras
        private string itens;

        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public string Descricao { get; set; }
        public string Itens { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class Pareceres{
        private int idParecer;
        private string observacao;
        private bool atendimento;
        //chave estrangeira
        private int idOs;

        public int IdParecer { get; set; }
        public string Observacao { get; set;}
        public bool Atendimento { get; set; }
        public int IdOs { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class Locais{
        private int idLocal;
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string cep;

        public int IdLocal { get; set; }
        public string Nome { get; set;}
        public string Rua { get; set;}
        public int Numero { get; set;}
        public string Bairro { get; set;}
        public string Cidade { get; set;}
        public string Cep { get; set;}
    }
}

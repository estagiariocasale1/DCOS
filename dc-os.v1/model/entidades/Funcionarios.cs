using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class Funcionarios{
        private int idFunc;
        private int matricula;
        private string nome;
        private string sobrenome;        
        private string telefone;
        // chave estrangeira
        private int idTunro;
        private int cargo;
        private bool apto;

        public int IdFunc { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Cargo { get; set; }
        public string Telefone { get; set; }
        public int IdTurno { get; set; }
        public bool Apto { get; set; }
    }
}

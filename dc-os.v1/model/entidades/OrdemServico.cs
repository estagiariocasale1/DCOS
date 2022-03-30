using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class OrdemServico{
        private int idOs;
        private TimeSpan horaCriada = new TimeSpan();
        private TimeSpan horaIniciada = new TimeSpan();
        private TimeSpan horaFinalizada = new TimeSpan();
        private DateTime dataCriada = new DateTime();
        private DateTime dataIniciada = new DateTime();
        private DateTime dataFinalizada = new DateTime();
        private string nOs;
        private string status;
        //chaves estrangeiras
        private int idSetor;
        private int idVeiculo;
        private int idServico;
        private int idFunc;
        private int idLocal;
        private int idViagem;
        private int idTurno;
        private int idBloco;
        private int idMacrosservico;
        private int idRotina;
        
        public int IdOs { get; set; }
        public DateTime Data { get; set; }
        private DateTime Horario { get; set; }
        public string NOs { get; set;}
        public string Status { get; set;}
        private int IdSetor { get; set;}
        public int IdVeiculo { get; set; }
        public int IdServico { get; set; }
        public int IdFunc { get; set;}
        public int IdLocal { get; set; }
        public int IdViagem { get; set;}
        public int IdTurno { get; set; }
    }  
}





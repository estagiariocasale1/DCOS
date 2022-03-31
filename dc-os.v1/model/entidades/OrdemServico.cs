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
        private int idServico;      
        private int idLocal;
        private int idViagem;
        private int idTurno;
        private int idBloco;
        private int idMacrosservico;
        private int idRotina;
        private int escala;

        public int IdOs { get; set; }
        public TimeSpan HoraCriada { get; set; }
        public TimeSpan HoraIniciada { get; set; }
        public TimeSpan HoraFinalizada { get; set; }
        public DateTime DataCriada { get; set; }
        public DateTime DataIniciada { get; set; }
        public DateTime DataFinalizada { get; set; }
        public string NOs { get; set; }
        public string Status { get; set; }
        //chaves estrangeiras
        public int IdSetor { get; set; }
        public int IdServico { get; set; }
        public int IdLocal { get; set; }
        public int IdViagem { get; set; }
        public int IdTurno { get; set; }
        public int IdBloco { get; set; }
        public int IdMacrosservico { get; set; }
        public int IdRotina { get; set; }
        public int Escala { get; set; }
    }  
}





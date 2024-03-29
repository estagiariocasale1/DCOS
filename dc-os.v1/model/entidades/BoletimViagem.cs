﻿using System;

namespace dc_os.v1.model.entidades{
    public class BoletimViagem {
        private int idViagem;
        private float kmSaida;
        private float kmChegada;
        private TimeSpan horaSaida = new TimeSpan();
        private TimeSpan horaChegada = new TimeSpan();
        private DateTime dataSaida = new DateTime();
        private DateTime dataChegada = new DateTime();
        //chave estrangeira
        private int idVeiculo;
        private int origem;
        private int destino;
        private int motorista;
        

        public int IdViagem {get; set;}
        public float KmSaida { get; set;}
        public float KmChegada { get; set;}
        public TimeSpan HoraSaida { get; set; }        
        public TimeSpan HoraChegada { get; set;}
        public DateTime DataSaida { get; set;}
        public DateTime DataChegada { get; set; }
        public int IdVeiculo { get; set;}
        public int Origem { get; set; }
        public int Destino { get; set;}
        public int Motorista { get; set; }
       
    }
}

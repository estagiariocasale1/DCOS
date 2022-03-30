using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class Relatorios{
        private int idRelatorio;
        private string relato;
        private string croquiAnexo;
        // chave estrangeira
        private int idOs;

        public int IdRelatorio { get; set; }
        public string Relato { get; set;}
        public string CroquiAnexo { get; set;}
        public int IdOs { get; set; }
    }
}

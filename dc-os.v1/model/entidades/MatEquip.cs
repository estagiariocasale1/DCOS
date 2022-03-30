using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc_os.v1.model.entidades{
    public class MatEquip{
        private int idItem;
        private string nome;
        private string tombamento;
        private string logger;

        public int IdItem{ get; set; }
        public string Nome{ get; set; }
        public string Tombamento { get; set; }
        public string Logger { get; set; }
    }
}

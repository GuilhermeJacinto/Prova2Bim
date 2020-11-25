using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Adm.Entity
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Tipo { get; set; }
        public float Valor { get; set; }
        public string Medida { get; set; }
        public string Faixa { get; set; }
        public float Lucro { get; set; }
    }
}

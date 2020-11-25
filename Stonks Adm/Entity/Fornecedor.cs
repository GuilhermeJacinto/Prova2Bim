using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Adm.Entity
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Contato { get; set; }
        public String NomeRepresentante { get; set; }
        public String Email { get; set; }
        public String Categoria { get; set; }
        public String Produto { get; set; }
        public String Preco { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Cliente.Entity
{
    public class Delivery
    {
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string Nome { get; set; }
        public string ClienteCpf { get; set; }

        public Delivery(string cep, string rua, string numero, string bairro, string cidade, string estado, string complemento, string nome)
        {
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Nome = nome;
            ClienteCpf = Login.CPF;
        }

    }
}

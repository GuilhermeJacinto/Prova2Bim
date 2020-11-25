using Stonks.Communs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Cliente.Entity
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public string RepetirSenha { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public int Idade { get; set; }
        public string Delivery { get; set; }

        public Cliente(string nome, string CPF, string senha, string reptSenha, string contato, string email, string dataNasc)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.Senha = senha;
            this.RepetirSenha = reptSenha;
            this.Contato = contato;
            this.Email = email;
            this.DataNasc = dataNasc;
            this.Idade = CalcularIDade();
        }

        private int CalcularIDade()
        {
            int anos = DateTime.Now.Year - Convercao.ConvertDate(DataNasc).Year;
            if (DateTime.Now.Month < Convercao.ConvertDate(DataNasc).Month)
            {
                anos = anos - 1;
            }
            return anos;
        }

    }
}

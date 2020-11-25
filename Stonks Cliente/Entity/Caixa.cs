using Stonks_Adm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stonks_Cliente.Entity
{
    public class Caixa
    {
        public static double Valor { get; set; }


        public static double ReturnValor(List<Produto> lista)
        {
            double soma = 0;
            double mult = 0;

            foreach(var produto in lista)
            {
                if (Login.CPF == produto.CPF)
                {
                    mult = (produto.Valor * (1 + produto.Lucro/100))* produto.Quantidade;
                    soma = soma + mult;
                }
            }

            return Math.Round(soma,2);
        }

        public static double Desconto10()
        {
            return (Valor - Valor * 0.10);
        }

        public static double CartaoCredito(double quantidade)
        {
            double parcela = (Valor / quantidade);
            double juros = 0.2;
            double valor = 0;

            if (quantidade <= 8)
            {
                return parcela;
            }
            else
            {
                if (quantidade == 9)
                {
                    return valor = parcela * (1 + juros);
                }
                for (int contagem = 10; contagem <= quantidade; contagem++)
                {
                    juros = juros + 0.125;
                }

                return valor = parcela * (1 + juros);
            }
        }

        public static double Dinheiro(double valor)
        {
            if (valor == Valor)
            {
                return 0;
            }
            else
            {
                return (valor - Valor);
            }         
        }

    }
}

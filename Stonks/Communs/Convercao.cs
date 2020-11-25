using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks.Communs
{
    class Convercao
    {
        static public float ConvertFloat(String Valor)
        {
            try
            {
                return float.Parse(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        static public DateTime ConvertDate(String Valor)
        {
            try
            {
                return Convert.ToDateTime(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        static public int ConvertInt(String Valor)
        {
            try
            {
                return Convert.ToInt32(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        static public String ConverFloatToString(float Valor)
        {
            try
            {
                return Convert.ToString(Valor);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}

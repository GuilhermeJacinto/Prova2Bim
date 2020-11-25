using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks_Cliente.Entity
{
    class Login
    {
        public static bool login { get; set; }

        public static String CPF { get; set; }

        public Login()
        {
        }

        public bool ReturnLogin()
        {
            return login;
        }

        public string ReturnCpf()
        {
            return CPF;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAO
{
    public class Usuario
    {
        public string Email;
        public string Senha;
        public string Nome;

        public virtual void Logar()
        {
            Console.WriteLine("LOGADO");
        }

    }
}

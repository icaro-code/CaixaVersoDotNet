using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ClienteRepository
    {
        private List<Cliente> clientes = new();

        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }
    }
}

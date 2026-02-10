using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Domain
{
    public class Pedido
    {
        private readonly List<string> _itens = new();

        public int Numero { get; }
        public Cliente Cliente { get; }

        public int QuantidadeItens => _itens.Count;

        public Pedido(int numero, Cliente cliente)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("Número do pedido inválido");
            }
            Cliente = cliente ?? throw new ArgumentException(nameof(cliente));

            Numero = numero;
        }

        public void AdicionarItem(string item)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException("item inválido");
            }
            _itens.Add(item.Trim());
        }

        public void AdicionarItem(params string[] itens)
        {
            foreach (var item in itens)
            {
                AdicionarItem(item);
            }
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Pedido #{Numero} | Cliente: {Cliente.Nome} | Itens: {QuantidadeItens}");
        }
    }
}

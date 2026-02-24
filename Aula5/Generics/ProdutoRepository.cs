using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ProdutoRepository
    {
        private List<Produto> produtos = new();

        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }
    }
}

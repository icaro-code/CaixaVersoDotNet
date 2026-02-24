using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CaixaDeInteiros
    {
        private readonly int[] _elementos = new int[10];
        
    public void Adicionar(int valor, int posicao)
        {
            ValidarPosicao(posicao);
            _elementos[posicao] = valor;
        }

        public int Obter(int posicao)
        {
            ValidarPosicao(posicao);
            return _elementos[posicao];
        }

        private static void ValidarPosicao(int posicao)
        {
            if (posicao < 0 || posicao >= 10)
            {
                throw new ArgumentOutOfRangeException(nameof(posicao), "Posição deve estar entre 0 e 9.");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Caixa<T>
    {
        private readonly T[] _elementos = new T[10];
        //T=int int[]

        public void Adicionar(T valor, int posicao)
        {
            ValidarPosicao(posicao);
            _elementos[posicao] = valor;
        }

        public T Obter(int posicao)
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

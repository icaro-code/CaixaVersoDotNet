using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CaixaDeStrings
    {
        private readonly string[] _elementos = new string[10];

        public void Adicionar(string valor, int posicao)
        {
            ValidarPosicao(posicao);
            _elementos[posicao] = valor;
        }

        public string Obter(int posicao)
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

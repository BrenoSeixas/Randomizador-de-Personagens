using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizador
{
    internal class TesteVector
    {
        public List<int> imagem = new List<int>();

        public TesteVector()
        {

        }

        public TesteVector(List<int> imagem)
        {
           this.imagem = imagem;
        }


        public void Randomizador()
        {
            imagem.Add(1);
            imagem.Add(2);
            imagem.Add(3);
        }

    }
}

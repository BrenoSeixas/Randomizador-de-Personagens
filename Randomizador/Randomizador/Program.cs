using Randomizador;
using System.ComponentModel;
using System.Threading.Channels;

namespace Randomizer
{
    class Program {
    
        static void Main(string[] args)
        {
            TesteVector teste = new TesteVector();


            Console.WriteLine("Digite 0 para randomizar um número:");


            teste.imagem[2] = 3;

            Console.WriteLine(teste.imagem[2].ToString());
        }
    
    }

}

using Randomizador;
using System.ComponentModel;
using System.Threading.Channels;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            TesteVector teste = new TesteVector();
            int n1;

            //Console.WriteLine("Digite 0 para randomizar um número:");
            // n1 = int.Parse(Console.ReadLine());


            teste.imagem.Add(1);

            foreach (int i in teste.imagem)
            {
                Console.WriteLine(teste.imagem.ToString());
            }




        }
    }

}

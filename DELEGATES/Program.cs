using System;
using System.Threading.Channels;

namespace DELEGATES
{
    internal class Program
    {
        //public delegate int MetodoDelegate(string Nome);
        
        public static void UtilizaDelegate(Func<string, int> metodoDelegate)
        {
            var letras = metodoDelegate("Maria");
            Console.WriteLine("Quantidade de Letras: " + letras);
        }

        static void Main(string[] args)
        {
            UtilizaDelegate((n) =>
            {
                Console.WriteLine("Nome: " + n);
                return n.Length;
            });

            Action<string> metodoDelegate = (n) => Console.WriteLine("Nome: " + n);
            metodoDelegate("Madalena");

            Predicate<int> pred = (num) => num%2 == 0;
            Console.WriteLine("Resultado divisão: " + pred(1));

            //var letras = metodoDelegate("Madalena");
            //Console.WriteLine("Quantidade de Letras: " + letras);
        }
    }
}
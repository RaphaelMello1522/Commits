using System;

namespace Collatz
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int numero, valor;
            Console.WriteLine("Insira o numero!");
            numero = int.Parse(Console.ReadLine());
            valor = numero;

            while(valor > 1)
            {
                if(valor % 2 == 0)
                {
                    valor = (valor / 2);
                    Console.Write(valor + " ");
                }
                else
                {
                    valor = (valor * 3) + 1;
                    Console.Write(valor + " ");
                }
            }
            Console.Write("\n\n O numero: " + numero + " tem uma conjuntura consecutiva de " + valor);

            Console.ReadKey();
        }
    }
}

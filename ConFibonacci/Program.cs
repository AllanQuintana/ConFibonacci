using System;

namespace ConFibonacci
{
    class Program
    {
        static void Main(string[] args) 
        {
            int a, b, limite, auxiliar;
            Console.WriteLine("Ingrese la cantidad de numeros de fibonacci");
            int.TryParse(Console.ReadLine(), out limite);
            a = 0;
            b = 1;
            
            for (int i = 0; i < limite; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(1);
                }
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(b);
            }
        }
    }
}
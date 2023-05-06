using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso While
            int i;
            Console.WriteLine("*******Ejemplo de While*******");
            Console.WriteLine("Imprime numeros de 1 hasta 10");
            i = 1; 
            while (i < 11)
            {
                Console.WriteLine(i);
                i++; 
            }

            Console.ReadLine(); 
        }
    }
}

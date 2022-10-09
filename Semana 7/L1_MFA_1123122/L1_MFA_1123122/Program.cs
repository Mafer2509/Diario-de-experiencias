using System;

namespace L1_MFA_1123122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Soy" + nombre);

            Console.Write("Hola Mundo");
            Console.Write("Soy"+ nombre);
            
            Console.ReadKey();
        }
    }
}

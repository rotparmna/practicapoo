using System;

namespace PracticaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona michael = new Persona();
            Console.WriteLine("Hello Michael!");
            michael.PincharCronometro();
            System.Threading.Thread.Sleep(5000);
            michael.PincharCronometro();

            //Console.ReadLine();

            Cronometro cronometro = new Cronometro();
            Console.WriteLine("Hello cronometro!");
            cronometro.IniciarCronometro();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("El tiempo del cronometro es: {0:dd\\.hh\\:mm\\:ss}", cronometro.PararCronometro());

            Console.ReadLine();
        }
    }
}

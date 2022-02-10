using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1ApliConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int cp2;
            Console.WriteLine("Login");
            Console.WriteLine("Escribe tú nombre");
            String cp1 = Console.ReadLine();
            Console.WriteLine("Escribe tú contraseña");
            int.TryParse(Console.ReadLine(),out cp2);
           
            if ((cp1 == "admin")&&(cp2 == 1234))
            {
                Console.Clear();
                Console.WriteLine("**/////**///*");
                Console.WriteLine(" Escoge una opción ");
                Console.WriteLine("1. sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("///***///**////*//");
                int opciones = int.Parse(Console.ReadLine());
                switch (opciones)
                {
                    case  1:
                        Console.WriteLine("Escribe el primer número");
                        double primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo número");
                        double segundo = Double.Parse(Console.ReadLine());
                        Operaciones operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tú resultado es: " + operaciones.Sumar().ToString());
                        Console.ReadLine();
                        break;
                    case  2:
                        Console.WriteLine("Escribe el primer número");
                        primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo número");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tú resultado es: " + operaciones.restar().ToString());
                        Console.ReadLine();
                        break;
                    case 3 :
                        Console.WriteLine("Escribe el primer número");
                        primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo número");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tú resultado es: " + operaciones.multiplicar().ToString());
                        Console.ReadLine();
                        break;
                    case 4 :
                        Console.WriteLine("Escribe el primer número");
                        primero = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo número");
                        segundo = Double.Parse(Console.ReadLine());
                        operaciones = new Operaciones(primero, segundo);
                        Console.WriteLine("Tú resultado es: " + operaciones.dividir().ToString());
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}

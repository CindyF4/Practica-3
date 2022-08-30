using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ejecutar = true;
            Console.WriteLine("***********CALCULADORA*************");

            Console.WriteLine("*******************************");
            Console.WriteLine("Seleccione la operacion a realizar: ");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicacion");
            Console.WriteLine("4- Division");
            Console.WriteLine("5- Cerrar");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int SumaTotal, RestaTotal, MultiTotal, DivTotal;

            switch (opcion)
            {
                case 1:
                    SumaTotal = num1 + num2;
                    Console.WriteLine("La suma total de los numeros es: {0} ", SumaTotal);
                    break;
                case 2:
                    RestaTotal = num1 - num2;
                    Console.WriteLine("La resta total de los numeros es: {0} ", RestaTotal);
                    break;
                case 3:
                    MultiTotal = num1 * num2;
                    Console.WriteLine("La multiplicacion total de los numeros es: {0} ", MultiTotal);
                    break;
                case 4:
                    DivTotal = num1 / num2;
                    Console.WriteLine("La division total de los numeros es: {0} ", DivTotal);
                    break;
                case 5:
                    ejecutar = false;
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;


            } while (ejecutar) ;
        }
    }
}

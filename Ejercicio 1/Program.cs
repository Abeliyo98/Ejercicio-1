using System;

namespace Calculadora

{
    //Abel Vázquez Piña - CALCULADORA - EJERCICIO 1
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                decimal numero1 = 0;
                decimal numero2 = 0;
                decimal resultado = 0;

                int n = 1;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("¿Desea utilizar la calculadora?, <S/N>");
                    string respuesta = Convert.ToString(Console.ReadLine());

                    if (respuesta.ToUpper() == "S")
                    {
                        Console.Clear();

                        Console.WriteLine("*********************CALCULADORA*********************\n" + "Elija una operación: \n" +
                            "1. Suma \n" + "2. Resta \n" + "3. Multiplicación \n" + "4. División \n ");
                        string opcion = Console.ReadLine();

                        Console.WriteLine("Indique un número: ");
                        numero1 = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Indique otro número: ");
                        numero2 = Convert.ToDecimal(Console.ReadLine());

                        if (numero2 == 0 && opcion == "4")
                        {
                            throw new ArgumentException("No se puede dividir entre cero.");
                        }
                        switch (opcion)
                        {
                            case "1":
                                resultado = numero1 + numero2; Console.WriteLine("El resultado de la operación elegida es: " + resultado);
                                break;

                            case "2":
                                resultado = numero1 - numero2; Console.WriteLine("El resultado de la operación elegida es: " + resultado);
                                break;

                            case "3":
                                resultado = numero1 * numero2; Console.WriteLine("El resultado de la operación elegida es: " + resultado);
                                break;

                            case "4":
                                resultado = numero1 / numero2; Console.WriteLine("El resultado de la operación elegida es: " + resultado);
                                break;

                            default:
                                Console.WriteLine("La opción elegida es incorrecta");
                                break;
                        }
                        n++;

                    }
                    else
                    {
                        Console.WriteLine("Pulse cualquier tecla para salir de la aplicación");
                    }

                }
                Console.ReadKey();

            }
            catch (Exception error)
            {
                Console.WriteLine("Ha ocurrido un error. Por favor, contacte con soporte para obtener mas información del error. " + error.Message);
                Console.ReadKey();

            }

        }
    }
}

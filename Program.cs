using System;

class Calculadora
{
  static void Main()
   {
        Console.WriteLine("Welcome Calculator,Bienvenido a mi Calculadora");
        Console.WriteLine("Escoja su idioma,Choose your language ");
        Console.WriteLine("ES → español | EN → English");
        string lenguage = Console.ReadLine();

        if (lenguage == "ES") 
        {
            while (true)
            {
                Console.WriteLine("Calculadora Simple");
                Console.WriteLine("1.Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Selecciona una opcion de (1-5)");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.WriteLine("Hasta luego");
                    break;
                }

                Console.Write("Ingrese el Primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el Segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"Resultado:{num1}+{num2}={num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine($"Resultado:{num1}-{num2}={num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine($"Resultado:{num1}*{num2}={num1 * num2}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Resultado:{num1}/{num2}={num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir por cero");
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion no valida. Por favor vuelvalo a intentar");
                        break;
                }
                Console.ReadKey();
            }
        }
        else 
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Select an option (1-5): ");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"Result:{num1}+{num2}={num1 + num2}");
                        break;
                    case "2":
                        Console.WriteLine($"Result:{num1}-{num2}={num1 - num2}");
                        break;
                    case "3":
                        Console.WriteLine($"Result:{num1}*{num2}={num1 * num2}");
                        break;
                    case "4":
                        if (num2 != 0)
                        {
                            Console.WriteLine($"Result:{num1}/{num2}={num1 / num2}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;
                }
                Console.ReadKey();
            }

        }

       
    }
}
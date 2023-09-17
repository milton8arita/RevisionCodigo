using System;

class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción (1-5): ");

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 5)
            {
                Console.WriteLine("¡Adiós!");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = Calculator.Add(num1, num2);
                    break;
                case 2:
                    resultado = Calculator.Subtract(num1, num2);
                    break;
                case 3:
                    resultado = Calculator.Multiply(num1, num2);
                    break;
                case 4:
                    resultado = Calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }
}

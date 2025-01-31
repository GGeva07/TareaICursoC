using System.Diagnostics.CodeAnalysis;

class Program {

    static void Main(String[] args)
    {
        int num, num1;
        Console.WriteLine("1- Hacer un programa que divida dos números");

        Console.WriteLine("Ingrese un numero");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Escribir($"El resultado es: {num / num1} ");

        LimpiarPantalla();

        Console.WriteLine("2- Desarrollar un programa que permita digitar 2 números y luego lo multiplique");

        Console.WriteLine("Ingrese un numero");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        num1 = Convert.ToInt32(Console.ReadLine());
        Escribir($"El resultado es: {num * num1} ");

        LimpiarPantalla();

        Console.WriteLine("3- Hacer un programa que ejecute la siguiente formula ");
        double a = 1, b = -3, c = 2; 
        double d = b * b - 4 * a * c; 

        if (d >= 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Escribir($"Soluciones x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("No hay soluciones reales.");
        }
        LimpiarPantalla();

        Console.WriteLine("4- Hacer un programa que diga si el numero digitado es primo o no");
        Console.WriteLine("Ingrese un numero");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 1)
        {
            Console.WriteLine("El numero no es primo");
        }
        else if (num == 2)
        {
            Console.WriteLine("El numero es primo");
        }else if (num % 2 != 0)
        {
            Console.WriteLine("El numero es primo");
        }
        LimpiarPantalla();

        Console.WriteLine("5-  Realizar un programa que imprima los números impares del 1 al 30");
        
        for (int i = 0; i < 30; i++)
        {
            if (i % 2 != 0) 
            {
                num = i;
                Console.WriteLine(num);
            }
            
        }
        LimpiarPantalla();

        Console.WriteLine("6- Desarrollar un programa 1ue imprima los números de la serie Fibonacci del 1 al 50");
        for (int e = 1, f = 1; e <= 50; f += e, e = f - e)
            Console.WriteLine(e);
        LimpiarPantalla();
    }

    static void LimpiarPantalla()
    {
        Console.WriteLine();
        Console.WriteLine("Presione pa continuar");
        Console.ReadKey();
        Console.Clear();
    }

    static void Escribir(string mensaje, int velocidad = 50)
    {
        foreach (char letra in mensaje)
        {
            Console.Write(letra);
            Thread.Sleep(velocidad);
        }
    }
}

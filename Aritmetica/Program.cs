using System;


namespace Aritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double absoluto, potencia, raiz, numero;
            Console.Write("Ingrese un numero real: ");
            int real = Convert.ToInt32(Console.ReadLine());

            numero = real / 2;

            absoluto = Math.Abs(real);

            potencia = Math.Pow(real, 10);

            raiz = Math.Sqrt(real);

            Console.WriteLine("El resto: " + numero);
            Console.WriteLine("Valor Absoluto: " + absoluto);
            Console.WriteLine("Decima Potencia: " + potencia);
            Console.WriteLine("Raiz Cuadrada: " + raiz);


            Console.ReadKey();

        }
    }
}

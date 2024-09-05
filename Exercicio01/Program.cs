using System;
using System.Globalization;

namespace Exercicio01 {
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("Qual é a cotação do dólar?: ");
            Dolar.Reais = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?: ");
            Dolar.ValorComprado = double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " +Dolar.ValorFinal(),CultureInfo.InvariantCulture);






        }
    }
}
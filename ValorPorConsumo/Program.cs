//Problema "operadora"
//Uma operadora de telefonia cobra R$ 50.00 por um plano básico que dá direito a 100 minutos de
//telefone. Cada minuto que exceder a franquia de 100 minutos custa R$ 2.00. Fazer um programa para
//ler a quantidade de minutos que uma pessoa consumiu, daí mostrar o valor a ser pago. 

using System.Globalization;

namespace ValorPorConsumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantMinutos, minutosExcedidos, valorTotal;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite a quantidade de minutos: ");
            quantMinutos = int.Parse(Console.ReadLine());

            if (quantMinutos <= 100)
            {
                Console.WriteLine("Valor a pagar: R$ 50.00");
            }
            else 
            {
                minutosExcedidos = quantMinutos - 100;
                valorTotal = minutosExcedidos * 2 + 50;
                Console.WriteLine($"Valor a pagar: R$ {valorTotal.ToString("F2", CI)}");
            }
        }
    }
}

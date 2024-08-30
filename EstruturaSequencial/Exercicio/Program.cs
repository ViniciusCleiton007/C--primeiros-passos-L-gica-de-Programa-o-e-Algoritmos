using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            String fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa? ");
            int bedRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura: ");
            String[] vet = Console.ReadLine().Split(' ');

            String lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedRooms);
            Console.WriteLine(product.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

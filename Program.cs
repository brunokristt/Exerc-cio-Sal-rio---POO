using System;
using System.Globalization;

namespace Exercício_Salário___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            double media;

            Console.WriteLine("Média dos salários de dois funcionários");

                                        
            Console.Write("Digite o nome do primeiro funcionário: ");
            func1.nome = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o nome do segundo funcionário: ");
            func2.nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (func1.salario + func2.salario) / 2;

            Console.WriteLine();
            Console.WriteLine("A média de salário dos funcionários é de R$ " + media);

            
        }
    }
}

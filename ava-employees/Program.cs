using System;
using System.Globalization;

namespace ava_employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employee;
            employee = new Employees();
            int atualYear = DateTime.Now.Year;
            double increase = 10;
            Employees NewSalary;

            //menu inicial
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------  Ajuste salarial ------------");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("[1] Cadastrar novo salário do colaborador");
            Console.WriteLine("[2] Sair");
            Console.WriteLine("------------------------------------------");
            Console.Write("Digite a opção desejada: ");
            string menuOption = Console.ReadLine();

            //opção 01 do menu
            if (menuOption == "1")
            {
                while (menuOption == "1")
                {
                    //entrada dos dados digitados pelo usuário
                    Console.Write("Digite o nome do colaborador: ");
                    employee.name = Console.ReadLine();

                    Console.Write("Digite o cargo do colaborador: ");
                    employee.role = Console.ReadLine();

                    Console.Write("Digite o salário atual do colaborador: ");
                    employee.atualSalary = double.Parse(Console.ReadLine());

                    Console.Write("Digite o ano de entrada do colaborador na empresa: ");
                    employee.since = int.Parse(Console.ReadLine());

                    
                    //cálculo caso o colaborador tenha mais de 5 anos de empresa e salário acima de R$ 7.000,00
                    if (atualYear - employee.since >= 5 && employee.atualSalary > 7000)
                    {
                        increase = 0.10;
                        Console.WriteLine($"O(A) colaborador(a) {employee.name} está na empresa desde {employee.since} e receberá um aumento de {increase * 100}%");
                        Console.WriteLine($"Seu salário anterior era de R${employee.atualSalary} e passará a receber R${newSalary}. O aumento foi de R${newSalary - employee.atualSalary}");
                    }
                    //cálculo caso o colaborador tenha mais de 5 anos de empresa e salário de R$ 7.000,00 ou menos
                    else if (atualYear - employee.since >= 5 && atualYear - employee.atualSalary <= 7000)
                    {
                        Console.Write("Digite quantos % de aumento o colaborador receberá (somente números): ");
                        increase = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O(A) colaborador(a) {employee.name} está na empresa desde {employee.since} e receberá um aumento de {increase}%");
                        Console.WriteLine($"Seu salário anterior era de R${employee.atualSalary} e passará a receber R${newSalary}. O aumento foi de R${newSalary - employee.atualSalary}");
                     //cálculo caso o colaborador não tenha mais de 5 anos de empresa
                    }
                    else
                    {
                        Console.WriteLine("Colaborador(a) não elegível para aumento de salário no momento.");
                    }

                    //repetição do menu inicial
                    Console.WriteLine("O que deseja fazer agora?");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("[1] Cadastrar novo salário do colaborador");
                    Console.WriteLine("[2] Sair");
                    Console.WriteLine("------------------------------");
                    Console.Write("Digite a opção desejada: ");
                    menuOption = Console.ReadLine();
                }
            } else
            {
                //sair do programa
                Environment.Exit(0);
            }
        }
    }
}
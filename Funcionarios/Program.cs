using System;
using System.Collections.Generic;

namespace ExercicioListasEmSala_10_05_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            List<Funcionario> func = new List<Funcionario>();
            do
            {
                Console.Write("Nome do Funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Valor do salario: ");
                double salario = double.Parse(Console.ReadLine());

                Console.Write("EIdade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Departamento de trabalho: ");
                string departamento = Console.ReadLine();
                departamento.ToLower();

                func.Add(new Funcionario(nome, salario, idade, email, departamento));

                Console.Write("Deseja adiciona mais um funcionario? (s/n)");
                opcao = char.Parse(Console.ReadLine());


            } while (opcao == 's');

            Console.WriteLine("====== Detalhes ======");

            foreach (Funcionario obj in func)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("============");

            Console.WriteLine("Total de funcionarios: " + func.Count);

            int contador = 0;
            if (func.Exists(x => x.Departamento == "rh"))
            {
                foreach (Funcionario obj in func)
                {
                    contador++;
                }
                Console.WriteLine(contador);
            }





        }
    }
}

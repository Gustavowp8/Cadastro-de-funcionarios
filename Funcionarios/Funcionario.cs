using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioListasEmSala_10_05_2022
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }

        public Funcionario(string nome, double salario, int idade, string email, string departamento)
        {
            Nome = nome;
            Salario = salario;
            Idade = idade;
            Email = email;
            Departamento = departamento;
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "\nIdade: " + Idade
                + "\nEmai: " + Email
                + "\nDepartamento: " + Departamento
                + "\nSalario: " + Salario;
        }
    }
}

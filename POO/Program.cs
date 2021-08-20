using POO.Models;
using System;
using System.Globalization;

namespace POO {
    class Program {
        static void Main(string[] args) {
            //CalculaPessoaMaisVelha();
            //CalculaMediaSalarialFuncionario();
            //CalculaAreaPerimetroDiagonalRetangulo();
            //CalculaSalarioFuncionario();
            //CalculaNotaAluno();
            ConverterMoeda();
        }
        static void CalculaPessoaMaisVelha() {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira pessoa");

            Console.Write("Nome : ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.Write("Nome : ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade : ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Nome}");

            } else {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Nome}");
            }
        }

        static void CalculaMediaSalarialFuncionario() {
            Funcionario func1 = new Funcionario();
            Funcionario func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (func1.Salario + func2.Salario) / 2;
            Console.WriteLine($"Salário médio = {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void CalculaAreaPerimetroDiagonalRetangulo() {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void CalculaSalarioFuncionario() {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionario");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {funcionario.Nome}, " +
                $"$ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(aumento);

            Console.WriteLine($"Dados atualizados: {funcionario}");
        }

        static void CalculaNotaAluno() {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = " +
                $"{aluno.CalculaNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{aluno.CalculaAprovacao()}");
        }

        static void ConverterMoeda() {
            Console.Write("Qual é a cotação do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares deseja comprar? ");
            double qtdDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = " +
                $"{ConversorDeMoeda.ConversaoDolar(valorDolar, qtdDolares).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

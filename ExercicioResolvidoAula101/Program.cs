using ExercicioResolvidoAula101.Entities;
using ExercicioResolvidoAula101.Entities.Enums;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Contracts;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita e armazena o DEPARTAMENTO.
            Console.Write("INSIRA O NOME DO DEPARTAMENTO: ");
            string depName = Console.ReadLine();
            // Cria o objeto departamento conforme a classe Department.
            Department departamento = new Department(depName);


            // Solicita e armazena dados do trabalhador.
            Console.WriteLine("INSIRA OS DADOS DO TRABALHADOR:");
            Console.Write("NOME: ");
            string name = Console.ReadLine();

            Console.Write("NIVEL DO TRABALHADOR (Junior, Pleno, Senior): ");
            string entrada = Console.ReadLine();
            // Declara uma variavel level do tipo WorkerLevel mas nao atribui valor ainda.
            WorkerLevel level;
            // Testa se o que o usuario digitou corresponde a alguma das opçoes.
            bool conversaoValida = Enum.TryParse(entrada, out level);

            Console.Write("SALARIO BASE: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("Quantos contratos para este trabalhador?");
            int addCont = int.Parse(Console.ReadLine());

            // CRIA UM OBJETO TRABALHADOR
            Worker trab = new Worker(name, level, baseSalary, departamento);



            // CADASTRA OS DADOS EM CADA UM DOS CONTRATOS
            for (int i = 0; i < addCont; i++)
            {
                Console.WriteLine("INSIRA OS DADOS DO #" + i + "CONTRATO:");
                Console.Write("DATA (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("VALOR POR HORA: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("DURAÇAO (HORAS): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(date, valuePerHour, hours);
                trab.AddContract(contrato);
            }






            Console.Write("Digite o mes e ano para verificacao do salario(MM/YYYY):");
            string entrada2 = Console.ReadLine();

            DateTime periodo;

            // TENTA CONVERTER A STRING EM DATA.
            bool conversaoValida2 = DateTime.TryParse("01/" + entrada2, out periodo);

            int month = periodo.Month;
            int year = periodo.Year;







            Console.Write("NOME: " + trab.Name);
            Console.Write("DEPARTAMENTO: " + trab.Department);
            Console.Write("QUANTIA RECEBIDA EM " + entrada2 + ": " + trab.Recebido(year, month));
        }
    }
}
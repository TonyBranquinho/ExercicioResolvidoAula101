using ControleVeiculo;
using System;

namespace MyApp
{// Armazena modelo, volume e consumo de combustivel de um carro e avalia se há o suficiente para uma viagem.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista de veiculos
            List<Veiculo> lista = new List<Veiculo>();

            // Cria um novo veiculo
            Veiculo carro = new Veiculo();

            // Pede o modelo do carro e guarda          
            Console.WriteLine("Digite os dados do veículo:");
            Console.Write("Modelo: ");
            carro.Modelo = Console.ReadLine();

            // Pede o volume de combustivel do carro e guarda
            Console.Write("Quantos lisros tem no tanque: ");
            carro.Combustivel = double.Parse(Console.ReadLine());

            // Pede o consumo de combustivel do carro e guarda
            Console.Write("Qual o consumo de combustivel do veiculo: ");
            carro.Consumo = double.Parse(Console.ReadLine());

            // Adiciona os dados a lista
            lista.Add(carro);


            // Imprime a os dados coletados
            Console.WriteLine();
            foreach (Veiculo v in lista)
            {

                Console.WriteLine("Dados do veiculo: " + v);
            }

            // Pede volume a ser abastecido e imprime os dados atualizados
            Console.WriteLine();
            Console.Write("Digite quantos litros deseja abastecer: ");
            double Litros = double.Parse(Console.ReadLine());
            carro.Abastecer(Litros);


            foreach (Veiculo v in lista)
            {
                Console.WriteLine("Atualizado: " + v);
            }

            //Pede a distancia de uma viagem e calcula se é possivel com o combustivel que tem
            Console.WriteLine();
            Console.Write("Digite a distancia da viagem: ");
            double km = double.Parse(Console.ReadLine());
            carro.SimularViagem(km);

            //Pede a distancia da proxima viagem e recalcula se é possivel com o combustivel que tem
            Console.WriteLine();
            Console.Write("Digite a distancia da proxima viagem: ");
            km = double.Parse(Console.ReadLine());
            carro.SimularViagem(km);

            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private double precoInicial = 0;
        private double precoHora = 0;
        List<Veiculo> ListaVeiculo = new List<Veiculo>();

        public Estacionamento(double precoInicial, double precoHora){
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void CadastroVeiculo(){
            Console.Clear();
            Console.WriteLine("Cadastro de veículos:");

            Veiculo newVeiculo = new Veiculo();

            Console.Write("Digite a placa da Veículo:");
            newVeiculo.placa = Console.ReadLine();
            Console.Write("Digite o modelo do Veículo:");
            newVeiculo.modelo = Console.ReadLine();

            ListaVeiculo.Add(newVeiculo);
            Console.Clear();
            Console.WriteLine("Veículo adicionado com Sucesso!\n");
        }

        public void RemoverVeiculo(){
            Console.Clear();
            Console.WriteLine("Remover veículo\n");
            Console.Write("Digite a placa do veículo:");
            String placaInput = Console.ReadLine();
            Veiculo itemExcluir = new Veiculo();
            Boolean encontrado = false;

            foreach(Veiculo item in ListaVeiculo){
                if(item.placa == placaInput){
                    itemExcluir = item;
                    encontrado = true;
                }
            }
            if(encontrado){
                Console.Write("Veículo encontrado!\n");
                int i = 0;
                Console.Write("Digite as horas de estacionamento do veículo:");
                String inputValor = Console.ReadLine().Replace(",",".");
                if(int.TryParse(inputValor.Replace(".",""), out i)){
                    Console.Clear();
                    Console.WriteLine($"Veículo: {itemExcluir.modelo} - Placa: {itemExcluir.placa} - FOI RETIRADO!");
                    Console.WriteLine($"Valor pago: R${precoInicial + (precoHora * double.Parse(inputValor))}\n");
                    ListaVeiculo.Remove(itemExcluir);
                }
            }else{
                Console.Write("Veículo não encontrado!\n");
            }           
        }

        public void ListarVeiculo(){
            Console.Clear();
            Console.WriteLine("Listagem de todos os veículos:");
            
            foreach(Veiculo item in ListaVeiculo){
                Console.WriteLine($"Veículo: {item.modelo} - Placa: {item.placa}");
            }
            
            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadLine(); 
        }
    }
}
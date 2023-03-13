// See https://aka.ms/new-console-template for more information

using SistemaEstacionamento.Models;

Console.Write("Bem Vindo ao VagaMob!\nDigite o preço inicial:");
double precoInicial = double.Parse(Console.ReadLine().Replace(",","."));
Console.Write("Digite o preço por hora:");
double precoHora = double.Parse(Console.ReadLine().Replace(",","."));

Estacionamento newEstacionamento = new Estacionamento(precoInicial, precoHora);
int inputMenu = 1;

while(inputMenu != 0){
    Console.Write("Bem Vindo ao VagaMob!\n1-Cadastrar Veículo\n2-Retirar Veículo\n3-Listar Veículos\n4-Sair\nOpção:");
    String opc = (Console.ReadLine()).Replace(",",".");
    int i = 0;

    if(int.TryParse(opc.Replace(".",""), out i)){
        int input = int.Parse(opc.Replace(".",""));
        switch(input){
            case 1:
                newEstacionamento.CadastroVeiculo();
                break;
            case 2:
                newEstacionamento.RemoverVeiculo();
                break;
            case 3:
                newEstacionamento.ListarVeiculo();
                break;
            case 4:
                inputMenu = 0;
                break;
            default:
                Console.WriteLine("\nOpção inválida!\n");            
                break;
        } 
    } 
}
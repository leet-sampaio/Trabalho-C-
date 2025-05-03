using System;

class Quarto{
    static void Main(string[] args){
        int usuario = 0;

        while (usuario != 3){

            Console.WriteLine("\nEscolha uma das opções:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite sua opção: ");
            usuario = int.Parse(Console.ReadLine());

            switch (usuario){
                
                case 1:
                    Console.Write("Informe a temperatura em Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Resultado: {fahrenheit} °F");
                    break;

                case 2:
                    Console.Write("Informe a temperatura em Fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"Resultado: {celsius} °C");
                    break;

                case 3:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Tente novamente!");
                    break;
            }
        }
    }
}

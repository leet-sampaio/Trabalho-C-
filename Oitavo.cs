using System;

class Oitavo{
    static void Main(string[] args){

        Console.WriteLine("Verificando o seu IMC. Vamos ver o resultado?");
        Console.Write("Informe o seu peso(kg): ");
        int peso = int.Parse(Console.ReadLine());

        Console.Write("Informe a sua altura(m): ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso.");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Peso normal.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Sobrepeso.");
        }
        else
        {
            Console.WriteLine("Obesidade.");
        }
    }
}
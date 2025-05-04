using System;

class Setimo{
    
    static void Main(string[] args){

        Console.WriteLine("Iremos calcular os números pares. Ou não! ");

        double[] usuario = new double[10];  

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Informe o {i + 1}ª número: ");
            usuario[i] = double.Parse(Console.ReadLine());
        }

        double somaPares = 0;  

        foreach (double numero in usuario)
        {
            if (numero % 2 == 0)  
            {
                somaPares += numero;  
            }
        }

        Console.WriteLine($"A soma dos números pares é de: {somaPares}");   
    }
}

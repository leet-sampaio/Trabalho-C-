using System;

class Terceiro{
    static void Main (string[] args){
        Console.Write("Cálculo fatorial! Informe um número: ");
        int usuario = int.Parse(Console.ReadLine());

        int calculo = 1;
        int u = usuario;

        while(u > 1){
            calculo *= u;
            u--;
        }

        Console.WriteLine($"Resultado da fatorial: {calculo}");
    }
}
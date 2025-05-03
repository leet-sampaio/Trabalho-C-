using System;

class Segundo{
    static void Main(string[] args){
        Console.WriteLine("Tabuada completa! Informe um número: ");
        int usuario = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++){
            int tabuada = usuario * i;
            Console.WriteLine($"{usuario} * {i} = {tabuada}");
        }
    }
}
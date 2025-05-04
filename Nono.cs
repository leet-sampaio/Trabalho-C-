    using System;

    class Nono{
        static void Main(string[] args){

                Console.WriteLine("Iremos gerar um número aleatório entre 1 e 100. Será que você vai acertar? ");  

                Random aleatorio = new Random();
                int numerofixo = aleatorio.Next(0, 101);  

                int tentativas = 0;

                while(true){           
                
                    Console.Write("Qual número? ");
                    int numero = int.Parse(Console.ReadLine());
                    tentativas++;
        
                    if(numero == numerofixo){
                        Console.WriteLine($"Acertou! O número é {numerofixo}. Acertou em {tentativas} tentativas!");
                        break;
                    } else if(numero < numerofixo){
                        Console.WriteLine("O número é maior. Tente novamente!");
                    } else {
                        Console.WriteLine("O número é menor. Tente novamente!");
                    }
            }
        }
    }
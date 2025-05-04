using System;
using System.Linq; 

class Primeiro{
    static void Main(string[] args){
        Console.Write("Digite uma senha: ");
        string? senha = Console.ReadLine();  

        if (acesso(senha)){
            Console.WriteLine("Seja bem-vindo! Fica à vontade!");
        }else{
            Console.WriteLine("Tente novamente! Verifique se está dentro dessas seguintes condições:");
            Console.WriteLine("- 8 caracteres.");
            Console.WriteLine("- Uma letra maiúscula.");
            Console.WriteLine("- Um número.");
            Console.WriteLine("- Um caractere especial (!, @, #, $, %, &, *)");
        }
    }

    static bool acesso(string? senha){
        if (string.IsNullOrEmpty(senha)) return false;

        if (senha.Length < 8){
            return false;
        }if (!senha.Any(c => char.IsUpper(c))){
            return false;
        }if (!senha.Any(c => char.IsDigit(c))){
            return false;
        }if (!senha.Any(c => "!@#$%&*".Contains(c))){
            return false;
        }
            return true;
    }
}

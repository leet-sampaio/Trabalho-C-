using System;

class Quinto{

    static void Main(string[] args){

        Console.Write("Informe uma palavra ou frase: ");
        string usuario = Console.ReadLine();

        string verificacao = Remocao(usuario);

        if (Final(verificacao)){
            Console.WriteLine("É um palíndromo!");
        }else{
            Console.WriteLine("Não é um palíndromo!");
        }
    }

    // Função para remover espaços e acentos

    static string Remocao(string texto){
        
        texto = texto.Replace(" ", "").ToLower();

        texto = texto.Replace("á", "a").Replace("à", "a").Replace("ã", "a").Replace("â", "a").Replace("ä", "a")
                    .Replace("é", "e").Replace("è", "e").Replace("ê", "e").Replace("ë", "e")
                    .Replace("í", "i").Replace("ì", "i").Replace("î", "i").Replace("ï", "i")
                    .Replace("ó", "o").Replace("ò", "o").Replace("õ", "o").Replace("ô", "o").Replace("ö", "o")
                    .Replace("ú", "u").Replace("ù", "u").Replace("û", "u").Replace("ü", "u")
                    .Replace("ç", "c");

        return texto;
    }

    // Verificando se é um palíndromo

    static bool Final(string texto)
    {
        char[] arr = texto.ToCharArray();
        Array.Reverse(arr);
        string textoInvertido = new string(arr);

        return texto == textoInvertido;
    }
}

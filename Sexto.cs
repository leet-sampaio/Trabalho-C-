using System;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}

public class CadastroProdutos
{
    public static void Main(string[] args)
    {
        Produto[] produtos = new Produto[3];

        Console.WriteLine("Cadastro de 3 Produtos:");

        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine($"Produto {i + 1}:");

            Console.Write("Nome: ");
            string nomeDigitado = Console.ReadLine();

            Console.Write("Preço: ");
            if (double.TryParse(Console.ReadLine(), out double precoDigitado))
            {
                Console.Write("Quantidade: ");
                if (int.TryParse(Console.ReadLine(), out int quantidadeDigitada))
                {
                    Produto novoProduto = new Produto();
                    novoProduto.Nome = nomeDigitado;
                    novoProduto.Preco = precoDigitado;
                    novoProduto.Quantidade = quantidadeDigitada;
                    produtos[i] = novoProduto;
                }
                else
                {
                    Console.WriteLine("Quantidade inválida. Tente novamente.");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Preço inválido. Tente novamente.");
                i--;
            }
        }

        Console.WriteLine("\nListagem de Produtos:");
        foreach (Produto produto in produtos)
        {
            double valorTotal = produto.Preco * produto.Quantidade;
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C2}, Quantidade: {produto.Quantidade}, Valor Total: {valorTotal:C2}");
        }
    }
}
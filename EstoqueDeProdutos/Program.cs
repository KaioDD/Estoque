using EstoqueDeProdutos;
using System.Xml;
using System.Globalization;
using System;


using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao gerenciador de estoque");

        List<Produto> produtos = new List<Produto>();

        int opc;
        do
        {
            Console.WriteLine("\nSelecione a opção desejada:");
            Console.WriteLine("1- Adicionar Produto");
            Console.WriteLine("2- Remover produto");
            Console.WriteLine("3- Ver dados do produto");
            Console.WriteLine("4- Adicionar quantidade ao estoque");
            Console.WriteLine("0- Sair");

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Produto novoProduto = new Produto();
                    Console.Write("Nome: ");
                    novoProduto.Nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    novoProduto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantidade disponível em estoque: ");
                    novoProduto.Quantidade = int.Parse(Console.ReadLine());
                    produtos.Add(novoProduto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Selecione o produto a ser removido:");
                    ListarProdutos(produtos);
                    int indiceRemover = int.Parse(Console.ReadLine());
                    if (indiceRemover >= 0 && indiceRemover < produtos.Count)
                    {
                        produtos.RemoveAt(indiceRemover);
                        Console.WriteLine("Produto removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido!");
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Selecione o produto para ver os dados:");
                    ListarProdutos(produtos);
                    int indiceExibir = int.Parse(Console.ReadLine());
                    if (indiceExibir >= 0 && indiceExibir < produtos.Count)
                    {
                        Console.WriteLine($"Dados do produto:\n{produtos[indiceExibir]}");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido!");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Selecione o produto para adicionar quantidade:");
                    ListarProdutos(produtos);
                    int indiceAdicionar = int.Parse(Console.ReadLine());
                    if (indiceAdicionar >= 0 && indiceAdicionar < produtos.Count)
                    {
                        Console.Write("Digite a quantidade de produtos a ser adicionada no estoque: ");
                        int qte = int.Parse(Console.ReadLine());
                        produtos[indiceAdicionar].AdicionarProdutos(qte);
                        Console.WriteLine("Quantidade adicionada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido!");
                    }
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opc != 0);
    }

    static void ListarProdutos(List<Produto> produtos)
    {
        for (int i = 0; i < produtos.Count; i++)
        {
            Console.WriteLine($"[{i}] {produtos[i].Nome}");
        }
    }
}






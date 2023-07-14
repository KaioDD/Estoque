using EstoqueDeProdutos;
using System.Xml;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();


        Console.WriteLine("Bem Vindo ao gerenciador de estoque");
        Console.WriteLine("Entre com os dados do produto");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.Write("Quantidade disponivel em estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);
        // o P vai ser representado pelo metodo Tostring que foi reescrito na classe produto 

        Console.WriteLine();
        Console.Write("Digite a quantidade de produtos a ser adicionado no estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        // O metodo adicionar produtos vai receber o valor inserido na variavel "qte" e somar ao valor ja existente na quantidade inicial.
        Console.WriteLine("");
        Console.WriteLine($"Dados atualizado: {p}");

        Console.Write("Digite a quantidade de produtos a ser removido do estoque:  ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProduto(qte);

        Console.WriteLine("");
        Console.WriteLine($"Dados atualizado: {p}");


    }

}
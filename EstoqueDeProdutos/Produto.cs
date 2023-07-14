using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstoqueDeProdutos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double CalcularvalorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade) 
        {
            Quantidade -= quantidade;
        }
        private string Apresentar()
        {
            string apresentar = $"{Nome}, \nPreço: {Preco}, \nQuantidade: {Quantidade}, \nTotal: R${CalcularvalorTotalEmEstoque()}";
            return apresentar;
        }

        public override string ToString()
         //Reescrita do metodo toString para apresentar o produto de forma "Personalizada"
        {
            return Apresentar();    
        }
    }
}

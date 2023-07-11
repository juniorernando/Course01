using System;
using System.Globalization;

namespace Course01 {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados dos produtos: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicinarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

    }

}
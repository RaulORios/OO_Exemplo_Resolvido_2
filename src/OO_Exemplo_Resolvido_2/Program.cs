﻿using System;
using System.Globalization;

namespace OO_Exemplo_Resolvido_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();


            Console.WriteLine("Entre os dados do produto >>>");
            Console.Write("Nome: ");
            p.Nome = (Console.ReadLine());
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtde);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");

            Console.ReadKey();





        }
    }
}

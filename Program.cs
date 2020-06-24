using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Produto> produtos = new List<Produto>();

            Produto celular1 = new Produto();
            celular1.Codigo = 1;
            celular1.Nome = "Iphone 11";
            celular1.Preco = 5000;

            produtos.Add(celular1);

            // Ou através de instâncias básicas e suas atribuições
            produtos.Add( new Produto(1, "Samsung A10", 1100.99f) );
            produtos.Add( new Produto(2, "Redmi Note 8", 1200.99f));
            produtos.Add( new Produto(3, "Iphone X", 3500.99f));
            produtos.Add( new Produto(4, "Positivo",1300.99f));
            produtos.Add( new Produto(5, "Zenfone", 1340.99f));


            // Pode-se mostrar produtos com foreach
            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Red;              
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }


            // Pode-se remover itens através de seu índice de array:
            //Linha removida da posição 1 do array: Produto(4, "Positivo", 1300.99f);
            produtos.RemoveAt(1);


            // Também pode-se remover um produto da lista usando a expressão lambda e o método RemoveAll():
            // Linha removida: Produto(1, "Samsung A10", 1100.99f)
            produtos.RemoveAll( p => p.Nome == "Samsung A10");


            foreach(Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;             
                Console.WriteLine($"R$ {p.Preco} - {p.Nome}");
                Console.ResetColor();
            }

            Produto positivo = produtos.Find(x => x.Nome == "Positivo");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine( positivo.Preco );
            Console.ResetColor();

            System.Console.WriteLine("_________________________________");
            System.Console.WriteLine("  ");

            List<Cartao> cartoes = new List<Cartao>();

            Cartao Visa = new Cartao();
            Visa.Titular = "Luanna Correia";
            Visa.Numero = 14584750f;
            Visa.Bandeira = "Visa";
            Visa.Vencimento = "22/07/2022";
            Visa.CVV = 12;

            cartoes.Add(Visa);
            
            cartoes.Add( new Cartao("Luanna Correia", 458541, "Cielo", "29/07/2024", 20));
            cartoes.Add( new Cartao("Luanna Correia", 325781, "Mastercard", "12/03/2025", 20));
            cartoes.Add( new Cartao("Luanna Correia", 012579, "AmericanExpress", "05/11/2026", 20));
            cartoes.Add( new Cartao("Luanna Correia", 954103, "Elo", "30/06/2027", 20));

            foreach(Cartao c in cartoes){
                Console.ForegroundColor = ConsoleColor.Magenta;              
                Console.WriteLine($"Luanna Correia- {c.Bandeira}");
                Console.ResetColor();
            }
        }
    }
}

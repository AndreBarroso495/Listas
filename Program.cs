using System;
using System.Collections.Generic;
using Listas.classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista
           List<Produto> produtos = new List<Produto>();

           //Adicionando produtos através de instancias com construtores
           produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
           produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
           produtos.Add(new Produto(3, "Zenfone Asus", 2522.87f ));
           produtos.Add(new Produto(4, "Samsung", 2522.87f));
           produtos.Add(new Produto(5, "Motorola G8", 2522.87f));
           


           //Ou através de instâncias básicas e suas atribuições
           Produto iphone = new Produto();
           iphone.Codigo = 6;
           iphone.Nome = "Iphone XII";
           iphone.Preco = 8952.45f;

           produtos.Add(iphone);

           //Podemos mostrar os pontos com foreach;
           foreach (Produto p in produtos)
           {
               Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
               
           }

           //Podemos remover itens através de seu índice de array;
           //Linha removida na posição 3 do array : Produto (4, "Samsung");

           produtos.RemoveAt(3);

           //Também podemos removerum produto da lista usando expressão lambda e o método removeAll;
           //Linha removida: Produto(1, "Apple watch", 3522.56f)
           produtos.RemoveAll(x => x.Nome == "Apple Watch");

           Console.WriteLine("\nLista alterada: ");
           //Checamos se foi realmente removido
           foreach (Produto p in produtos)
           {
               Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
           }

        }
    }
}

using System.Collections.Generic;
using System;

namespace POO_objetos_como_argumento.classes
{
    public class Carrinho
    {
        // 0 - Criamos uma propriedade para guardar o valor total do carrinho
        public float ValorTotal{get; set;}


        // 1 - Criamos uma lista que representará nosso carrinho
        List<Produto> carrinho = new List<Produto>();


         // 2 - Criamos o método que adiciona o produto ao carrinho, passando todo objeto como argumento
         public void AdicionarProduto(Produto produto)
         {
             carrinho.Add(produto);
         }


        // 3 - Criamos um método que remove um produto do carrinho
        public void Removerporoduto(Produto produto)
        {
            carrinho.Remove(produto);
        }


        // 4 - Podemos criar um método para listar os produtos que estão no carrinho
        public void MostrarProdutos(){
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($" {p.Codigo} Nome: {p.Nome}  - R${p.Preco}");
                    Console.ResetColor();
                }
            }
        }
        
    }
}
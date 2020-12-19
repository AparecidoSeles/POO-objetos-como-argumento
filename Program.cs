using System;
using POO_objetos_como_argumento.classes;

namespace POO_objetos_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar produto//
            Produto p1 = new Produto(1, "CD", 2.5f);
            Produto p2 = new Produto(2, "DVD", 3);
            Produto p3 = new Produto(3, "PenDrive", 30);
            Produto p4 = new Produto(4, "Cabo", 10); 
            Produto p5 = new Produto(5, "Carregador", 20);

          
            // acessar o carrinho instanciando ele//
            Carrinho carrinho = new Carrinho();

           
            
           

            //Criar Menu//

            int resposta;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Escolha a opção que deseja fazer");
                Console.ResetColor();
                Console.WriteLine("[1] - Adicionar produto ao carrinho");
                Console.WriteLine("[2] - Trocar item do carrinho ");
                Console.WriteLine("[3] - Remover item do carrinho");
                Console.WriteLine("[4] - Mostrar produtos");
                Console.WriteLine("[5] - Ver valor total da compra");
                Console.WriteLine("[0] - sair");
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:  
                        //Adicionar produtos ao carrinho//
                        carrinho.AdicionarProduto(p1);
                        carrinho.AdicionarProduto(p2);
                        carrinho.AdicionarProduto(p3);  
                        carrinho.AdicionarProduto(p4);  
                        break;

                    case 2:
                        
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        //Mostrar produtos//
                        carrinho.MostrarProdutos();
                        break;

                    case 5:
                        
                        break;

                        case 0:

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                

            }
        }
    }
}

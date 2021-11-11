using System;

namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {   
            int menuinicial;
            string parceira;
            string nomeusuario;
            int decisao;

            //cadastro de produtos
            Produto blusa_branca_p  = new Produto(1, "Blusa Branca", "Nike", 59.9f, "Branco", "P");
            Produto blusa_branca_m  = new Produto(2, "Blusa Branca", "Nike", 59.9f, "Branco", "m");
            Produto blusa_branca_g  = new Produto(3, "Blusa Branca", "Nike", 59.9f, "Branco", "g");

            Produto blusa_preta_p  = new Produto(4, "Blusa Branca", "adidas", 49.9f, "Branco", "P");
            Produto blusa_preta_m  = new Produto(5, "Blusa Branca", "adidas", 49.9f, "Branco", "m");
            Produto blusa_preta_g  = new Produto(6, "Blusa Branca", "adidas", 49.9f, "Branco", "g");
            
            Produto jaqueta_p  = new Produto(7, "Blusa Branca", "nike", 149.9f, "Branco", "P");
            Produto jaqueta_m  = new Produto(8, "Blusa Branca", "adidas", 149.9f, "Branco", "m");
            Produto jaqueta_g  = new Produto(9, "Blusa Branca", "adidas", 149.9f, "Branco", "g");

            Produto calça_m  = new Produto(10, "Blusa Branca", "nike", 49.9f, "Branco", "m");
            Produto calça_g  = new Produto(11, "Blusa Branca", "nike", 49.9f, "Branco", "g");


            //criando lista de produtos para exibir o estoque disponível
            Produto[] roupas = new Produto[3];
            roupas[0] = blusa_branca_p;
            roupas[1] = blusa_branca_m;
            roupas[2] = blusa_branca_g;

            //dando entrada dos produtos em estoque
            blusa_branca_p.EntradaProduto(2);
            blusa_branca_m.EntradaProduto(3);            
            blusa_branca_g.EntradaProduto(3);  
 
 
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\nComo gostaria de ser chamado?\n");
            //inicialização da aplicação
           
            nomeusuario = Console.ReadLine();
        
  
            Console.WriteLine("Olá " + nomeusuario + "!, você é \n");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Parceiro");
            Console.WriteLine("\nDigite uma das opções acima");


            menuinicial = int.Parse(Console.ReadLine());   

          while(menuinicial != null)
          {
            if (menuinicial == 1) // O MENU DO CLIENTE ENTRA AQUI
            {   
                Console.WriteLine("Dê uma olhadinha no nosso estoque!");
                foreach(Produto p in roupas){
                    Console.WriteLine(p.EstoqueAtual());
                }        
            }
            else if(menuinicial == 2) // O MENU DO PARCEIRO ENTRA AQUI 
            {
                Console.Write("De qual parceira você é ?\n");

                parceira = Console.ReadLine();

                    if(parceira == "nike" || parceira == "adidas")
                    {
                        Console.WriteLine("\nQue bom termos você conosco!");
                        Console.WriteLine("\nSeja bem vindo! O que gostaria de olhar?");
                        Console.WriteLine("1 - Estoque diponível");
                        Console.WriteLine("2 - Repor Estoque");
                        Console.WriteLine("3 - Sair");

                        Console.WriteLine("\nDigite uma das opções acima");
                        decisao = int.Parse(Console.ReadLine());
                            
                            if(decisao == 1)
                            {
                                Console.WriteLine("Apresentar estoque");
                            }
                            else if(decisao == 2 )
                            {
                                Console.WriteLine("Deseja repor quais produtos?");
                                Console.WriteLine("1 - Jaqueta");
                                Console.WriteLine("2 - Blusas");
                                Console.WriteLine("3 - Todos");

                                Console.WriteLine("\nDigite uma das opções acima");
                                modelo = int.Parse(Console.ReadLine());

                                if(modelo == 1)
                                {
                                    Console.WriteLine("As jaquetas foram repostas !")
                                            // Apresentar qtd atual
                                            // PARA REPOR TEM QUE TER UMA REGRA DE NÉGOCIO (se cheio n repor) !!! 
                                }
                                else if(modelo == 2)
                                {
                                    Console.WriteLine("As blusas foram repostas!")
                                            // Apresentar qtd atual
                                            // PARA REPOR TEM QUE TER UMA REGRA DE NÉGOCIO (se cheio n repor) !!! 
                                }
                                else if(modelo == 3)
                                {
                                    Console.WriteLine("Os produtos foram repostos!")
                                        // Apresentar qtd atual
                                }
                                else
                                {
                                    Console.WriteLine("Opção Inválida !!")
                                    break;
                                }

                            }
                            else if(decisao == 3)
                            {
                                Console.WriteLine("\n/////////////////////////////////////////////////////////"); 
                                Console.WriteLine("\nVocê Finalizou Atendimento, Muito Obrigado até a próxima!!\n");
                                break;
                            }
                   
                    }        
                    else if( parceira != "nike" || parceira != "adidas"){
                        Console.WriteLine("Opção Inválida");
                    }
            }                 
                   
        }
    }
}

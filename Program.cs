using System;

namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuinicial, decisao, modelo ;
            string parceira, nomeusuario;


            //cadastro de produtos
            Produto blusa_nike    = new Produto(1, "Blusa Branca", "Nike", 49.9f, "Branco", "P");
            Produto jaqueta_nike  = new Produto(2, "Blusa Branca", "Nike", 149.9f, "Branco", "P");
            Produto calça_nike    = new Produto(3, "Blusa Branca", "Nike", 49.9f, "Branco", "m");

            Produto blusa_adidas   = new Produto(4, "Blusa Branca", "Adidas", 49.9f, "Branco", "P");
            Produto jaqueta_adidas = new Produto(5, "Blusa Branca", "Adidas", 149.9f, "Branco", "P");
            Produto calça_adidas   = new Produto(6, "Blusa Branca", "Adidas", 49.9f, "Branco", "m");
            //criando lista de produtos para exibir o estoque disponível
            //Nike
            Produto[] Nike = new Produto[3];
            Nike[0] = blusa_nike;
            Nike[1] = jaqueta_nike;
            Nike[2] = calça_nike;

            Produto[] Adidas = new Produto[3];
            Adidas[0] = blusa_adidas;
            Adidas[1] = jaqueta_adidas;
            Adidas[2] = calça_adidas;

            //inicialização da aplicação
            Console.WriteLine("\nSeja Bem Vindo\n" +
                              "\nComo gostaria de ser chamado?\n");

            nomeusuario = Console.ReadLine();

            Console.WriteLine("Olá " + nomeusuario + "!, você é \n");
            Console.WriteLine("1 - Cliente");
            Console.WriteLine("2 - Parceiro");
            Console.WriteLine("\nDigite uma das opções acima");
            
            menuinicial = int.Parse(Console.ReadLine());


            while (menuinicial != 0)
            {
                if (menuinicial == 1) // O MENU DO CLIENTE ENTRA AQUI
                {   
                    ListaCompras lista = new ListaCompras();
                    int  cod, qtd, i;


                        Console.WriteLine("Ei " + nomeusuario + "dê uma olhadinha nos nossos produtos!");

                        Console.WriteLine("ADIDAS");
                        Console.WriteLine("____________________\n");
                        foreach (Produto p in Adidas)
                        {
                            Console.WriteLine(p.EstoqueAtual());
                        };
                        Console.WriteLine("Nike");
                        Console.WriteLine("____________________\n");
                        foreach (Produto p in Nike)
                        {
                            Console.WriteLine(p.EstoqueAtual());
                        };
                        Console.WriteLine("Digite o Código do produto que deseja comprar\n" +
                                           "seguido da quantidade de unidades para adicionar\n" +
                                           "os itens ao carrinho! Digite 0 à qualquer momento\n" +
                                           "para finalizar sua compra!");


                        Console.WriteLine("Codigo do produto:");
                        cod = int.Parse(Console.ReadLine());
                        
                        if (cod ==1){
                            
                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());

                            for (i=1; i<= qtd; i++){
                                lista.adicionar(blusa_nike);
                            }
                            Console.WriteLine(lista.totalizar());
                            lista.imprimelista();
                                                                                   
                        }
                        
                }
 
                else if (menuinicial == 2) // O MENU DO PARCEIRO ENTRA AQUI 
                {
                    Console.Write("De qual parceira você é ?\n");

                    parceira = Console.ReadLine();

                    if (parceira == "nike" || parceira == "adidas")
                    {
                        Console.WriteLine("\nQue bom termos você conosco!");
                        Console.WriteLine("\nSeja bem vindo! O que gostaria de olhar?");
                        Console.WriteLine("1 - Estoque diponível");
                        Console.WriteLine("2 - Repor Estoque");
                        Console.WriteLine("3 - Sair");

                        Console.WriteLine("\nDigite uma das opções acima");
                        decisao = int.Parse(Console.ReadLine());

                        if (decisao == 1)
                        {
                            Console.WriteLine("Apresentar estoque");
                        }
                        else if (decisao == 2)
                        {
                            Console.WriteLine("Deseja repor quais produtos?");
                            Console.WriteLine("1 - Jaqueta");
                            Console.WriteLine("2 - Blusas");
                            Console.WriteLine("3 - Todos");

                            Console.WriteLine("\nDigite uma das opções acima");
                            modelo = int.Parse(Console.ReadLine());

                            if (modelo == 1)
                            {
                                Console.WriteLine("As jaquetas foram repostas !");
                                // Apresentar qtd atual
                                // PARA REPOR TEM QUE TER UMA REGRA DE NÉGOCIO (se cheio n repor) !!! 
                            }
                            else if (modelo == 2)
                            {
                                Console.WriteLine("As blusas foram repostas!");
                                // Apresentar qtd atual
                                // PARA REPOR TEM QUE TER UMA REGRA DE NÉGOCIO (se cheio n repor) !!! 
                            }
                            else if (modelo == 3)
                            {
                                Console.WriteLine("Os produtos foram repostos!");
                                // Apresentar qtd atual
                            }
                            else
                            {
                                Console.WriteLine("\nOpção Inválida !!");
                                break;
                            }

                        }
                        else if (decisao == 3)
                        {
                            Console.WriteLine("\n--------------------{}--------------------");
                            Console.WriteLine("\nVocê Finalizou Atendimento, Muito Obrigado até a próxima!!\n");
                            break;
                        }

                    }
                    else if (parceira != "nike" || parceira != "adidas")
                    {
                        Console.WriteLine("Opção Inválida");
                    }
                }

            }
        }
    }
}

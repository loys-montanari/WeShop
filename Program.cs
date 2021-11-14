using System;

namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuinicial, decisao, modelo;
            string parceira, nomeusuario;


            //cadastro de produtos
            Produto blusa_adidas   = new Produto(1, "Blusa Preta DryFit", "Adidas", 49.9f, "Preto", "P");
            Produto jaqueta_adidas = new Produto(2, "Jaqueta Corta Vento Azul", "Adidas", 149.9f, "Azul", "P");
            Produto calça_adidas   = new Produto(3, "Calça Cinza", "Adidas", 49.9f, "Cinza", "m");
            
            Produto blusa_nike     = new Produto(4, "Blusa Branca", "Nike", 49.9f, "Branco", "P");
            Produto jaqueta_nike   = new Produto(5, "Jaqueta Moletom Preta", "Nike", 149.9f, "Preto", "P");
            Produto calça_nike     = new Produto(6, "Calça Jogger", "Nike", 49.9f, "Azul", "m");

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

            blusa_adidas.EntradaProduto(1);
            jaqueta_adidas.EntradaProduto(1);
            calça_adidas.EntradaProduto(1);
            blusa_nike.EntradaProduto(2);
            jaqueta_nike.EntradaProduto(3);
            calça_nike.EntradaProduto(3);

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
                    int cod, qtd, i, menucompra;


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
                                       "para finalizar sua compra!\n");

                    do
                    {

                        menucompra = 1;

                        Console.WriteLine("Codigo do produto:");
                        cod = int.Parse(Console.ReadLine());

                        if (cod == 1)      //blusa_adidas
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (blusa_adidas.getDisponivel() - qtd >= 0)
                            {
                                blusa_adidas.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(blusa_adidas);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (blusa_adidas.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", blusa_adidas.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, blusa_adidas.getProduto(), blusa_adidas.getDisponivel());
                            }
                        }
                        else if (cod == 2) //jaqueta_adidas
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (jaqueta_adidas.getDisponivel() - qtd >= 0)
                            {
                                jaqueta_adidas.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(jaqueta_adidas);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (jaqueta_adidas.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", jaqueta_adidas.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, jaqueta_adidas.getProduto(), jaqueta_adidas.getDisponivel());
                            }

                        }
                        else if (cod == 3) //calça_adidas
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (calça_adidas.getDisponivel() - qtd >= 0)
                            {
                                calça_adidas.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(calça_adidas);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (calça_adidas.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", calça_adidas.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, calça_adidas.getProduto(), calça_adidas.getDisponivel());
                            }
                        }
                        else if (cod == 4) //blusa_nike
                        {


                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (blusa_nike.getDisponivel() - qtd >= 0)
                            {
                                blusa_nike.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(blusa_nike);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (blusa_nike.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", blusa_nike.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, blusa_nike.getProduto(), blusa_nike.getDisponivel());
                            }
                        }
                        else if (cod == 5) //jaqueta_nike
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (jaqueta_nike.getDisponivel() - qtd >= 0)
                            {
                                jaqueta_nike.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(jaqueta_nike);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (jaqueta_nike.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", jaqueta_nike.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, jaqueta_nike.getProduto(), jaqueta_nike.getDisponivel());
                            }

                        }
                        else if (cod == 6) //calça_nike
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());
                            
                            if (calça_nike.getDisponivel() - qtd >= 0)
                            {
                                calça_nike.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(calça_nike);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: " + lista.totalizar());
                                Console.WriteLine("1 - Adicionar mais itens");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (calça_nike.getDisponivel() == 0){
                                Console.WriteLine("Poxa, não temos mais {0}!", calça_nike.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, calça_nike.getProduto(), calça_nike.getDisponivel());
                            }

                        }
                    } while (menucompra == 1);

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

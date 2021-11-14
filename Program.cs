using System;

namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuinicial, decisao, modelo, qtd;
            string parceira, nomeusuario;


            //cadastro de produtos
            Produto blusa_adidas   = new Produto(1, "Blusa Preta DryFit", "Adidas", 49.9f, "Preto", "P","arquivos/blusa_adidas.txt");
            Produto jaqueta_adidas = new Produto(2, "Jaqueta Corta Vento Azul", "Adidas", 149.9f, "Azul", "P","arquivos/jaqueta_adidas.txt");
            Produto calca_adidas   = new Produto(3, "Calça Cinza", "Adidas", 49.9f, "Cinza", "m","arquivos/calca_adidas.txt");

            Produto blusa_nike     = new Produto(4, "Blusa Branca", "Nike", 49.9f, "Branco", "P","arquivos/blusa_nike.txt");
            Produto jaqueta_nike   = new Produto(5, "Jaqueta Moletom Preta", "Nike", 149.9f, "Preto", "P","arquivos/jaqueta_nike.txt");
            Produto calca_nike     = new Produto(6, "Calça Jogger", "Nike", 49.9f, "Azul", "m","arquivos/calca_nike.txt");

            //criando lista de produtos para exibir o estoque disponível
            //Nike
            Produto[] Nike = new Produto[3];
            Nike[0] = blusa_nike;
            Nike[1] = jaqueta_nike;
            Nike[2] = calca_nike;

            Produto[] Adidas = new Produto[3];
            Adidas[0] = blusa_adidas;
            Adidas[1] = jaqueta_adidas;
            Adidas[2] = calca_adidas;

            blusa_adidas.setQuantidade();
            jaqueta_adidas.setQuantidade();
            calca_adidas.setQuantidade();
            blusa_nike.setQuantidade();
            jaqueta_nike.setQuantidade();
            calca_nike.setQuantidade();

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
                    int cod,  i, menucompra;


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
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (blusa_adidas.getDisponivel() == 0)
                            {
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
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (jaqueta_adidas.getDisponivel() == 0)
                            {
                                Console.WriteLine("Poxa, não temos mais {0}!", jaqueta_adidas.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, jaqueta_adidas.getProduto(), jaqueta_adidas.getDisponivel());
                            }

                        }
                        else if (cod == 3) //calca_adidas
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());

                            if (calca_adidas.getDisponivel() - qtd >= 0)
                            {
                                calca_adidas.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(calca_adidas);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (calca_adidas.getDisponivel() == 0)
                            {
                                Console.WriteLine("Poxa, não temos mais {0}!", calca_adidas.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, calca_adidas.getProduto(), calca_adidas.getDisponivel());
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
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (blusa_nike.getDisponivel() == 0)
                            {
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
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (jaqueta_nike.getDisponivel() == 0)
                            {
                                Console.WriteLine("Poxa, não temos mais {0}!", jaqueta_nike.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, jaqueta_nike.getProduto(), jaqueta_nike.getDisponivel());
                            }

                        }
                        else if (cod == 6) //calca_nike
                        {

                            Console.WriteLine("Quantidade:");
                            qtd = int.Parse(Console.ReadLine());

                            if (calca_nike.getDisponivel() - qtd >= 0)
                            {
                                calca_nike.SaidaProduto(qtd);

                                for (i = 1; i <= qtd; i++)
                                {
                                    lista.adicionar(calca_nike);
                                }
                                lista.imprimelista();
                                Console.WriteLine("Total: R${0:0.00}", lista.totalizar());
                                Console.WriteLine("1 - Continuar comprando");
                                Console.WriteLine("2 - Finalizar Compra");
                                menucompra = int.Parse(Console.ReadLine());
                            }
                            else if (calca_nike.getDisponivel() == 0)
                            {
                                Console.WriteLine("Poxa, não temos mais {0}!", calca_nike.getProduto());
                            }
                            else
                            {
                                Console.WriteLine("Poxa, não temos {0} {1}, escolha uma quantidade entre 0 e {2}!", qtd, calca_nike.getProduto(), calca_nike.getDisponivel());
                            }

                        }

                    } while (menucompra == 1);

                    Console.WriteLine("\nObrigada por comprar conosco, {0}!", nomeusuario);
                    Console.WriteLine("Seu pedido foi finalizado\n");
                    lista.imprimelistafinal();
                    Console.WriteLine("Total da compra: R${0:0.00}\n", lista.totalizar());
                    menuinicial = 0;
                }

                else if (menuinicial == 2) // O MENU DO PARCEIRO ENTRA AQUI 
                {   string menuparceiro;

                    Console.WriteLine("De qual parceira você é ?\n");
                    Console.WriteLine("Nike");
                    Console.WriteLine("Adidas\n");
                    parceira = Console.ReadLine().ToLower();

                    if (parceira == "nike" || parceira == "adidas")// menu parceiro
                    {
                        Console.WriteLine("\nQue bom termos você conosco!");
                        Console.WriteLine("\nSeja bem vindo! O que gostaria de olhar?");
                        Console.WriteLine("1 - Estoque atual");
                        Console.WriteLine("2 - Repor Mercadorias");
                        Console.WriteLine("3 - Sair");

                        Console.WriteLine("\nDigite uma das opções acima");
                        decisao = int.Parse(Console.ReadLine());
                        
                        do{
                        if (decisao == 1) //estoque disponivel
                        {
                            Console.WriteLine("Estoque Atual!\n");
                            if (parceira == "nike")
                            {
                                Console.WriteLine("Nike");
                                Console.WriteLine("____________________\n");
                                foreach (Produto p in Nike)
                                {
                                    Console.WriteLine(p.EstoqueAtual());
                                };
                            }
                            else if (parceira == "adidas"){
                               
                                Console.WriteLine("Adidas");
                                Console.WriteLine("____________________\n");
                                foreach (Produto p in Adidas)
                                {
                                    Console.WriteLine(p.EstoqueAtual());
                                }; 
                            }
                            Console.WriteLine("Gostaria de repor alguma mercadoria? (S/N)");
                            menuparceiro = Console.ReadLine().ToLower();
                           
                            if (menuparceiro == "s"){
                                decisao = 2;
                            }
                            else if (menuparceiro == "n"){
                                decisao = 3;
                            }
                        }
                        else if (decisao == 2) //repor mercadoria
                        {
                            Console.WriteLine("Deseja repor quais produtos?");
                            Console.WriteLine("1 - Blusa");
                            Console.WriteLine("2 - Jaqueta");
                            Console.WriteLine("3 - calca");
                            Console.WriteLine("4 - Todos");
                            Console.WriteLine("\nDigite uma das opções acima");
                            modelo = int.Parse(Console.ReadLine());

                            if (modelo == 1)      //blusas
                            {   
                                Console.WriteLine("Quantas blusas deseja adicionar ao estoque?");
                                qtd = int.Parse(Console.ReadLine());
                                switch (parceira){

                                    case "nike": blusa_nike.EntradaProduto(qtd);
                                    break;
                                    case "adidas": blusa_adidas.EntradaProduto(qtd);
                                    break;
                                } 
                                    Console.WriteLine("{0} Blusas adicionadas com sucesso!\n", qtd);
                                    decisao = 1;                         
                            }
                            else if (modelo == 2) //jaquetas
                            {
                                Console.WriteLine("Quantas jaquetas deseja adicionar ao estoque?");
                                qtd = int.Parse(Console.ReadLine());
                                switch (parceira){

                                    case "nike": jaqueta_nike.EntradaProduto(qtd);
                                    break;
                                    case "adidas": jaqueta_adidas.EntradaProduto(qtd);
                                    break;
                                } 
                                    Console.WriteLine("{0} jaquetas adicionadas com sucesso!\n", qtd);
                                    decisao = 1; 
                            }
                            else if (modelo == 3) //calças
                            {
                                Console.WriteLine("Quantas calças deseja adicionar ao estoque?");
                                qtd = int.Parse(Console.ReadLine());
                                switch (parceira){

                                    case "nike": calca_nike.EntradaProduto(qtd);
                                    break;
                                    case "adidas": calca_adidas.EntradaProduto(qtd);
                                    break;
                                } 
                                    Console.WriteLine("{0} calças adicionadas com sucesso!\n", qtd);
                                    decisao = 1; 
                            }
                            else if (modelo == 4) //Todos
                            {
                                Console.WriteLine("Quantas preças de cada produto deseja adicionar ao estoque?");
                                qtd = int.Parse(Console.ReadLine());
                                switch (parceira){

                                    case "nike": 
                                    blusa_nike.EntradaProduto(qtd);
                                    jaqueta_nike.EntradaProduto(qtd);
                                    calca_nike.EntradaProduto(qtd);
                                    break;
                                    case "adidas": 
                                    blusa_adidas.EntradaProduto(qtd);
                                    jaqueta_adidas.EntradaProduto(qtd);
                                    calca_adidas.EntradaProduto(qtd);
                                    break;
                                } 
                                    Console.WriteLine("{0} Blusas\n"+
                                                      "{0} Jaquetas\n"+
                                                      "{0} Calças\n"+
                                                      "adicionados ao estoque com sucesso!\n", qtd);
                                    decisao = 1; 
                            }                            
                            else
                            {
                                Console.WriteLine("\nDigite uma opção válida !!");
                                modelo = int.Parse(Console.ReadLine());
                            }

                        }
                        else if (decisao == 3) //finalizar atendimento
                        {
                            Console.WriteLine("\n--------------------{}--------------------");
                            Console.WriteLine("\nVocê Finalizou Atendimento, Muito Obrigado até a próxima!!\n");
                            break;
                        }
                            menuinicial = 0;
                        } while (decisao !=0);
                    }
                    else if (parceira != "nike" || parceira != "adidas")// parceiro inválido
                    {
                        Console.WriteLine("Digite uma opção válida!");
                        parceira = Console.ReadLine();
                    }
                }
                menuinicial = 0;

            }
        }
    }
}

using System;

namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {   
            int menuinicial;
            string nomeusuario;

            //cadastro de produtos
            Produto blusa_branca_p  = new Produto(1, "Blusa Branca", "Nike", 59.9f, "Branco", "P");
            Produto blusa_branca_m  = new Produto(2, "Blusa Branca", "Nike", 59.9f, "Branco", "m");
            Produto blusa_branca_g  = new Produto(3, "Blusa Branca", "Nike", 59.9f, "Branco", "g");


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
        
  
            Console.WriteLine("\nEi {0}, você é nosso\n"+
                              "1 - Cliente!\n"+
                              "2 - Parceiro!\n", nomeusuario);

            menuinicial = int.Parse(Console.ReadLine());   

            if (menuinicial == 1)
            {
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\nDigite a opção desejada!\n"+
                              "1 - Quero Comprar roupas!\n"+
                              "2 - Quero comprar calçados!");
                
            }                         
            else if (menuinicial == 2) {

            


            }
            else if (menuinicial != 1 && menuinicial != 2){

                
            }



            //imprime o estoque
            foreach(Produto p in roupas){
                Console.WriteLine(p.EstoqueAtual());
            }                      
        }
    }
}

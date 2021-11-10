using System;



namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {   
            int menuinicial;

            //cadastro de produtos
            Produto blusa_branca_p = new Roupa(1, "Blusa Branca", "Nike", 59.9f, "P", "Blusas e Camisetas", "Branco");
            Produto blusa_branca_m = new Roupa(2, "Blusa Branca", "Nike", 59.9f, "m", "Blusas e Camisetas", "Branco");
            Produto blusa_branca_g = new Roupa(3, "Blusa Branca", "Nike", 59.9f, "g", "Blusas e Camisetas", "Branco");


            //criando lista de produtos para exibir o estoque disponível
            Produto[] roupas = new Produto[3];
            roupas[0] = blusa_branca_p;
            roupas[1] = blusa_branca_m;
            roupas[2] = blusa_branca_g;

            //dando entrada dos produtos em estoque
            blusa_branca_p.EntradaProduto(2);
            blusa_branca_m.EntradaProduto(3);            
            blusa_branca_g.EntradaProduto(3);  

            //inicialização da aplicação
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\nDigite a opção desejada!\n"+
                              "1 - Sou Cliente!\n"+
                              "2 - Sou Parceiro!\n");

            menuinicial = int.Parse(Console.ReadLine());   

            if (menuinicial == 1)
            {
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\nDigite a opção desejada!\n"+
                              "1 - Quero Comprar roupas!\n"+
                              "2 - Quero comprar calçados!");
                
            }                         
            
            //imprime o estoque
            foreach(Produto p in roupas){
                Console.WriteLine(p.EstoqueAtual());
            }                      
        }
    }
}

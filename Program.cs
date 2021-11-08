using System;



namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //cadastro de produtos
            Produto blusa_branca_p = new Roupa("Blusa UCL", "AleClothing", 59.9f, "P", "Blusas e Camisetas", "Branco");
            Produto blusa_preta_p = new Roupa( "Blusa UCL", "AleClothing", 59.9f, "P", "Blusas e Camisetas", "Preto");
            
            //criando lista de produtos para exibir o estoque disponível
            Produto[] roupas = new Produto[2];
            roupas[0] = blusa_branca_p;
            roupas[1] = blusa_preta_p;

            //dando entrada dos produtos em estoque
            blusa_branca_p.EntradaProduto(2);
            blusa_preta_p.EntradaProduto(3);            

            //inicialização da aplicação
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\n"+"Produtos Disponíveis\n");
            
            //imprime o estoque
            foreach(Produto p in roupas){
                Console.WriteLine(p.EstoqueAtual());
            }                      
        }
    }
}

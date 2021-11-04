using System;



namespace WeShop
{
    class Program
    {
        static void Main(string[] args)
        {

            //cadastro de produtos
            Produto blusaucl_branca_p = new Roupa(1, "Blusa UCL", "AleClothing", 59.9f, "P", "Blusas e Camisetas", "Branco");
            Produto blusaucl_preta_p = new Roupa(1, "Blusa UCL", "AleClothing", 59.9f, "P", "Blusas e Camisetas", "Preto");
            
            //criando lista de produtos para exibir o estoque disponível
            Produto[] roupas = new Produto[2];
            roupas[0] = blusaucl_branca_p;
            roupas[1] = blusaucl_preta_p;

            //dando entrada dos produtos em estoque
            blusaucl_branca_p.EntradaEstoque(2);
            blusaucl_preta_p.EntradaEstoque(3);            

            //inicialização da aplicação
            Console.WriteLine("\nSeja Bem Vindo\n"+
                              "\n"+"Estoque Disponível\n");
            //imprime o estoque
            foreach(Produto p in roupas){
                Console.WriteLine(p.EstoqueAtual());
            }
            
            

        }
    }
}

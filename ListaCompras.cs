using System.Collections.Generic;
using System;
namespace WeShop
{
    public class ListaCompras
    {
        private List<Produto> lista = new List<Produto>();

        public void adicionar(Produto produto)
        { 
            lista.Add(produto);
        }
        public double totalizar()
        {
            double total = 0;
            for(int i=0; i < lista.Count; i++)
            {
                total = total + lista[i].valor;
            }

            return total;
        }
        public void imprimelista(){
            
            Console.WriteLine("\nCarrinho de Compras!");
            Console.WriteLine("____________________\n");

            foreach (var Produto in lista){
                
                Console.WriteLine(Produto.produtocarrinho());
            }
        }
        public void imprimelistafinal(){
            
            foreach (var Produto in lista){
                
                Console.WriteLine(Produto.produtocarrinho());
            }
             Console.WriteLine("____________________\n");
        }
    }
}

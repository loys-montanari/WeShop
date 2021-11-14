using System;
using WeShop;
    public class Produto
    {   
        private int codproduto;
        private string descricao;
        private string marca;
        private int quantidadedisponivel;
        public float valor;
       private string cor;
       private string tamanho;     
        public Produto( int cod, string desc, string m, float val, string c, string tam){ 
          
          codproduto = cod;
          descricao = desc;
          marca = m;
          quantidadedisponivel = 0;
          valor = val;
          cor = c;
          tamanho = tam;

        }
        public string getProduto(){
            return descricao;
        }
         public int getDisponivel(){
            return quantidadedisponivel;
        }       
        public void EntradaProduto(int qtd){             
            quantidadedisponivel = quantidadedisponivel + qtd;
        }      
        public string EstoqueAtual(){

            string estoque = string.Format("Codigo:     {0}\n"+
                                           "Produto:    {1}\n"+
                                           "Marca:      {2}\n"+
                                           "Tamanho:    {3}\n"+
                                           "Unidades:   {4}\n"+
                                           "_________________________\n"+
                                           "\n", codproduto, descricao, marca, tamanho, quantidadedisponivel);

                                           return estoque;
        }    
    
        public string produtocarrinho(){

            string prodcarrinho = (descricao+"  R$"+ valor);
            return prodcarrinho;
        }
        
        public void SaidaProduto(int qtd){
             quantidadedisponivel = quantidadedisponivel - qtd;

       }
    }

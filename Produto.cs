using System;
using WeShop;
using System.Collections.Generic;
using System.IO;
using System.Text;
    public class Produto
    {   
        private int codproduto;
        private string descricao;
        private string marca;
        private int quantidadedisponivel;
        public float valor;
        private string cor;
        private string tamanho;     
        private string arquivo;
        public Produto( int cod, string desc, string m, float val, string c, string tam, string arqv){ 
          
          codproduto = cod;
          descricao = desc;
          marca = m;
          quantidadedisponivel = 0;
          valor = val;
          cor = c;
          tamanho = tam;
          arquivo = arqv;

        }
        public string getProduto(){
            return descricao;
        }
         public int getDisponivel(){
            return quantidadedisponivel;
        }
        public void setQuantidade(){
            FileStream meuArq = new FileStream(arquivo, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);

                int str = Convert.ToInt16(sr.ReadLine());
                

            sr.Close();
            meuArq.Close();

            quantidadedisponivel = str;            
        }       
        public void EntradaProduto(int qtd){             
            quantidadedisponivel = quantidadedisponivel + qtd;
            FileStream meuArq = new FileStream( arquivo , FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);

            int valor = quantidadedisponivel;
            sw.WriteLine(valor);
            
            sw.Close();
            meuArq.Close();
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
            FileStream meuArq = new FileStream( arquivo , FileMode.Open, FileAccess.Write);

            StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);

            int valor = quantidadedisponivel;
            sw.WriteLine(valor);
            
            sw.Close();
            meuArq.Close();
    }
    }

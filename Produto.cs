
    public class Produto
    {
        private int CodigoProduto;
        private string Descricao;
        private string Marca;
        private int QuantidadeDisponivel;
        public float Valor;

        public Produto(int cod, string desc, string marca, float val ){ 
          
          CodigoProduto = cod;
          Descricao = desc;
          Marca = marca;
          QuantidadeDisponivel = 0;
          Valor = val;

        }

        public string getProduto(){
            return Descricao;
        }

         public int getDisponivel(){
            return QuantidadeDisponivel;
        }       

        public void EntradaEstoque(int qtd){             
            QuantidadeDisponivel = QuantidadeDisponivel + qtd;
        }
        
        public string EstoqueAtual(){

            string estoque = string.Format("Produto:   {0}\n"+
                                           "Marca:      {1}\n"+
                                           "Unidades:   {2}\n"+
                                           "_______________\n"+
                                           "\n", Descricao, Marca, QuantidadeDisponivel);

                                           return estoque;
        }
        
        
    }

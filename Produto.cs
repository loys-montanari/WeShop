
    public class Produto
    {
        private string Descricao;
        private string Marca;
        private int QuantidadeDisponivel;
        public float Valor;
        public string Tamanho { get; set; }
        public Produto( string desc, string marca, float val ){ 
          
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
        public void EntradaProduto(int qtd){             
            QuantidadeDisponivel = QuantidadeDisponivel + qtd;
        }      
        public string EstoqueAtual(){

            string estoque = string.Format("Produto:    {0}\n"+
                                           "Marca:      {1}\n"+
                                           "Unidades:   {2}\n"+
                                           "_________________________\n"+
                                           "\n", Descricao, Marca, QuantidadeDisponivel);

                                           return estoque;
        }
        
        
    }

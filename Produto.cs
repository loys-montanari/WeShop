namespace WeShop.obj
{
    public class Produto
    {
        private int CodigoProduto { get; set; }
        private string Descricao { get; set; }
        private string Marca { get; set; }
        private int QuantidadeDisponivel { get; set;}
        public float Valor { get; set; }

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
            QuantidadeDisponivel =QuantidadeDisponivel + qtd;
        }
        
    }
}
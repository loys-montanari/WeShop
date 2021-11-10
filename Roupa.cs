using WeShop;


class Roupa : Produto
{

    private string Categoria;     
    private string Cor;

    public Roupa(int cod, string desc, string marca, float val, string tam, string ct, string c):
    base( cod, desc, marca, val)
    {
          tamanho = tam;
          Categoria = ct;  
          Cor = c;
    }
    
    
} 
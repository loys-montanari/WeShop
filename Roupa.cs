using WeShop;


class Roupa : Produto
{
    private string Tamanho;
    private string Categoria;     
    private string Cor;

    public Roupa(string desc, string marca, float val, string tam, string ct, string c):
    base( desc, marca, val)
    {
          Tamanho = tam;
          Categoria = ct;  
          Cor = c;
    }
    
    
} 
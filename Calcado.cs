using WeShop;


class Calcado : Produto
{
    private string Tipo; 
    private string Cor;

    public Calcado( int cod, string desc, string marca, float val, string tam, string tp, string c):
    base( cod, desc, marca, val)
    {
          tamanho = tam;
          Tipo = tp;  
          Cor = c;
    }
    
    
} 
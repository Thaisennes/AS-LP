//Classe biblioteca
public class Biblioteca
{
    //Criando lista coleção
    List<ItemBiblioteca> Colecao;

    public Biblioteca()
    {
        Colecao = new List<ItemBiblioteca>();
    }

    //Adicionar item
    public void AdicionarLivro(ItemBiblioteca livro)
    {
        Colecao.Add(livro);
    }

    //Remover item
    public void RemoverLivro(ItemBiblioteca livro)
    {
        Colecao.Remove(livro);
    }

    //Buscar por título
    public ItemBiblioteca BuscarTitulo(string titulo)
    {
        return Colecao.Find(livro => livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    //Buscar por ID
    public ItemBiblioteca BuscarId(int id)
    {
        return Colecao.Find(livro => livro.Id == id);
    }
}


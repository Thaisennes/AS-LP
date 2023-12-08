//Classe base ItemBiblioteca
public abstract class ItemBiblioteca
{
    public int Id { get; }
    public string Titulo { get; }
    protected string DescricaoLivro { get; set; } 

    //Construtor
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoLivro = "(Descrição do livro)";
    }

    //Metodo para DescricaoInterna
    public abstract void ExibirDescricaoLivro();
}
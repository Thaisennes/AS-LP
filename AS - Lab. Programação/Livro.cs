//Herança de classe
public class Livro : ItemBiblioteca
{
    //Adicionando atributo Autor
    public string Autor { get; }

    //Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor; 
    }

    //Construtor
       public Livro(int id, string titulo, string autor, string descricaoLivro) : base(id, titulo)
    {
        DescricaoLivro = descricaoLivro;
    }

    // Implementação do método ExibirDescricaoLivro
    public override void ExibirDescricaoLivro()
    {
        Console.WriteLine($"Descrição do Livro '{Titulo}', {Autor}");
    }
}

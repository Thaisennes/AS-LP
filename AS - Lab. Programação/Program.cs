
Biblioteca Biblioteca = new Biblioteca();

//Instanciando os livros
Livro livro1 = new Livro(1, "Orgulho e Preconceito", "Jane Austen");
Livro livro2 = new Livro(2, "O Código Da Vinci", "Dan Brown");
Livro livro3 = new Livro(3, "Harry Potter", "J.K. Rowling");
Livro livro4 = new Livro(4, "O Que O Sol Faz Com As Flores", "Rupi Kaur");

//Adicionando livros
Biblioteca.AdicionarLivro(livro1);
Biblioteca.AdicionarLivro(livro2);
Biblioteca.AdicionarLivro(livro3);
Biblioteca.AdicionarLivro(livro4);

Console.WriteLine("Para buscar livro por:\nTítulo - 1 \nId - 2");
int escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    //Buscar por título
    Console.Write("\nDigite o titulo do livro: ");
    string buscarTitulo = Console.ReadLine();
    ItemBiblioteca livroEncontradoTit = Biblioteca.BuscarTitulo(buscarTitulo);

    //Verificar se o livro é existente
    if (livroEncontradoTit != null)
    {
        Console.WriteLine($"\nLivro [{buscarTitulo}] encontrado nessa biblioteca.");
        livroEncontradoTit.ExibirDescricaoLivro();
    }
    else
    {
        Console.WriteLine($"\nLivro [{buscarTitulo}] não encontrado nessa biblioteca.");
    }   
}
else if (escolha == 2)
{
    //Buscar por ID
    Console.WriteLine("\nDigite o ID do livro: ");
    int buscarId = Convert.ToInt32(Console.ReadLine());
    ItemBiblioteca livroEncontradoId = Biblioteca.BuscarId(buscarId);

    //Verificar se o livro é existente
    if (livroEncontradoId != null) 
    {
        Console.WriteLine($"\nLivro [{buscarId}] encontrado nessa biblioteca.");
        livroEncontradoId.ExibirDescricaoLivro(); 
    }
    else
    {
        Console.WriteLine($"\nLivro [{buscarId}] não encontrado nessa biblioteca.");
    }
}
// See https://aka.ms/new-console-template for more information
public static class Program
{

    static void Main(string[] args)
    {

        Repository repo = new Repository();
        Library lib = new Library();

        foreach (var book in repo.GetAllBooks())
        {
            lib.AddBook(book);
        }

        repo.books.ForEach(book => Console.WriteLine(book.Title));

        lib.DisplayBooks();
        lib.SortBooks();

        while (true)
        {
            Console.WriteLine("zadej jméno autora");
           
            string nameOfAuthor = Console.ReadLine();
           
            var input = nameOfAuthor.ToLower();

            if (!string.IsNullOrEmpty(input))
            {
                
                lib.FindBookWithAuthor(input);
               break;
            }
            else
            {
                Console.WriteLine("Nebyl zadán žádný autor");
                Console.WriteLine("Chcete zadat autora znovu? (ano/ne)");   
                string answer = Console.ReadLine();
                if (answer == "ne")
                {
                    break;
                }
            }
        }
        Console.WriteLine("zadej první písmeno názvu knihy");
        char letter = Console.ReadKey().KeyChar;
        lib.FindTitleWithLetter(letter);


        Console.WriteLine("zadej název knihy");
        var nameOfBook = Console.ReadLine();
        if (string.IsNullOrEmpty(nameOfBook))
        {
            Console.WriteLine("Nebyl zadán žádný název knihy");
            return;
        }   
        var input1 = nameOfBook.ToLower();
                 
        lib.FindBookWithTitle(input1);

    }

    
}



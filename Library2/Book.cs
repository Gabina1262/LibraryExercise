// See https://aka.ms/new-console-template for more information
public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(Guid id, string title, string author, int year)
    {
        Id = id;
        Title = title;
        Author = author;
        Year = year;

    }
}

public class Repository
{
    public List<Book> books;

    public Repository()
    {
        books = new List<Book>
        {
            new Book(Guid.NewGuid(), "The Hobbit", "J.R.R. Tolkien", 1937),
            new Book(Guid.NewGuid(), "The Two Towers", "J.R.R. Tolkien", 1954),
            new Book
              (Guid.NewGuid(),
                  "The Return of the King",
                   "J.R.R. Tolkien",
                  1955),
            new Book
           (
                Guid.NewGuid(),
                "The Lion, the Witch and the Wardrobe",
                "C.S. Lewis",
                1950
           ),
            new Book
            (
                Guid.NewGuid(),
                "The Voyage of the Dawn Treader",
                "C.S. Lewis",
                1952
            )
        }
        ;

    }


    public List<Book> GetAllBooks()
    {
        return books;
    }
}





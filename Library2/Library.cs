// See https://aka.ms/new-console-template for more information
public class Library
{
    public List<Book> books;
    public Library()
    {
        books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }
    public void DisplayBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }
    public void SortBooks()
    {
        books = books.OrderByDescending(x => x.Year)
       .ThenBy(x => x.Title)
              .ToList();

        Console.WriteLine("Books sorted by Year and Author:");
        foreach (var book in books)
        {
            Console.WriteLine($" {book.Year}, {book.Author}");
        }
    }

    public void FindBookWithAuthor(string author)
    {
        author = author.ToLower();
        var machingBooks = books
                 .Where(x => x.Author.ToLower().Contains(author))
                 .ToList();

        if (machingBooks.Count > 0)
        {
            Console.WriteLine($"Books with author {author}:");
            foreach (var book in machingBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }

        }
        else
        {
            Console.WriteLine($"No books found with author {author}");
        }
    }

    public void FindTitleWithLetter(char letter)
    {
        char input = char.ToUpper(letter);
        var machingBooks = books
                 .Where(x => x.Title.ToUpper().StartsWith(input));
        Console.WriteLine($"Books with title starting with {input}:");
        foreach (var book in machingBooks)
        {
            Console.WriteLine($" {book.Title}:");
        }
    }

    public void FindBookWithTitle(string title)
    {
        title = title.ToLower();
        var machingBooks = books
                 .Where(x => x.Title.ToLower().Contains(title))
                 .ToList();
        if (machingBooks.Count > 0)
        {
            Console.WriteLine($"Books with author {title}:");
            foreach (var book in machingBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
            }
        }
        else
        {
            Console.WriteLine($"No books found with author {title}");
        }
    }
}






using App1;
using (var context = new DataContext())
{
    var author = new Author
    {
        FirstName = "William",
        LastName = "Shakespeare",
        Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
    };
    context.Add(author);
    context.SaveChanges();
}

var mycontext = new DataContext();
var books = mycontext.Books.ToList();

foreach(Book book in books){
    Console.WriteLine(book.Title);
}

Console.WriteLine("Hello, World!");

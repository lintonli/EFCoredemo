// See https://aka.ms/new-console-template for more information
using EFCoredemo.EFCoreDBContext;
using EFCoredemo.EntityModels;

Console.WriteLine("Hello, World!");
//1to1
/*try
{
    using EFDBContext context = new EFDBContext();
    var Book = new Book()
    {
        Title = "Intro to EF Core",
        Description = "Dotnet relationships"

    };
    var Author = new Author()
    {
        Name = "Kelvin",
        book = Book

    };

    context.Authors.Add(Author);
    
    context.SaveChanges();
    Console.WriteLine("Author and Book Added");
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}*/

//one to many

/*try
{
    using var context = new EFDBContext();
    var books = new List<Book>
    {
        new Book() { Title="river and the source", Description="The Girl Child"},
        new Book(){ Title="Betrayal in the City", Description="Neocolonialism"},
    };
    var author = new Author()
    {
        Name = "Linton",
        Books = books,
    };
    context.Authors.Add(author);
    context.SaveChanges();
    Console.WriteLine("Author and Books added");

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}*/

try
{
    using var context = new EFDBContext();
    var Books = new List<Book>
    {
        new Book() { Title = "Blossoms", Description = "Heritage" },
        new Book() { Title = "River Between", Description = "Politics" },
    };
    context.Books.AddRange(Books);
    context.SaveChanges();
    Console.WriteLine("Books Added");

    var Edi = new Author() { Name = "Edimund", Books = Books };
    context.Authors.Add(Edi);
    var Nge = new Author() { Name = "Ngeiywa", Books = Books };
    context.Authors.Add(Nge);
    context.SaveChanges();
    Console.WriteLine("Authors Added");
   
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}"); ;
}

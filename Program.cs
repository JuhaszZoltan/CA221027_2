namespace CA221027_2
{
    internal class Program
    {
        static void Main()
        {
            Book book = new();
            BadBookShelf shelf = new();

            shelf.Add(book);

            (shelf as List<Book>).Add(book);
            (shelf as List<Book>).Add(null);
            Console.WriteLine(shelf.Count);
        }
    }
}
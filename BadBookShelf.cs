namespace CA221027_2
{
    internal class BadBookShelf : List<Book>
    {
        public new void Add(Book book)
        {
            if (book == null)
                throw new Exception("error");
            if (this.Contains(book))
                throw new Exception("error");
            base.Add(book);
        }
    }
}

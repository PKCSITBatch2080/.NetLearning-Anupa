public abstract class Book
{
    public string Title { get; set; }
    public string Author { get; }
    protected bool _isAvailable;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        _isAvailable = true;
    }

    public abstract void BorrowBook();
}
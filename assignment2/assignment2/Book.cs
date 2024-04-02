public abstract class Book
{
    public string Title { get; set; }//property
    public string Author { get; }//property :read only
    protected bool _isAvailable;//field

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        _isAvailable = true;
    }

    public abstract void BorrowBook();
}
public class PhysicalBook : Book
{
    public PhysicalBook(string title, string author) : base(title, author)
    {
    }

    public override void BorrowBook()
    {
        // Implement physical book-specific borrowing logic here
    }
}
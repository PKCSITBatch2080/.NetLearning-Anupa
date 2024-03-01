using System;

namespace LibraryManagementSystem
{
    public class EBook : Book, ILendableItem
    {
        public string Format { get; set; }

        public EBook(string title, string author, string format) : base(title, author)
        {
            Format = format;
        }

        public void LendItem()
        {
            // Implement eBook-specific lending logic here
        }

        public void ReturnItem(DateTime returnedDate)
        {
            // Implement eBook-specific returning logic here
        }

        public override void BorrowBook()
        {
            // Implement eBook-specific borrowing logic here
        }
    }
}
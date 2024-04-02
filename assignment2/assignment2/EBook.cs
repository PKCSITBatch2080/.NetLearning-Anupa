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
            
        }

        public void ReturnItem(DateTime returnedDate)
        {
            
        }

        public override void BorrowBook()
        {
            
        }
    }
}
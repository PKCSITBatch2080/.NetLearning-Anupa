using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Library : ILendableItem
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void BorrowBook(string title)
        {
            var bookToBorrow = _books.Find(book => book.Title == title);

            if (bookToBorrow != null)
            {
                bookToBorrow.BorrowBook();
            }
        }

        public void LendItem()
        {
          
        }

        public void ReturnItem(DateTime returnedDate)
        {
            
        }

        public int GetBookCount()
        {
            return _books.Count;
        }
    }
}
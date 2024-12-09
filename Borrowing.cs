using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_FinalLibraryCatalog
{
    public class Borrowing
    {
        private Stack<Book> borrowing = new Stack<Book>();

        public void Borrow(Book book)
        {
            borrowing.Push(book);
        }

        public void UndoBorrow()
        {
            if (borrowing.Count > 0)
            {
                var lastBorrowed = borrowing.Pop();
            }
            
        }

        public Stack<Book> GetHistory()
        {
            return borrowing;
        }
    }
}

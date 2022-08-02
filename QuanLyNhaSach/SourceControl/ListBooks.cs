using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.SourceControl
{
    internal class ListBooks
    {
        private List<Books> listBooks;
        public ListBooks()
        {
            listBooks = new List<Books>();
        }
        public void Input( Books books, int count)
        {
            for (int i = 0; i < count; i++)
            {
                books = new Books();
                listBooks.Add(books);
            }
        }
    }
}

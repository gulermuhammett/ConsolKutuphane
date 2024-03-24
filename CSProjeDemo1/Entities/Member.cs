using CSProjeDemo1.Abstracts;
using CSProjeDemo1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities
{
    public class Member : IMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNumber { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public void BorrowBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"{book.Title} kitabı ödünç alındı!");
        }

        public void ReturnBook(Book book)
        {
            Books.Remove(book);
            Console.WriteLine($"{book.Title} kitabı iade edildi!");
        }
    }
}

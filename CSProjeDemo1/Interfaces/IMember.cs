using CSProjeDemo1.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Interfaces
{
    public interface IMember
    {
        string Name { get; set; }
        string Surname { get; set; }
        int MemberNumber { get; set; }
        List<Book> Books { get; set; }

        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}

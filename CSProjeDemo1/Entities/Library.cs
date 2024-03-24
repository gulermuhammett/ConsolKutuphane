using CSProjeDemo1.Abstracts;
using CSProjeDemo1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<IMember> Members { get; set; } = new List<IMember>();

        public void ListBook()
        {
            Console.WriteLine("Kütüphanedeki kitaplar:");
            foreach (var item in Books)
            {
                Console.WriteLine($"- {item.Title} / {item.Writer} / {item.Status}");
            }
        }

        public void ListMembers()
        {
            Console.WriteLine("Üyeler:");
            foreach (var item in Members)
            {
                Console.WriteLine($"- {item.Name} {item.Surname} / {item.MemberNumber}");
            }
        }
    }
}

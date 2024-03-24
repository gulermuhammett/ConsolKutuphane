using CSProjeDemo1.Abstracts;
using CSProjeDemo1.Entities;
using CSProjeDemo1.Enums;
using CSProjeDemo1.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        IMember member1 = new Member { Name = "Muhammet", Surname = "Güler", MemberNumber = 1 };
        IMember member2 = new Member { Name = "Emre", Surname = "Üzüm", MemberNumber = 2 };
        IMember member3 = new Member { Name = "Caggri", Surname = "Buhurcu", MemberNumber = 3 };

        library.Members.Add(member1);
        library.Members.Add(member2);
        library.Members.Add(member3);

        Book scienceBook = new BookScience { Title = "Bilim Kitabı", ISBN = 1234, ReleaseDate = 2010, Writer = "Gencay", Status = CSProjeDemo1.Enums.Status.CanBorrow };
        Book novelBook = new BookNovel { Title = "Roman Kitabı", ISBN = 3456, ReleaseDate = 2015, Writer = "Şura Zeynep", Status = CSProjeDemo1.Enums.Status.CanBorrow };

        library.Books.Add(scienceBook);
        library.Books.Add(novelBook);


        int again = 0;
        bool memberSelect = false;
        IMember member0 = new Member();

        Console.WriteLine("Kütüphaneye Hoşgeldiniz!!!");

        do
        {
            Console.Write("Üye Numaranızı Giriniz: ");
            int memberNNumber = int.Parse(Console.ReadLine());
            foreach (var member in library.Members)
            {
                if (member.MemberNumber == memberNNumber)
                {
                    member0.Name = member.Name;
                    member0.Surname = member.Surname;
                    member0.MemberNumber = memberNNumber;
                    member0.Books = member.Books;

                    memberSelect = true;
                    break;
                }
            }
            if (memberSelect == true) again = 1;
            else Console.WriteLine("Hatalı giriş tekrar deneyiniz!!!");
        } while (again == 0);
        again = 0;

        Console.WriteLine($"{member0.Name} {member0.Surname} Hooşgeldiniz");

        do
        {
            Console.WriteLine("Lütfen yapmak istediğinizişlemi seçiniz!!!");
            Console.WriteLine("1 - Mevcut kitaplar");
            Console.WriteLine("2 - Ödünçalınabilirkitaplar");
            Console.WriteLine("3 - Üyeler");
            Console.WriteLine("4 - İşlemlerim");
            Console.WriteLine("Seçim: ");
            int selected = int.Parse(Console.ReadLine());

            if (selected > 4 || selected < 1)
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 ile 4 arasında seçim yapınız...");
                continue;
            }

            switch (selected)
            {
                case 1:
                    BooksList(library.Books);
                    break;
                case 2:
                    CanBorrowBooksList(library.Books);
                    break;
                case 3:
                    MemberList(library.Members); 
                    break;


            }
        } while (again == 0);




        Console.ReadLine();
    }

    public static void BooksList(List<Book> books)
    {
        foreach (Book book in books)
        {
            Console.WriteLine($"{book.Title}");
        }
    }

    public static void CanBorrowBooksList(List<Book> books)
    {
        foreach (Book book in books)
        {
            if (book.Status==Status.CanBorrow)
            {
                Console.WriteLine($"{book.Title}");
            }
        }
    }

    public static void MemberList(List<IMember> members)
    {
        foreach (IMember member in members)
        {
            Console.WriteLine($"{member.MemberNumber} - {member.Name} - {member.Surname}");
        }
    }

    public static void Activaties(List<IMember> members)
    {
        do
        {

        }while (members.Count > 0);
    }
}
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        private List<Book> books;
        private List<Member> allmembers;

        public LibraryService()
        {
            books = new List<Book>();
            allmembers = new List<Member>();
        }

        public void AddBook(string title, string author, string ISBN, int pages)
        {
            var newBook = new Book(title, author, ISBN, pages, false);
            books.Add(newBook);
        }

        public bool CheckOutBook(string isbn, int member_id)
        {
            foreach (var b in books)
            {
                if (b.ISBN_number == isbn && !b.Checked)
                {
                    b.Checked = true;
                    return true;
                }
            }
            return false;
        }

        public void RegisterMember(string nm, string emailAddr)
        {
            var m = new Member(allmembers.Count + 1, nm, emailAddr);
            allmembers.Add(m);
        }

        public void NotifyMember(int id, string msg)
        {
            var member = allmembers.Find(m => m.memberId == id);
            if (member != null)
            {
                Console.WriteLine($"Notifying {member.FullName}: {msg}");
            }
        }
    }
}

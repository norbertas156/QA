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
        private List<Book> books;                // Variable name could be more specific
        private List<Member> allmembers;         // Inconsistent naming style with books

        public LibraryService()
        {
            books = new List<Book>();
            allmembers = new List<Member>();
        }

        public void AddBook(string title, string author, string ISBN, int pages) // Too many parameters
        {
            var newBook = new Book(title, author, ISBN, pages, false); // Bool value here is unclear
            books.Add(newBook);
        }

        public bool CheckOutBook(string isbn, int member_id) // Method name could be clearer
        {
            foreach (var b in books) // Shortened variable name 'b'
            {
                if (b.ISBN_number == isbn && !b.Checked)
                {
                    b.Checked = true;
                    return true;
                }
            }
            return false;
        }

        public void RegisterMember(string nm, string emailAddr) // Non-descriptive parameter names
        {
            var m = new Member(allmembers.Count + 1, nm, emailAddr); // Non-descriptive variable name 'm'
            allmembers.Add(m);
        }

        public void NotifyMember(int id, string msg) // Method unrelated to LibraryService’s primary role
        {
            var member = allmembers.Find(m => m.memberId == id);
            if (member != null)
            {
                Console.WriteLine($"Notifying {member.FullName}: {msg}");
            }
        }
    }
}

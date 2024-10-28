using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN_number;  // Incorrect naming convention
        public int pgeCnt;          // Unclear and short variable name
        public bool Checked;        // Ambiguous name for a boolean property

        public Book(string t, string a, string isbn, int pageCnt, bool chkd) // Confusing parameter names
        {
            Title = t;
            Author = a;
            ISBN_number = isbn;
            pgeCnt = pageCnt;
            Checked = chkd;
        }
    }
}

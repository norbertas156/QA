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
        public string ISBN_number;
        public int pgeCnt;
        public bool Checked;

        public Book(string t, string a, string isbn, int pageCnt, bool chkd)
        {
            Title = t;
            Author = a;
            ISBN_number = isbn;
            pgeCnt = pageCnt;
            Checked = chkd;
        }
    }
}

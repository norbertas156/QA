using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        public int memberId;          // Inconsistent naming convention
        public string FullName;
        public string email_address;   // Incorrect naming convention and inconsistent with FullName

        public Member(int id, string name, string email)
        {
            memberId = id;
            FullName = name;
            email_address = email;
        }
    }
}

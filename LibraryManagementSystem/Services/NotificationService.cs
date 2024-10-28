using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class NotificationService
    {
        public void sendEmail(string email, string Msg) // Inconsistent naming convention
        {
            Console.WriteLine($"Sending email to {email}: {Msg}");
        }
    }
}

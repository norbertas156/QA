using LibraryManagementSystem.Services;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libraryService = new LibraryService();
            libraryService.AddBook("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", 180);
            libraryService.RegisterMember("John Doe", "johndoe@example.com");

            var isBookCheckedOut = libraryService.CheckOutBook("9780743273565", 1);
            if (isBookCheckedOut)
            {
                libraryService.NotifyMember(1, "Your book has been checked out successfully.");
            }

        }
    }
}
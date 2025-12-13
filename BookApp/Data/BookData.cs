using BookApp.Models;

namespace BookApp.Data
{
    public static class BookData
    {
        public static List<Books> Book = new List<Books>
        {
            new Books
            {
                Id = 1,
                Title = "Start with Why",
                Author = "Simon Sinek",
                Price = 19.99m,
                Genre = "Business",
                PublishedYear = 2009
            },
            new Books
            {
                Id = 2,
                Title = "The Lean Startup",
                Author = "Eric Ries",
                Price = 24.99m,
                Genre = "Entrepreneurship",
                PublishedYear = 2011
            },
            new Books
            {
                Id = 3,
                Title = "Deep Work",
                Author = "Cal Newport",
                Price = 29.99m,
                Genre = "Productivity",
                PublishedYear = 2016
            },
            new Books
            {
                Id = 4,
                Title = "Atomic Habits",
                Author = "James Clear",
                Price = 21.99m,
                Genre = "Self-Help",
                PublishedYear = 2018
            }
        };
    }
}

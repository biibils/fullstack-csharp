using Microsoft.AspNetCore.Mvc;
using BookApp.Data;

public class BooksController : Controller
{
    // GET: /Books/
    public IActionResult Index()
    {
        return View(BookData.Book);
    }

    public IActionResult Details(int id)
    {
        var book = BookData.Book.FirstOrDefault(x => x.Id == id);
        return View(book);
    }
}

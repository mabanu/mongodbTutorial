using Microsoft.AspNetCore.Mvc;

namespace mongoDbApi.Controllers;

public class BooksController : Controller
{
	// GET
	public IActionResult Index()
	{
		return View();
	}
}
using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel.
using Microsoft.AspNetCore.Mvc; // To use [BindProperty], IActionResult.

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
   public List<string> Suppliers { get; set; }

   public void OnGet()
   {
    ViewData["title"] = "Proveedores";
    Suppliers = new List<string>() { "Supplier 1", "Supplier 2", "Supplier 3" };

   }
}

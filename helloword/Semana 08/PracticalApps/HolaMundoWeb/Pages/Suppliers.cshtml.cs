using Microsoft.AspNetCore.Mvc.RazorPages; // To use PageModel.
using Microsoft.AspNetCore.Mvc; // To use [BindProperty], IActionResult.
using Northwind.EntityModels;

namespace Northwind.Web.Pages;

public class SuppliersModel : PageModel
{
   private NorthwindContext _db;
   public SuppliersModel(NorthwindContext db)
   {
    _db = db;
   }
   public IEnumerable<Supplier>? Suppliers { get; set; }

   [BindProperty]
   public Supplier? Supplier { get; set; }

   public void OnGet()
   {
    ViewData["title"] = "Proveedores";
    Suppliers = _db.Suppliers.OrderBy((x) => x.Country);
   }

   public IActionResult OnPost(){
      if(Supplier is not null && ModelState.IsValid){
         _db.Suppliers.Add(Supplier);
         _db.SaveChanges();
         return RedirectToPage("/suppliers");
      } else {
         return BadRequest();
      }
   }
}

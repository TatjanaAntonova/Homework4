using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;


namespace Homework4.Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage
    {
        public CreateModel(IUnitsRepository r) : base(r) { }
        public IActionResult OnGet() => Page();
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!await addObject()) return Page();
            return RedirectToPage("./Index");
        }
    }
}

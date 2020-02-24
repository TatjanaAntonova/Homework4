using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : PageModel
    {
        private readonly IMeasuresRepository data;

        public CreateModel(IMeasuresRepository r) => data = r;
        

        public IActionResult OnGet() => Page();
        

        [BindProperty]
        public MeasureView MeasureView { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await data.Add(MeasureViewFactory.Create(MeasureView));

            return RedirectToPage("./Index");
        }
    }
}

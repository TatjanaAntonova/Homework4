using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Homework4.Facade.Quantity;
using Homework4.Soft.Data;

namespace Homework4.Soft
{
    public class CreateModel : PageModel
    {
        private readonly Homework4.Soft.Data.ApplicationDbContext _context;

        public CreateModel(Homework4.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MeasureView MeasureView { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Measures.Add(MeasureView);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

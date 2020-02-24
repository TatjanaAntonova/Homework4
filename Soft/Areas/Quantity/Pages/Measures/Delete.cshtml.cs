﻿using System.Threading.Tasks;
using Homework4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class DeleteModel : PageModel
    {
        private readonly Homework4.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Homework4.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MeasureView MeasureView { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasureView = await _context.Measures.FirstOrDefaultAsync(m => m.Id == id);

            if (MeasureView == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasureView = await _context.Measures.FindAsync(id);

            if (MeasureView != null)
            {
                _context.Measures.Remove(MeasureView);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

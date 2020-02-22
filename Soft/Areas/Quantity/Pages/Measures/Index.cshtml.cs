using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Homework4.Facade.Quantity;
using Homework4.Soft.Data;

namespace Homework4.Soft
{
    public class IndexModel : PageModel
    {
        private readonly Homework4.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Homework4.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MeasureView> MeasureView { get;set; }

        public async Task OnGetAsync()
        {
            MeasureView = await _context.Measures.ToListAsync();
        }
    }
}

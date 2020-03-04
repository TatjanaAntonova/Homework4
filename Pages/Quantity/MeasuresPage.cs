using System.Collections.Generic;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework4.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository data;

        protected internal MeasuresPage(IMeasuresRepository r) => data = r;
     
        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }

        public string PageTitle { get; set; } = "Mingi pealiri";
        public string CurrentSort { get; set; } = "Current sort";
        public string CurrentFilter { get; set; } = "Current filter";
        public int PageIndex { get; set; } = 3;
        public int TotalPages { get; set; } = 10;
    }
}

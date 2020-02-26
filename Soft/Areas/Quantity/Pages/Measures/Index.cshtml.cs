using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Homework4.Pages.Quantity;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        public string SearchString;
        public IndexModel(IMeasuresRepository r) : base(r) { }
        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            data.SortOrder = sortOrder;
            SearchString = searchString;
            data.SearchString = SearchString;
            var l = await data.Get();
            Items = new List<MeasureView>();

            foreach (var e in l) { Items.Add(MeasureViewFactory.Create(e)); }
        }

        public string DateSort { get; set; }

        public string NameSort { get; set; }
    }
}

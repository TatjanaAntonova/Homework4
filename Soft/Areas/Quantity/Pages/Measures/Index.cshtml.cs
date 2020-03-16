 using System;
using System.Collections.Generic;
 using System.Linq.Expressions;
 using System.Threading.Tasks;
 using Homework4.Aids;
 using Homework4.Data.Quantity;
 using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Homework4.Pages.Quantity;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {

        public IndexModel(IMeasuresRepository r) : base(r) { }
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            await getList(sortOrder,
            currentFilter, searchString, pageIndex);

           
        }

        
    }
}

 using System.Threading.Tasks;
 using Homework4.Domain.Quantity;
 using Homework4.Pages.Quantity;

namespace Homework4.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {

        public IndexModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m) { }
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            await getList(sortOrder,
            currentFilter, searchString, pageIndex);
        }
    }
}

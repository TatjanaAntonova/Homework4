﻿ using System.Threading.Tasks;
 using Homework4.Domain.Quantity;
 using Homework4.Pages.Quantity;

namespace Homework4.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {

        public IndexModel(IUnitsRepository r, IMeasuresRepository m
            , IUnitTermsRepository t, IUnitFactorsRepository f) : base(r, m, t, f) { }
        public async Task OnGetAsync(string sortOrder,
            string id, string currentFilter, string searchString, int? pageIndex,
            string fixedFilter, string fixedValue)
        {

            SelectedId = id;
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);

        }
    }
}


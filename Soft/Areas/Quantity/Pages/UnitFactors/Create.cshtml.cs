using System.Collections.Generic;
using System.Threading.Tasks;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Homework4.Soft.Areas.Quantity.Pages.UnitFactors
{
    public class CreateModel : UnitFactorsPage
    {
        public CreateModel(IUnitFactorsRepository r, IUnitsRepository u, ISystemsOfUnitsRepository s) : base(r)
        {
            Units = createSelectList<Unit, UnitData>(u);
            SystemsOfUnits = createSelectList<SystemOfUnits, SystemOfUnitsData>(s);
        }

        public IEnumerable<SelectListItem> SystemsOfUnits { get; }

        public IEnumerable<SelectListItem> Units { get; }

        public IActionResult OnGet(string fixedFilter, string fixedValue) {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        } 
        
        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
           
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}

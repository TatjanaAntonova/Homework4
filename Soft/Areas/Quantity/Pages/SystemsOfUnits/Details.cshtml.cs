﻿using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Soft.Areas.Quantity.Pages.SystemsOfUnits
{
    public class DetailsModel : SystemsOfUnitsPage
    {
        public DetailsModel(ISystemsOfUnitsRepository r) : base(r) { }
        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
           
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}

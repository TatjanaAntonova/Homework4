﻿using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;


namespace Homework4.Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage
    {
        public CreateModel(IUnitsRepository r, IMeasuresRepository m
            , IUnitTermsRepository t, IUnitFactorsRepository f): base(r, m, t, f) { }


        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
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

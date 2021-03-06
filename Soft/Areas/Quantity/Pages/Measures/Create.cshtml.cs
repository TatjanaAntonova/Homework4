﻿using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : MeasuresPage
    {
        public CreateModel(IMeasuresRepository r, IMeasureTermsRepository t) : base(r, t) { }
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

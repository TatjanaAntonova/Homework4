﻿using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Pages.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Soft.Areas.Quantity.Pages.UnitTerms
{
    public class DeleteModel : UnitTermsPage
    {
        public DeleteModel(IUnitTermsRepository r, IUnitsRepository u) : base(r, u) { }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
           
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}

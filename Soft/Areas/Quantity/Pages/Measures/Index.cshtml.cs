using System.Collections.Generic;
using System.Threading.Tasks;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Homework4.Pages.Quantity;

namespace Homework4.Soft.Areas.Quantity.Pages.Measures
{
    public class IndexModel : MeasuresPage
    {
        internal IndexModel(IMeasuresRepository r) : base(r) { }
        public async Task OnGetAsync()
        {
            var l = await data.Get();
            Items = new List<MeasureView>();

            foreach (var e in l) { Items.Add(MeasureViewFactory.Create(e)); }
        }
    }
}

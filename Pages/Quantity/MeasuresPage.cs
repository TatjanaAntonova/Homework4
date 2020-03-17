using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;

namespace Homework4.Pages.Quantity
{
    public class MeasuresPage : BasePage<IMeasuresRepository, Measure, MeasureView, MeasureData>
    {
        protected internal MeasuresPage(IMeasuresRepository r): base(r)
        {
           PageTitle = "Measures";
        }

        public override string ItemId => Item.Id;

        protected internal override Measure toObject(MeasureView view)
        {
            return MeasureViewFactory.Create(view);
        }

        protected internal override MeasureView toView(Measure obj)
        {
            return MeasureViewFactory.Create(obj);
        }
    }
}

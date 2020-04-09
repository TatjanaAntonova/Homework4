using System.Collections.Generic;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;

namespace Homework4.Pages.Quantity
{
    public abstract class MeasuresPage : CommonPage<IMeasuresRepository, Measure, MeasureView, MeasureData>
    {
        protected internal readonly IMeasureTermsRepository terms;
        protected internal MeasuresPage(IMeasuresRepository r, IMeasureTermsRepository t) : base(r)
        {
            PageTitle = "Measures";
            Terms = new List<MeasureTermView>();
            terms = t;
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string getPageUrl() => "/Quantity/Measures";

        protected internal override Measure toObject(MeasureView view)
        {
            return MeasureViewFactory.Create(view);
        }

        protected internal override MeasureView toView(Measure obj)
        {
            return MeasureViewFactory.Create(obj);
        }
        public IList<MeasureTermView> Terms { get; }

        public void LoadDetails(MeasureView item)
        {
            Terms.Clear();

            if (item is null) return;
            terms.FixedFilter = GetMember.Name<MeasureTermData>(x => x.MasterId);
            terms.FixedValue = item.Id;
            var list = terms.Get().GetAwaiter().GetResult();

            foreach (var e in list)
            {
                Terms.Add(MeasureTermViewFactory.Create(e));
            }
        }
    }
}

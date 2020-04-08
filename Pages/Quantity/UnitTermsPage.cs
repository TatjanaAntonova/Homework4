using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;

namespace Homework4.Pages.Quantity
{
    public class UnitTermsPage : CommonPage<IUnitTermsRepository, UnitTerm, UnitTermView, UnitTermData>
    {
        protected internal UnitTermsPage(IUnitTermsRepository r = null) : base(r)
        {
            PageTitle = "Unit Terms";
        }

        public override string ItemId
        {
            get
            {
                if (Item is null) return string.Empty;
                return $"{Item.MasterId}.{Item.TermId}";
            }
        }

        protected internal override string getPageUrl() => "/Quantity/UnitTerms";

        protected internal override UnitTerm toObject(UnitTermView view)
        {
            return UnitTermViewFactory.Create(view);
        }

        protected internal override UnitTermView toView(UnitTerm obj)
        {
            return UnitTermViewFactory.Create(obj);
        }
    }
}

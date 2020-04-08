using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;

namespace Homework4.Pages.Quantity
{
    public class SystemsOfUnitsPage : CommonPage<ISystemsOfUnitsRepository, SystemOfUnits, SystemOfUnitsView, SystemOfUnitsData>
    {
        protected internal SystemsOfUnitsPage(ISystemsOfUnitsRepository r = null) : base(r)
        {
            PageTitle = "Measure Terms";
        }

        public override string ItemId => Item.Id;
        

        protected internal override string getPageUrl() => "/Quantity/SystemOfUnits";

        protected internal override SystemOfUnits toObject(SystemOfUnitsView view)
        {
            return SystemOfUnitsViewFactory.Create(view);
        }

        protected internal override SystemOfUnitsView toView(SystemOfUnits obj)
        {
            return SystemOfUnitsViewFactory.Create(obj);
        }
    }
}


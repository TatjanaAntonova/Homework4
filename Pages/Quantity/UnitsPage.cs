using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;

namespace Homework4.Pages.Quantity
{
    public class UnitsPage : BasePage<IUnitsRepository, Unit, UnitView>
    {
        protected internal UnitsPage(IUnitsRepository r) : base(r)
        {
            PageTitle = "Units";
        }

        public override string ItemId => Item.Id;

        protected internal override Unit toObject(UnitView view)
        {
            return UnitViewFactory.Create(view);
        }

        protected internal override UnitView toView(Unit obj)
        {
            return UnitViewFactory.Create(obj);
        }
    }
}

using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class SystemOfUnitsViewFactory
    {
        public static SystemOfUnits Create(SystemOfUnitsView view)
        {
            var d = new SystemOfUnitsData();
            Copy.Members(view, d);

            return new SystemOfUnits(d);
        }

        public static SystemOfUnitsView Create(SystemOfUnits obj)
        {
            var v = new SystemOfUnitsView();
            Copy.Members(obj.Data, v);

            return v;
        }
    }
}

using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class UnitViewFactory
    {
        public static Unit Create(UnitView v)
        {
            var d = new UnitData();
            Copy.Members(v, d);

            return new Unit(d);
        }

        public static UnitView Create(Unit o)
        {
            var v = new UnitView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);
            return v;
        }
    }
}


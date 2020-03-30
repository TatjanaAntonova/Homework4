using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class MeasureTermViewFactory
    {
        public static MeasureTerm Create(MeasureTermView view)
        {
            var d = new MeasureTermData();
            Copy.Members(view, d);

            return new MeasureTerm(d);
        }

        public static MeasureTermView Create(MeasureTerm obj)
        {
            var v = new MeasureTermView();
            Copy.Members(obj.Data, v);

            return v;
        }
    }
}

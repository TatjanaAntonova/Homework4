using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class MeasureViewFactory
    {
        public static Measure Create(MeasureView v)
        {
            var d = new MeasureData();
            Copy.Members(v, d);

            return new Measure(d);
        }

        public static MeasureView Create(Measure o)
        {
            var v = new MeasureView();
            if (!(o?.Data is null))
                Copy.Members(o.Data, v);
            return v;
        }
    }
}

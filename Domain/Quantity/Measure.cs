using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public class Measure: Entity<MeasureData>
    {
        public Measure(MeasureData data) : base(data)
        {
        }
    }
}

using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public sealed class MeasureTerm: Entity<MeasureTermData>
    {
        public MeasureTerm() : this(null) { }
        public MeasureTerm(MeasureTermData data) : base(data) { }
    }
}

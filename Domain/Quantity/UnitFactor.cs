using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public sealed class UnitFactor: Entity<UnitFactorData>
    {
        public UnitFactor() : this(null) { }
        public UnitFactor(UnitFactorData data) : base(data) { }
    }
}

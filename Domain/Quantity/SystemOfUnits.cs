using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public sealed class SystemOfUnits: Entity<SystemOfUnitsData>
    {
        public SystemOfUnits() : this(null) { }
        public SystemOfUnits(SystemOfUnitsData data) : base(data) { }
    }
}

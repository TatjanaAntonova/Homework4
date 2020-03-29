using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public sealed class UnitTerm: Entity<UnitTermData>
    {
        public UnitTerm() : this(null) { }
        public UnitTerm(UnitTermData data) : base(data) { }
    }
}

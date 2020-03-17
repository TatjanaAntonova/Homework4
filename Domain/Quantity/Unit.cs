using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Data.Quantity;
using Homework4.Domain.Common;

namespace Homework4.Domain.Quantity
{
    public class Unit: Entity<UnitData>
    {
        public Unit() : this(null) { }

        public Unit(UnitData d) : base(d) { }
    }
}

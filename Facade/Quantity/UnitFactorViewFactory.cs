using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class  UnitFactorViewFactory
    {
        public static UnitFactor Create(UnitFactorView view)
        {
            var d = new UnitFactorData();
            Copy.Members(view, d);
            return new UnitFactor(d);
        }

        public static UnitFactorView Create(UnitFactor obj)
        {
            var v = new UnitFactorView();
            Copy.Members(obj.Data, v);

            return v;
        }
    }
}

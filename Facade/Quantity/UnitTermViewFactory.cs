using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class UnitTermViewFactory
    {
        public static UnitTerm Create(UnitTermView view)
        {
            var d = new UnitTermData();
            Copy.Members(view, d);
            return new UnitTerm(d);
        }

        public static UnitTermView Create(UnitTerm obj)
        {
            var v = new UnitTermView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}

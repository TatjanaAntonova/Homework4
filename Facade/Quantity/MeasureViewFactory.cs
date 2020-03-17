﻿using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Facade.Quantity
{
    public static class MeasureViewFactory
    {
        public static Measure Create(MeasureView v)
        {
            var o = new Measure
            {
                Data =
                {
                    Id = v.Id,
                    Code = v.Code,
                    Name = v.Name,
                    Definition = v.Definition,
                    ValidFrom = v.ValidFrom,
                    ValidTo = v.ValidTo
                }
            };
            return o;
        }

        public static MeasureView Create(Measure o)
        {
            var v = new MeasureView
            {
                Id = o.Data.Id,
                Name = o.Data.Name,
                Code = o.Data.Code,
                Definition = o.Data.Definition,
                ValidFrom = o.Data.ValidFrom,
                ValidTo = o.Data.ValidTo
            };
           return v;
        }
    }
}

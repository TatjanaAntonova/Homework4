using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Data.Common;

namespace Homework4.Data.Quantity
{
    public class UnitFactorData: PeriodData
    {
        public string UnitId { get; set; }
        public string SystemOfUnitsId { get; set; }
        public double Factor { get; set; }
    }
}

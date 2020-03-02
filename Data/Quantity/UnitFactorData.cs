using Homework4.Data.Common;

namespace Homework4.Data.Quantity
{
    public sealed class UnitFactorData: PeriodData
    {
        public string UnitId { get; set; }
        public string SystemOfUnitsId { get; set; }
        public double Factor { get; set; }
    }
}

﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Homework4.Facade.Common;

namespace Homework4.Facade.Quantity
{
    public sealed class UnitFactorView : PeriodView
    {
        [Required]
        [DisplayName("Unit")]
        public string UnitId { get; set; }
        [Required]
        [DisplayName("System of Units")]
        public string SystemOfUnitsId { get; set; }
        public double Factor { get; set; }

        public string GetId()
        {
            return $"{SystemOfUnitsId}.{UnitId}";
        }
    }
}

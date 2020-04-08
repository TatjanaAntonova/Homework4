using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Homework4.Facade.Common;

namespace Homework4.Facade.Quantity
{
    public sealed class MeasureTermView: CommonTermView
    {
        [Required]
        [DisplayName("Measure")]
        public string MasterId { get; set; }

        public string GetId()
        {
            return $"{MasterId}.{TermId}";
        }
    }
}

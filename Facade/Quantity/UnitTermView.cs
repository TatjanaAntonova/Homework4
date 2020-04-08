using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Homework4.Facade.Quantity
{
    public sealed class UnitTermView : CommonTermView
    {
        [Required]
        [DisplayName("Unit")]
        public string MasterId { get; set; }
        public string GetId()
        {
            return $"{MasterId}.{TermId}";
        }
    }
}

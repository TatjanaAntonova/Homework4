using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Homework4.Data.Common;
using Homework4.Facade.Common;

namespace Homework4.Facade.Quantity
{
    public abstract class CommonTermView: PeriodView
    {
        [Required]
        [DisplayName("Term")]
        public string TermId { get; set; }
        public int Power { get; set; }
    }
}
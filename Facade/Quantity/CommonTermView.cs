using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Homework4.Data.Common;

namespace Homework4.Facade.Quantity
{
    public abstract class CommonTermView: PeriodData
    {
        [Required]
        [DisplayName("Term")]
        public string TermId { get; set; }
        public int Power { get; set; }
    }
}
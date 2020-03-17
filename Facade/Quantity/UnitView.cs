using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Homework4.Facade.Common;

namespace Homework4.Facade.Quantity
{
    public class UnitView: DefinedView
    {
        [Required]
        [DisplayName("Measure")]
        public string MeasureID { get; set; }
    }
}

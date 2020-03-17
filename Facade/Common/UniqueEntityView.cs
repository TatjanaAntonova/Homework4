using System.ComponentModel.DataAnnotations;

namespace Homework4.Facade.Common
{
    public abstract class UniqueEntityView: PeriodView
    { 
        [Required]
        public string Id { get; set; }
    }
}
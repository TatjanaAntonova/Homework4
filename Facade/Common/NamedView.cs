using System.ComponentModel.DataAnnotations;

namespace Homework4.Facade.Common
{
    public abstract class NamedView : UniqueEntityView
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Models.Base
{
    internal abstract class OrderBase
    {
        [Key]
        public Guid Id {get; set; }
    }
}
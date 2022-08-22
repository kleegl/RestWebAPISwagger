using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Base;

namespace Models.Implementations
{
    internal class Order : OrderBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderNumber { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string SenderCity { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string TargetCity {get; set; }
        
        [Required]
        public int CargoWeight { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime CargoPickUpDate { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ECommerceApp.Core.Entities
{
    [Table(name: "Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public required Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public required ICollection<OrderItem> OrderItems { get; set; }
    }
}
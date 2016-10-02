using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerAddress { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public String CustomerMobile { get; set; }
        [Required]
        [MaxLength(256)]
        public String CustomerMessage { get; set; }
        [MaxLength(256)]
        public String PaymentMethod { get; set; }
        public DateTime? CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public String PaymentStatus { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}

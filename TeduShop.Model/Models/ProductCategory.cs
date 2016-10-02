using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public String Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public String Alias { set; get; }
        [MaxLength(500)]
        public String Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        [MaxLength(256)]
        public String Image { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<Product> Products { set; get; }
    }
}

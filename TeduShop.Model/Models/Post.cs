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
    [Table("Posts")]
    public class Post: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public String Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public String Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLength(256)]
        public String Image { set; get; }
        [MaxLength(500)]
        public String Description { set; get; }
        public String Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public String Name { set; get; }
        [Required]
        [MaxLength(256)]
        public String Url { set; get; }
        public int? DisplayOrder { set; get; }
        [Required]
        public int GroupID { set; get;}
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
        [MaxLength(10)]
        public String Target { set; get; }
        public bool Status { get; set; }
    }
}

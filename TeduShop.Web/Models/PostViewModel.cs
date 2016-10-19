﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { set; get; }
       
        public String Name { set; get; }
      
        public String Alias { set; get; }
      
        public int CategoryID { set; get; }
       
        public String Image { set; get; }
        
        public String Description { set; get; }
        public String Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        public string UpdatedBy { set; get; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
      
        public virtual PostCategoryViewModel PostCategory { set; get; }
        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
    }
}
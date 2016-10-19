using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { set; get; }
        public String Name { set; get; }
       
        public String Alias { set; get; }
        
        public String Description { set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
       
        public String Image { set; get; }
        public bool? HomeFlag { set; get; }
        public virtual IEnumerable<PostViewModel> Posts { set; get; }
        public DateTime? CreatedDate { set; get; }


        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }


        public string UpdatedBy { set; get; }


        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { set; get; }
    }
}
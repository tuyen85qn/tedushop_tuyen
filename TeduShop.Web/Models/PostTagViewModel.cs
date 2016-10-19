using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { set; get; }
       
        public String TagID { set; get; }

        public virtual PostViewModel Post { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}
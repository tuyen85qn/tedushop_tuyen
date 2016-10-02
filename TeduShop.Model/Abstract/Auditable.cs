﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public String CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        [MaxLength(256)]
        public String UpdatedBy { set; get; }
        [MaxLength(256)]
        public String MetaKeyword { set; get; }
        [MaxLength(256)]
        public String MetaDescription { set; get; }
        public bool Status { set; get; }
        
    }
}

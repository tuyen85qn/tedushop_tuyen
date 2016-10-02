using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        String CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        String UpdatedBy { set; get; }
        String MetaKeyword { set; get; }
        String MetaDescription { set; get; }
        bool Status { set; get; }
    }
}

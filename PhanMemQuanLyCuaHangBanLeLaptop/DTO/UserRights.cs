using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserRights
    {
        public string MaMenu { get; set; }
        public string TenMenu { get; set; }
        public bool? CoQuyen { get; set; }
        public string ParentMenu { get; set; }
    }
}

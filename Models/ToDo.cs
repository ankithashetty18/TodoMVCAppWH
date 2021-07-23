using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoMVCAppWH.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}

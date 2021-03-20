using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Repository.Models
{
    public class Group:Abstract
    {
        
        public string Type { get; set; }
        public string Name { get; set; }
        public ICollection<Provider> providers { get; set; }

    }
}

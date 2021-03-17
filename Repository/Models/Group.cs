using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Repository.Models
{
    public class Group
    {
        
        public string Type { get; set; }
        public string Name { get; set; }
        public List<Provider> providers { get; set; }

    }
}

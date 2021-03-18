using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApp.Repository.Models
{
    public class Provider:Abstract
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string GroupId { get; set; }
        public Group groups { get; set; }
    }
}

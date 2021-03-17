using System;

namespace RazorApp.Repository.Models
{
    public abstract class Abstract
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}

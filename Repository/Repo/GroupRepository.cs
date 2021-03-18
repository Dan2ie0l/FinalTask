using System;
using System.Collections.Generic;
using Serilog;
using RazorApp.Repository.Models;


namespace RazorApp.Repository.Repo
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationContext dbContext, ILogger logger)
           : base(dbContext, logger)
        { }
    }
}

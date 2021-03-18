using System;
using System.Collections.Generic;
using Serilog;
using RazorApp.Repository.Models;

namespace RazorApp.Repository.Repo
{
    public class ProviderRepository : BaseRepository<Provider>, IProviderRepository
    {
        public ProviderRepository(ApplicationContext dbContext, ILogger logger)
            : base(dbContext, logger)
        { }
    }
}

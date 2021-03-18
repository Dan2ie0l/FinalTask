using RazorApp.Repository;
using RazorApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorApp.Services.Services
{
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        private readonly IProviderRepository providerRepository;
        private readonly IBaseRepository<Provider> baseRepository;

        public ProviderService(IProviderRepository providerRepository, IBaseRepository<Provider> baseRepository)
            : base(baseRepository)
        {
            this.providerRepository = providerRepository;
            this.baseRepository = baseRepository;
        }

        public IEnumerable<string> ProvidersNames(int groupId)
        {
            return providerRepository
                .Actives()
                .Where(t => t.GroupId == groupId)
                .Select(t => t.Name);
        }
    }
}

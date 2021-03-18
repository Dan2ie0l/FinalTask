using RazorApp.Repository;
using RazorApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RazorApp.Services.Services
{
    public class GroupService : BaseService<Group>, IGroupService
    {
        private readonly IGroupRepository groupRepository;
        private readonly IBaseRepository<Group> baseRepository;

        public GroupService(IGroupRepository groupRepository, IBaseRepository<Group> baseRepository)
            : base(baseRepository)
        {
            this.groupRepository = groupRepository;
            this.baseRepository = baseRepository;
        }

        public IEnumerable<string> GroupsNames()
        {
            return groupRepository
                .Actives()
                .Select(t => t.Name);
        }
    }
}

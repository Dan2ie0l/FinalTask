using AutoMapper;
using RazorApp.Repository.Models;
using RazorApp.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Presentation
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<Group, ViewModelGroup >()
                .ForMember(m => m.Id, cfg => cfg.MapFrom(vm => vm.Id))
                .ForMember(m => m.Name, cfg => cfg.MapFrom(vm => vm.Name))
                .ForMember(m => m.Type, cfg => cfg.MapFrom(vm => vm.Type));

            CreateMap<Provider, ViewModelProvider >()
                .ForMember(m => m.Id, cfg => cfg.MapFrom(vm => vm.Id))
                .ForMember(m => m.Name, cfg => cfg.MapFrom(vm => vm.Name))
                .ForMember(m => m.Type, cfg => cfg.MapFrom(vm => vm.Type))
                .ForMember(m => m.GroupId, cfg => cfg.MapFrom(vm => vm.GroupId));
        }
    }
}

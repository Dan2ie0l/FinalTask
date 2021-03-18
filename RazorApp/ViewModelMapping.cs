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
                .ForMember(m => m.Id, conf => conf.MapFrom(viewM => viewM.Id))
                .ForMember(m => m.Name, conf => conf.MapFrom(viewM => viewM.Name))
                .ForMember(m => m.Type, conf => conf.MapFrom(viewM => viewM.Type));

            CreateMap<Provider, ViewModelProvider >()
                .ForMember(m => m.Id, conf => conf.MapFrom(viewM => viewM.Id))
                .ForMember(m => m.Name, conf => conf.MapFrom(viewM => viewM.Name))
                .ForMember(m => m.Type, conf => conf.MapFrom(viewM => viewM.Type))
                .ForMember(m => m.GroupId, conf => conf.MapFrom(viewM => viewM.GroupId));
        }
    }
}

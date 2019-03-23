using AutoMapper;
using JFDIList.Domain.Model;
using JFDIList.DTOs.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFDIList.Services.Infrastructure
{
    public class AutoMapperTaskProfile : Profile
    {
        public AutoMapperTaskProfile()
        {

            // it's not necessary but as sample

            this.CreateMap<TaskItem, TaskDto>();
            this.CreateMap<TaskDto, TaskItem>();

            this.CreateMap<Tag, TagDto>();
            this.CreateMap<TagDto, Tag>();
        }
    }
}

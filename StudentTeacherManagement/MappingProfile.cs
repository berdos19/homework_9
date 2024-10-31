using System.Text.RegularExpressions;
using AutoMapper;
using StudentTeacherManagement.DTOs;

namespace StudentTeacherManagement;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Group, GroupDTO>().ReverseMap();
    }
}
using Application.Commands.Student;
using Application.Responses.Student;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers.Student
{
    public class StudentMappingProfile : Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Domain.Entities.Student, StudentResponse>().ReverseMap();
            CreateMap<Domain.Entities.Student, CreateStudentCommand>().ReverseMap();
        }
    }
}

using AutoMapper;
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Data.Mapping
{
    public class StudentProfile : Profile
    {

        public StudentProfile() 
        {
            CreateMap<StudentInsert, Student>();
            CreateMap<StudentUpdate, Student>();
            CreateMap<Student, StudentResponse>();
            CreateMap<CourseRequest, Course>();
            CreateMap<Course, CourseResponse>();
        }
        
    }
}

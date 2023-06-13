using System.Collections;
using AutoMapper;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Persistence;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Student, StudentResponse>();
    }
}
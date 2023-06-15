
using AutoMapper;
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services.Contract;
using System.Diagnostics;

namespace CRUD_ESTUDANTES.Services;

public class StudentService : IStudentService
{
    private IStudentRepository StudentRepository { get; set; }
    private  readonly IMapper _mapper;

    public StudentService(IStudentRepository studentRepository, IMapper mapper)
    {
        StudentRepository = studentRepository;
        _mapper = mapper;
    }
    public List<StudentResponse> GetAll()
    {
        List<Student> students = StudentRepository
            .GetAllWithCourse().Result;

        return students.ConvertAll(std => _mapper.Map<StudentResponse>(std));
    }

    public StudentResponse GetById(Guid id)
    {
        try
        { 
            Student? entity = StudentRepository.GetById(id).Result;
            return _mapper.Map<StudentResponse>(entity);
        }
        catch (Exception e)
        {
            throw new Exception("Entity Not Found");
        }
        
    }

    public StudentResponse Save(StudentInsert? dto)
    {
        try
        {
            Student student = _mapper.Map<Student>(dto);
           student = StudentRepository.Save(student).Result;
           return _mapper.Map<StudentResponse>(student);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public StudentResponse Update(StudentUpdate? dto, Guid id)
    {
        try
        {

            Student? entity = StudentRepository.GetById(id).Result;
            entity.Name = dto.Name;
            entity=  StudentRepository.Update(entity).Result;
            return _mapper.Map<StudentResponse>(entity);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            throw new Exception("Não atualizado");
            
        }
 
    }

    public void Delete(Guid id)
    {
        Student? student = StudentRepository.GetById(id).Result;
        if (student != null) StudentRepository.Delete(student);
    }
}
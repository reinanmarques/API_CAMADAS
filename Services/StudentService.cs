
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services.Contract;

namespace CRUD_ESTUDANTES.Services;

public class StudentService : IStudentService
{

    private IStudentRepository StudentRepository { get; set; }

    public StudentService(IStudentRepository studentRepository)
    {
        StudentRepository = studentRepository;
    }

    public List<StudentResponse> GetAll()
    {
        List<Student> students = StudentRepository
            .GetAllWithCourse().Result;

        return students.ConvertAll(s => new StudentResponse(s));
    }

    public StudentResponse GetById(Guid id)
    {
        try
        { 
            Student? entity = StudentRepository.GetById(id).Result;
            return new StudentResponse(entity);
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
            Student student = new Student(dto.Name, dto.Course, dto.Email, dto.Password);
           student = StudentRepository.Save(student).Result;
           return new StudentResponse(student);
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
                entity.Course = dto.Course;
                entity = StudentRepository.Update(entity).Result;
                return new StudentResponse(entity);
            
        }
        catch (Exception e)
        {
            throw new Exception("Não atualizado");
        }
 
    }

    public void Delete(Guid id)
    {
        Student? student = StudentRepository.GetById(id).Result;
        if (student != null) StudentRepository.Delete(student);
    }
}
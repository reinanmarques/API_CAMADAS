using System.Diagnostics.CodeAnalysis;
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ESTUDANTES.Controllers;

[Route("api/crud/students")]
[ApiController]
public class StudentsController : ControllerBase
{
    private IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    
    //Buscando todos os Students
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_studentService.GetAll());
    }
    
    //Buscando por Id
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(_studentService.GetById(id));
    }
    
    //Salvando estudante
    [HttpPost]
    public IActionResult Save([FromBody] StudentInsert? input)
    {
        return Ok(_studentService.Save(input));
    }
    
    //Atualizando estudante
    [HttpPut("{id}")]
    public IActionResult Update([FromBody]StudentUpdate? input)
    {
        
        if (input == null)
        {
            return UnprocessableEntity();
        }
        Student entity = new Student(input.Name, input.Course);
        entity.Id = input.Id;
        _studentService.Update(input);
        return Ok();
    }
    
    //Deletando estudante
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _studentService.Delete(id);
        return NoContent();
    }
    
    
}
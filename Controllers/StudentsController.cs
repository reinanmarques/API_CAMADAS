using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using CRUD_ESTUDANTES.Repositories.Contract;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ESTUDANTES.Controllers;

[Route("api/crud/students")]
[ApiController]
public class StudentsController : ControllerBase
{
    private StudentRepository _studentRepository;
    
    
    //Buscando todos os Students
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_studentRepository.GetAll());
    }
    
    
    
    //Buscando por Id
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {

        return NotFound();
    }
    
    //Salvando estudante
    [HttpPost]
    public IActionResult Save([FromBody] Student? input)
    {

   
        if (input != null )
        {

            return null;

        }
        
        return UnprocessableEntity();
    }
    
    //Atualizando estudantelk
    [HttpPut("{id}")]
    public IActionResult Update([FromBody]Student input, Guid id)
    {
        
        return NotFound();

    }
    
    //Deletando estudante
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        
      //  _dbContext.Students.d;

        return NoContent();
    }
    
    
}
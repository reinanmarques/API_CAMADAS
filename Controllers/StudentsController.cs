using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ESTUDANTES.Controllers;

[Route("api/crud/students")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_studentService.GetAll());
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(_studentService.GetById(id));
    }
    
    [HttpPost]
    public IActionResult Save([FromBody] StudentInsert? input)
    {
        return Ok(_studentService.Save(input));
    }
    
    [HttpPut("{id}")]
    public IActionResult Update([FromBody]StudentUpdate? input, Guid id)
    {
       return Ok(_studentService.Update(input, id));
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _studentService.Delete(id);
        return NoContent();
    }
    
    
}
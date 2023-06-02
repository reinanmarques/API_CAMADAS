using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ESTUDANTES.Controllers;

[Route("api/crud/course")]
[ApiController]
public class CourseController :ControllerBase
{


    private readonly CrudDbContext _dbContext;

    public CourseController(CrudDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_dbContext.Courses);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        return Ok(_dbContext.Courses.
            SingleOrDefault(course => course.Id == id));
    }
    
    [HttpPost]
    public IActionResult Save([FromBody] Course course)
    {
        _dbContext.Courses.Add(course);
        return Created("New Course", course);
    }
    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] Course course)
    {
        var courseResponse = _dbContext.Courses.SingleOrDefault(co => co.Id == id);
        if (courseResponse != null)
        {
            courseResponse.Name = course.Name;
        }

        return Ok(courseResponse);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        //_dbContext.Courses.Remove();
        return NoContent();
    }
    
}
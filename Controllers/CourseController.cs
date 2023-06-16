using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Services;
using CRUD_ESTUDANTES.Services.Contract;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ESTUDANTES.Controllers
{
    [Route("api/course")]
    public class CourseController : Controller
    {

        private ICourseService _courseService;
         public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseService.GetAll()); 
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_courseService.GetById(id));

        } 

        [HttpPost]
        public IActionResult Save(CourseInsert course)
        {
            return Created("curso criado com sucesso", _courseService.Save(course)); 
        }
            
        [HttpPut]
        public IActionResult Update(Guid id, [FromBody] CourseUpdate course)
        {

            return Ok(_courseService.Update(course, id)); 
        }
        
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            _courseService.Delete(id);
            return NoContent(); 
        }
    }
}

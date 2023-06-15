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
    }
}

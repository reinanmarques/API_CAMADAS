
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services.Contract;
using System.Runtime.CompilerServices;

namespace CRUD_ESTUDANTES.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _course;

        public CourseService(ICourseRepository course) 
        {
            _course = course;
        }


        public List<CourseResponse> GetAll()
        {
            return _course.GetAll().Result.ConvertAll(co => new CourseResponse(co.Id, co.Name));
        }

        public CourseResponse GetById(Guid id)
        {
            var course = _course.GetById(id).Result;
            return new CourseResponse(course.Id, course.Name);
            
        }

        public CourseResponse Save(CourseInsert? dto)
        {
            var course = new Course(dto.Name);
            course = _course.Save(course).Result;
            return new CourseResponse(course.Id, course.Name);

        }

        public CourseResponse Update(CourseUpdate? dto, Guid id)
        {
            var course = _course.GetById(id).Result;
            course.Name = dto.Name;
            course = _course.Update(course).Result;
            return new CourseResponse(course.Id, course.Name);
        }


        public void Delete(Guid id)
        {
            var course = _course.GetById(id).Result;
            _course.Delete(course);
        }
    }
}

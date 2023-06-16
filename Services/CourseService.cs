using AutoMapper;
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
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository course, IMapper mapper) 
        {
            _course = course;
            _mapper = mapper;
        }


        public List<CourseResponse> GetAll()
        {
            return _course. GetAll().Result.ConvertAll(co => _mapper.Map<CourseResponse>(co));
        }

        public CourseResponse GetById(Guid id)
        {
            var course = _course.GetById(id).Result;
            return _mapper.Map<CourseResponse>(course);
            
        }

        public CourseResponse Save(CourseInsert? dto)
        {
            var course = _mapper.Map<Course>(dto);
            course = _course.Save(course).Result;
            return _mapper.Map<CourseResponse>(course);

        }

        public CourseResponse Update(CourseUpdate? dto, Guid id)
        {
            var course = _course.GetById(id).Result;
            course.Name = dto.Name;
            course = _course.Update(course).Result;
            return _mapper.Map<CourseResponse>(course);
        }


        public void Delete(Guid id)
        {
            var course = _course.GetById(id).Result;
            _course.Delete(course);
        }
    }
}

using AutoMapper;
using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Repositories.Contract;
using CRUD_ESTUDANTES.Services.Contract;
using System.Runtime.CompilerServices;

namespace CRUD_ESTUDANTES.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _course;
        private readonly IMapper _mapper;

        CourseService(ICourseRepository course, IMapper mapper) 
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
            throw new NotImplementedException();
        }

        public CourseResponse Save(CourseInsert? dto)
        {
            throw new NotImplementedException();
        }

        public CourseResponse Update(CourseUpdate? dto, Guid id)
        {
            throw new NotImplementedException();
        }


        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

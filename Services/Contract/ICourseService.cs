using CRUD_ESTUDANTES.DTO.Request;
using CRUD_ESTUDANTES.DTO.Response;
using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Services.Contract
{

    public interface ICourseService
    {
        public List<CourseResponse> GetAll();
        CourseResponse GetById(Guid id);
        CourseResponse Save(CourseInsert? dto);
        CourseResponse Update(CourseUpdate? dto, Guid id);
        void Delete(Guid id);
    }
}
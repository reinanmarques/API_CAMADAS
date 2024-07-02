namespace CRUD_ESTUDANTES.DTO.Response
{
    public class CourseResponse
    {

        public Guid Id { get; set; }
        public string Name{ get; set; }

        public CourseResponse(string name)
        {
            Name = name;
        }

        public CourseResponse(Guid id, string name){
            Id = id;
            Name = name;
        }
    }
}

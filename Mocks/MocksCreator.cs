using CRUD_ESTUDANTES.Entities;

namespace CRUD_ESTUDANTES.Mocks;

public class MocksCreator
{
    public static List<Student> MocksStudens()
    {
        List<Student> studentsList = new List<Student>();
        studentsList.Add(new Student(Guid.NewGuid(),"Geovana", new Course("Engenharia") ));
        studentsList.Add(new Student(Guid.NewGuid(),"Maria", new Course("Medicina") ));
        studentsList.Add(new Student(Guid.NewGuid(),"João",  new Course("Ciência da Computação") ));

        return studentsList;
    }
}
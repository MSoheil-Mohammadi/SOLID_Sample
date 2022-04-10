using SOLID_Sample.SingleResponsibility.Data;

namespace SOLID_Sample.SingleResponsibility.Entities;
public class PersonV1
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public void AddToRepository(PersonV1 person)
    {
        StudentsRepositoryV1.People.Add(person);
    }
}

using Library.Models;

namespace Library.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModels> GetPeople();
        PersonModels InstertPerson(string firstName, string lastName);
    }
}
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<PersonModels> people = new();
        public DataAccess()
        {
            people.Add(new PersonModels { Id = 1, FirstName = "Amir Mahdi", LastName = "Amini Yazdi" });
            people.Add(new PersonModels { Id = 2, FirstName = "Kim", LastName = "JF" });

        }
        public List<PersonModels> GetPeople()
        {
            return people;
        }
        public PersonModels InstertPerson(string firstName, string lastName)
        {
            PersonModels person = new() { FirstName = firstName, LastName = lastName };
            person.Id = people.Max(x => x.Id) + 1;
            people.Add(person);
            return person;
        }
    }
}

using Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands
{
    public record InsertPersonCommand(string FirstName, string LastName) :IRequest<PersonModels>;
    //public class InsertPersonCommand:IRequest<PersonModels>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public InsertPersonCommand(string firstName,string lastName)
    //    {
    //        FirstName = firstName;  
    //        LastName = lastName;
    //    }
    //}
}

using Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    public record GetPersonListQuery():IRequest<List<PersonModels>>
    {
    }
    //For Comparison
    //public class GetPersonListQueryClass :IRequest<List<PersonModels>> 
    //{ 
    //}
}

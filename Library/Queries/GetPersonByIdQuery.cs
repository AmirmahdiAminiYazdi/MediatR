using Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Queries
{
    public record GetPersonByIdQuery(int Id):IRequest<PersonModels>;

    //public class GetPersonByIdQueryClass: IRequest<PersonModels>
    //{
    //    public int Id { get; set; }

    //    public GetPersonByIdQueryClass(int id)
    //    {
    //        Id = id;
    //    }
    //}

}

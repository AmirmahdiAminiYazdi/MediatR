using Library.Commands;
using Library.DataAccess;
using Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModels>
    {
        private readonly IDataAccess _dataAccess;

        public InsertPersonHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<PersonModels> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InstertPerson(request.FirstName,request.LastName));
        }
    }
}

using System.Collections;
using TelemetryPortal_MVC.Models;
using System.Linq.Expressions;
using System;
namespace TelemetryPortal_MVC.Repository_classes
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetClientById(Guid? id);

    }
}

using System.Collections;
using TelemetryPortal_MVC.Models;
using System.Linq.Expressions;
using System;
namespace TelemetryPortal_MVC.Repository_classes
{
    public interface IProjectRepository: IGenericRepository<Project>
    {
        Project GetProjectById(Guid? id); // Retrieve a project by its ID
    }
}

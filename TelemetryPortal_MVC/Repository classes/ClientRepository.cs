using TelemetryPortal_MVC.Data;

using System.Collections;
using System.Linq.Expressions;
using TelemetryPortal_MVC.Models;
using Microsoft.EntityFrameworkCore;
namespace TelemetryPortal_MVC.Repository_classes
{
    public class ClientRepository : IClientRepository
    {
        private readonly TechtrendsContext _context;

        public ClientRepository(TechtrendsContext context)
        {
            _context = context;
        }

        public Client GetClientById(Guid? id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.ClientId == id);

            if (client == null)
            {
                throw new InvalidOperationException($"Client with ID {id} not found.");
            }

            return client;
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public void Add(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(Client entity)
        {
            _context.Clients.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Client entity)
        {
            _context.Clients.Update(entity);
            bool saveFailed;
            do
            {
                saveFailed = false;
                try
                {
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    // Handle the concurrency conflict
                    var entry = ex.Entries.Single();
                    var databaseValues = entry.GetDatabaseValues();
                    if (databaseValues == null)
                    {
                        throw new InvalidOperationException("The record has been deleted by another user.");
                    }

                    // Update the original values with the current database values
                    var clientFromDb = (Client)databaseValues.ToObject();
                    entry.OriginalValues.SetValues(databaseValues);
                }
            } while (saveFailed);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Repository_classes;

namespace TelemetryPortal_MVC.Controllers
{
    public class ClientsController : Controller
    {
        // private readonly TechtrendsContext _context;
        private readonly IClientRepository _clientRepository;

        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var clients = _clientRepository.GetAll();
            ViewData["ProjectId"] = new SelectList(clients, "ClientId", "ClientName");
            return View(clients);
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientRepository.GetClientById(id.Value);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,ClientName,PrimaryContactEmail,DateOnboarded")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.ClientId = Guid.NewGuid();
                _clientRepository.Add(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientRepository.GetClientById(id.Value);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ClientId,ClientName,PrimaryContactEmail,DateOnboarded")] Client client)
        {
            if (id != client.ClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _clientRepository.Update(client);
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Handle concurrency exception
                    var databaseEntity = _clientRepository.GetClientById(id);
                    if (databaseEntity == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        // Add a custom error message if needed
                        ModelState.AddModelError(string.Empty, "The record you attempted to edit was modified by another user.");
                        return View(client);
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = _clientRepository.GetClientById(id.Value);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var client = _clientRepository.GetClientById(id);
            if (client != null)
            {
                _clientRepository.Remove(client);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}

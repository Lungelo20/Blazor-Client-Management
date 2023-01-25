using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RTT.Client.Pages;
using RTT.Server.Data;

namespace RTT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientDetailController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientDetailController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("ClientContact")]
        public async Task<ActionResult<List<ClientContact>>> GetAllContacts()
        {
            var contacts = await _context.clientContacts.ToListAsync();

            if (contacts == null)
            {
                return NotFound("No contacts where found!");
            }

            return Ok(contacts);
        }

        [HttpGet("ClientAddress")]
        public async Task<ActionResult<List<ClientAddress>>> GetAllAddresses()
        {
            var addresses = await _context.clientAddresses.ToListAsync();

            if (addresses == null)
            {
                return NotFound("No addresses where found!");
            }

            return Ok(addresses);
        }
        [HttpGet]
        public async Task<ActionResult<List<ClientDetails>>> GetAllClients()
        {
            var clients = await _context.clientDetails.Include(sh => sh.Contacts).Include(sh => sh.Addresses).ToListAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDetails>> GetAClient(int id)
        {
            var client = await _context.clientDetails
               .Include(h => h.Contacts)
               .Include(h => h.Addresses)
               .FirstOrDefaultAsync(h => h.Id == id);
            if (client == null)
            {
                return NotFound("No clients where found!");
            }

            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<List<ClientDetails>>> AddClient(ClientDetails client)
        {
            _context.clientDetails.Add(client);
            await _context.SaveChangesAsync();

            return Ok(await GetDbClients());
        }
        

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ClientDetails>>> UpdateClient(ClientDetails client, int id)
        {

            var dbclient = await _context.clientDetails
                .Include(h => h.Contacts)
                .Include(h => h.Addresses)
                .FirstOrDefaultAsync(sh => sh.Id == id);

            //var dbAddresses = await _context.clientAddresses.Where(h => h. == id);

            if (dbclient == null)
            {
                return NotFound("Sorry, but no client for you. :/");
            }

            dbclient.Name = client.Name;
            dbclient.Gender = client.Gender;
            dbclient.Status = client.Status;

            foreach (var address in client.Addresses)
            {
                    dbclient.Addresses = client.Addresses;
            }

            foreach (var contact in client.Contacts)
            {
                
                    dbclient.Contacts = client.Contacts;
                
            }

            await _context.SaveChangesAsync();

            return Ok(await GetDbClients());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ClientDetails>>> DeleteClient(int id)
        {
            var dbClient = await _context.clientDetails
                .Include(sh => sh.Contacts)
                .Include(sh => sh.Addresses)
                .FirstOrDefaultAsync(sh => sh.Id == id);
            if (dbClient == null)
                return NotFound("Sorry, but no Client for you. :/");

            _context.clientDetails.Remove(dbClient);
            await _context.SaveChangesAsync();

            return Ok(await GetDbClients());
        }
            
        private async Task<List<ClientDetails>> GetDbClients()
        {
            return await _context.clientDetails.Include(sh => sh.Contacts).Include(sh => sh.Addresses).ToListAsync();
        }
    }
}

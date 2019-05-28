using System.Collections.Generic;
using System.Threading.Tasks;
using Miguel.Db;
using Miguel.Models;
using Microsoft.EntityFrameworkCore;

namespace Miguel.Services
{
    public class ClientService : IClientService
    {
        private AppDbContext context;
        public ClientService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IList<Client>> GetAll()
        {
            
            return await context.Clients.ToListAsync();
        }
    }
}
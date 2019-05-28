using System.Collections.Generic;
using System.Threading.Tasks;
using Miguel.Models;

namespace Miguel.Services
{
    public interface IClientService
    {
         Task<IList<Client>> GetAll();
    }
}
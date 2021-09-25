using System.Threading.Tasks;
using WebClient.Models;

namespace WebClient.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}

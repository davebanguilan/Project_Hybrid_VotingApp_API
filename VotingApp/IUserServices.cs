using System.Threading.Tasks;
using VotingApp.DTO;

namespace VotingApp
{
    public interface IUserServices
    {
        Task<AuthenticatedUser> SignUp(User user);
        Task<AuthenticatedUser> SignIn(User user);
    }
}

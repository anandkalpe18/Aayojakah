using Aayojakah.Model;
using System.Linq;

namespace Aayojakah.Interface
{
    public interface IRegistration
    {
        int AddUser(Registration entity);
        void AddAdmin(Registration entity);
        bool CheckUserNameExists(string Username);
        RegistrationViewModel Userinformation(int UserID);
        RegistrationViewModel Admininformation(int AdminID);
        IQueryable<RegistrationViewModel> UserinformationList(string sortColumn, string sortColumnDir, string Search);

    }
}

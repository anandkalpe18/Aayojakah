using Aayojakah.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aayojakah.Interface
{
    public interface ILogin
    {
        Registration ValidateUser(string userName, string passWord);
        bool UpdatePassword(Registration Registration);
    }
}

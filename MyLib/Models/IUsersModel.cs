using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Models
{
   public interface IUsersModel
    {
        void LoadInfoUsers();
        List<User> ReturnUsers();
        List<User> GetUsers();
        void FiltrUserData(string NameFiltr, string input);
        void ChangeUser(User u, int index);

        event Action SuccessLoadedInfoUsers;
    }
}

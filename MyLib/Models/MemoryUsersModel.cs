using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> _users = new List<User>();
        private List<User> FiltrUser = new List<User>();
        public event Action SuccessLoadedInfoUsers;

        public List<User> GetUsers()
        {
            return FiltrUser;
        }

        public void LoadInfoUsers()
        {
            _users.Add(new User {Login = "Тимон", Password = "123", Name = "Артем", Surname = "Клименков", Email = "ponchikBeac@gmail.com", Avatar = "D://П-30/9c1eaeb920efbd0b874b0f774ba7bb67.jpg", DateBirth = new DateTime(2006, 08, 14) });
            _users.Add(new User {Login = "ФрикОувенс", Password = "321", Name = "Егор", Surname = "Глагольев", Email = "egor1k@gmail.com", Avatar = "D://П-30/8f4ac3366b60bae02466da0188555d0e.jpg", DateBirth = new DateTime(2006, 09, 25) });
            _users.Add(new User {Login = "BO$$S", Password = "213", Name = "Илья", Surname = "Сазонов", Email = "ilyas@gmail.com", Avatar = "D://П-30/1-1024x683.jpg", DateBirth = new DateTime(2006, 02, 08) });
            _users.Add(new User {Login = "Саидик", Password = "312", Name = "Саид", Surname = "Мужаидов", Email = "said@gmail.com", Avatar = "D://П-30/PLxvO_0GKQc.jpg", DateBirth = new DateTime(2005, 07, 15) });

            FiltrUser = _users;


            SuccessLoadedInfoUsers.Invoke();
        }

        public void FiltrUserData(string NameFiltr, string input)
        {
            if (input == "Имя")
            {
                FiltrUser = _users.Where(p => p.Name.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
            if (input == "Логин")
            {
                FiltrUser = _users.Where(p => p.Login.Contains(NameFiltr)).ToList();
                SuccessLoadedInfoUsers.Invoke();
            }
        }
        public void UserChange(User u)
        {
            foreach (User current in _users)
            {
                if (current.login == u.login)
                {
                    current.Name = u.Name;
                    current.Surname = u.Surname;
                    current.Email = u.Email;
                    SuccessLoadedInfoUsers.Invoke();
                }
            }
           
            
        }

        public List<User> ReturnUsers()
        {
            return _users;
        }

        public void ChangeUser(User u, int index)
        {
            User current = _users[index];
            current.Name = u.Name;
            current.Surname = u.Surname;
            current.Email = u.Email;
            SuccessLoadedInfoUsers.Invoke();

        }

    }
}

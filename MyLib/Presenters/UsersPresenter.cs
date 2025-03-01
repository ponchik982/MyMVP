using MyLib.Models;
using MyLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Presenters
{
    public class UsersPresenter
    {
        private IUsersModel model_;
        private IUsersView view_;
        private IUserCard card_;


        public UsersPresenter(IUsersModel model, IUsersView view, IUserCard card)
        {
            model_ = model;
            view_ = view;
            card_ = card;
  
            model_.SuccessLoadedInfoUsers += Model__SuccessLoadedInfoUsers;
            model_.LoadInfoUsers();
            card_.UserChange += Card__UserChange;
        }

        private void Card__UserChange(User obj)
        {
            Model__ChangedUser(obj);
        }
       
        public void View__FiltrEvent(string FiltrOrder, string input)
        {

            model_.FiltrUserData(FiltrOrder, input);
        }

        public void Model__RefreshLoadedInfoUsers()
        {
            view_.Show(model_.ReturnUsers());
        }

        private void Model__SuccessLoadedInfoUsers()
        {
            view_.Show(model_.GetUsers());
        }

        public void View__SelectedUser(int number)
        {
           User u = model_.GetUsers()[number];
           card_.Show(u);
        }

        public void Model__ChangedUser(User u, int index)
        {
            model_.ChangeUser(u, index);
        }
    }

  
}

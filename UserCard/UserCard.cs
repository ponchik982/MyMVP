using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;
using MyLib.Presenters;
using MyLib.Views;
using MyLib.Models;
using Microsoft.Win32;

namespace UserCard
{
    public partial class UserCard: UserControl, MyLib.Views.IUserCard
    {
        private object u;

        public UserCard()
        {
            InitializeComponent();
        }

        public event Action<User> UserChange;

        public void Show(User u)
        {
            loginTextBox.Text = u.Login;
            nameTextBox.Text = u.Name;
            surnameTextBox.Text = u.Surname;
            emailTextBox.Text = u.Email;
            picture.Image = Image.FromFile(u.Avatar);
          
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Login = loginTextBox.Text;
            u.Name = nameTextBox.Text;
            u.Surname = surnameTextBox.Text;
            u.Email = emailTextBox.Text;
            UserChange.Invoke(u);
        }

        private void UserCard_Load(object sender, EventArgs e)
        {

        }
    }
}

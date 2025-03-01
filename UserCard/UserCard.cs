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

namespace UserCard
{
    public partial class UserCard: UserControl, MyLib.Views.IUserCard
    {
        private object u;

        public UserCard()
        {
            InitializeComponent();

        }

        public void Show(User u)
        {
            nameTextBox.Text = u.Name;
            surnameTextBox.Text = u.Surname;
            emailTextBox.Text = u.Email;
            picture.Image = Image.FromFile(u.Avatar);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

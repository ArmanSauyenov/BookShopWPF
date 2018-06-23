using BookShop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookShop.Views
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();

            ProfileGrid.DataContext = MainWindow.user;
        }
        shop db = new shop();
        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            User user = (User)ProfileGrid.DataContext;
            User u = db.User.Find(user.UserId);
            u.Login = user.Login;
            u.Password = user.Password;
            u.Email = user.Email;
            //db.Entry(u).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}

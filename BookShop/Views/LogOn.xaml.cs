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
    /// Interaction logic for LogOn.xaml
    /// </summary>
    public partial class LogOn : Page
    {
        private shop db = new shop(); 
        public LogOn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var result = from u in db.User
            //             where u.Login == UName.Text
            //             && u.Password == Pass.Password
            //             select u;

            User user = db.User.FirstOrDefault(u => u.Login == UName.Text && u.Password == Pass.Password);

            if (user != null)
            {
                MainWindow.user = user;
                MainWindow.leftFrame.Source = new Uri("Views/LogOnOk.xaml", UriKind.RelativeOrAbsolute);
            }
            else
                MessageBox.Show("Invalid login or password");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.centalFrame.Source = new Uri("Views/RegistrationPage.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}

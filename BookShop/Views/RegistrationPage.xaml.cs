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
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            User us = new User();
            us.Login = tbBox.Text;
            us.Password = tbBox2.Text;
            us.Email = tbBox3.Text;

            shop db = new shop();
            db.User.Add(us);
            try
            {
                db.SaveChanges();
                MessageBox.Show("User successfully added");
                MainWindow.centalFrame.Source = new Uri("Views/CentralPage.xaml", UriKind.RelativeOrAbsolute);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

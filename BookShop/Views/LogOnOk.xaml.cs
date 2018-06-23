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
    /// Interaction logic for LogOnOk.xaml
    /// </summary>
    public partial class LogOnOk : Page
    {
        public LogOnOk()
        {
            InitializeComponent();

            userName.Content = 
                string.Format("{0} ({1})",
                MainWindow.user.Login, MainWindow.user.UserId);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.centalFrame.Source = new Uri("Views/Profile.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}

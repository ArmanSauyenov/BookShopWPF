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

namespace BookShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame leftFrame;
        public static Frame centalFrame;
        public static User user;
        public MainWindow()
        {
            InitializeComponent();
            user = null;
            LeftFrame.Source = new Uri("Views/LogOn.xaml", UriKind.RelativeOrAbsolute);
            leftFrame = LeftFrame;
            CentralFrame.Source = new Uri("Views/CentralPage.xaml", UriKind.RelativeOrAbsolute);
            centalFrame = CentralFrame;
        }
    }
}

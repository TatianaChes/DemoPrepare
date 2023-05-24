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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBaseProject.BookEntities _context = new DataBaseProject.BookEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            var query = _context.Users.Where(t => t.login == login.Text && t.password == password.Password).FirstOrDefault();
            if (query != null)
            {
                WindowsProject.ProductList productList = new WindowsProject.ProductList(query.id_role);
                productList.Show();
                this.Close();
            }
            else {
                MessageBox.Show("проверьте логин и пароль!");
            }
        }

        private void guest_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WindowsProject.ProductList productList = new WindowsProject.ProductList(0);
            productList.Show();
            this.Close();
        }
    }
}

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
using System.Windows.Shapes;

namespace WpfApp1.WindowsProject
{
    /// <summary>
    /// Логика взаимодействия для ProductList.xaml
    /// </summary>
    public partial class ProductList : Window
    {
        int _role;
        DataBaseProject.BookEntities _context = new DataBaseProject.BookEntities();
        public ProductList(int role)
        {
            InitializeComponent();
            listProduct.ItemsSource = _context.Product.ToList();
            _role = role;
            if (_role == 3)
            {
                orders.Visibility = Visibility.Visible;
                products.Visibility = Visibility.Visible;
            }
            if (_role == 2) {
                orders.Visibility = Visibility.Visible;
            }
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {
            WindowsProject.Orders orderWindow = new WindowsProject.Orders();
            orderWindow.Show();
        }

        private void products_Click(object sender, RoutedEventArgs e)
        {
            WindowsProject.Products productWindow = new WindowsProject.Products();
            productWindow.Show();
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            save.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            save.Visibility = Visibility.Visible;
        }
    }
}

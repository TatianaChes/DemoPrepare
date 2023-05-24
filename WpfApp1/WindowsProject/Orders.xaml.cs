using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        DataBaseProject.BookEntities _context = new DataBaseProject.BookEntities();
        public Orders()
        {
            InitializeComponent();
            client.ItemsSource = _context.Users.ToList();
            point.ItemsSource = _context.PickPoint.ToList();
            product.ItemsSource = _context.Product.ToList();
            Refresh();
            
        }

        private void Refresh()
        {
            var query = from Order in _context.Order
                        join Users in _context.Users on Order.id_client equals Users.id_user
                        join PickPoint in _context.PickPoint on Order.id_point equals PickPoint.id_point
                        join Product in _context.Product on Order.id_product equals Product.id_product
                        select new
                        {

                            client = Users.name + " " + Users.surname,
                            point = PickPoint.city + " " + PickPoint.street + " " + PickPoint.house,
                            date = Order.date,
                            product = Product.name,
                            code = Order.code
                        };
            dataGrid.ItemsSource = query.ToList();
        }

        private void DataGrid_Selected(object sender, RoutedEventArgs e)
        {
        
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            var query = _context.Order.Where(t => t.code == code.Text).FirstOrDefault();

            try
            {
                query.id_client = client.SelectedIndex + 1;
                query.id_point = point.SelectedIndex + 1;
                query.id_product = product.SelectedIndex + 1;
                _context.SaveChanges();
                Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("Заказ изменен!");
            }

        }
    }
}

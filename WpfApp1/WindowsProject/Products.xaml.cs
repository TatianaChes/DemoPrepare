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
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        DataBaseProject.BookEntities _context = new DataBaseProject.BookEntities();
        DataBaseProject.Product pr;
        string imgpath = null;
        public Products()
        {
            InitializeComponent();
            string[] stat = { "Новый", "Не новый" };
            status.ItemsSource = stat;
            Refresh();
           
        }

        private void Refresh()
        {
            dataGrid.ItemsSource = _context.Product.ToList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _context.Product.Add(new DataBaseProject.Product
                {
                    id_product = _context.Product.Count() + 2,
                    name = nameT.Text,
                    description = descriptionT.Text,
                    cost = Convert.ToDecimal(priceT.Text),
                    discount = Convert.ToInt32(discountT.Text),
                    status = status.SelectedItem.ToString(),
                    countOfPoint = Convert.ToInt32(countT.Text),
                    manufactory = manufactoryT.Text,
                    photo = imgpath
                }); ;
                _context.SaveChanges();
                MessageBox.Show("Добавление прошло успешно");
                Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            try
            {

           
                pr.name = nameT.Text;
                pr.description = descriptionT.Text;
                pr.cost = Convert.ToDecimal(priceT.Text);
                pr.discount = Convert.ToInt32(discountT.Text);
                pr.status = status.SelectedItem.ToString();
                pr.countOfPoint = Convert.ToInt32(countT.Text);
                pr.manufactory = manufactoryT.Text;
                pr.photo = imgpath;
              
                _context.SaveChanges();
                MessageBox.Show("Изменение прошло успешно");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить товар?", "Оповещение", MessageBoxButton.YesNo, MessageBoxImage.None );
            if (MessageBoxResult.Yes == result) {
                try
                {
                    _context.Product.Remove(pr);
                    _context.SaveChanges();
                    MessageBox.Show("Удаление прошло успешно");
                    Refresh();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGrid_Selected(object sender, RoutedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            pr = (DataBaseProject.Product)dg.SelectedItems[0];
        }
    }
}

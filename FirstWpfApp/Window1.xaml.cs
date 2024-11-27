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

namespace FirstWpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
           var converter=new PointTypeConvertor();
            var point = converter.ConvertFrom("100,200");
            txtConvert.Text = point.ToString();
            myBtn.Content = "Check Me";
            listData.Items.Add("Toffee");
            listData.Items.Add("Coffee");
            listData.Items.Add("Chocolate");
        }

        private void listData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblItem.Content="You selected "+listData.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person
            {
                Age=Convert.ToInt32(txtAge.Text),
                Name=txtName.Text,
                Address=txtAddress.Text,
            };
            listData.Items.Add(person);
        }
    }
}

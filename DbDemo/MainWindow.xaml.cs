using Newtonsoft.Json;
using Newtonsoft;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace DbDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmpContext context ;
        public MainWindow()
        {
            InitializeComponent();
            context = new EmpContext();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            var data = context.Emp.ToList();
            dg1.ItemsSource = data.ToList();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Emp emp = new Emp() { Name = "NewName", Address = "123abc" };
            txtNewData.Text=JsonConvert.SerializeObject(emp);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var names=(from a in context.Emp
                       select a.Name).ToList();

            foreach (var item in names)
            {
                cmbNames.Items.Add(item);
            }
        }

        private void cmbNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNewData.Text="You selected "+cmbNames.SelectedItem.ToString();
        }
    }
}
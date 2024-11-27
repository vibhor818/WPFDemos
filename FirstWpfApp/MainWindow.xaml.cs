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
using Newtonsoft;
using Newtonsoft.Json;
using DAL;
namespace FirstWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataOperation _oper;
        public MainWindow()
        {
            InitializeComponent();
            _oper=new DataOperation();
            Button btn1=new Button();
            btn1.Content = "Add";
            btn1.Height = 100;
            btn1.Width = 100;
            btn1.Click += btn_Click;
            //btn.Background = new SolidColorBrush(Colors.Red);
            this.grid1.Children.Add(btn1);
            
        }
        
        private void btn_Click(object sender, RoutedEventArgs e)
        {
           
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            // lblAns.Content = "Please check "+_oper.Add(10, 20);
            lblAns.Content = $"Please check {_oper.Add(num1,num2)}" ;
        }
    }
}
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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void btnCallTest(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.ToolTip = "This is dynamic tooltip";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                btn.ToolTip = "This is dynamic tooltip";
            }
        }
    }
}

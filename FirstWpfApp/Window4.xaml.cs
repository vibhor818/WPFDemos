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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            string address = AddrssTextBox.Text;
            string gender = "Not specified";
            Person per = new Person
            {
                Age = Convert.ToInt32(age),
                Name = name,
                Address=address,
                Gender=gender
                
            };
            if (MaleRadioButton.IsChecked == true)
                gender = "Male";
            else if (FemaleRadioButton.IsChecked == true)
                gender = "Female";
            bool isSaved = SaveToDbCheckBox.IsChecked == true;
            

            OutputTextBlock.Text = $"Name :{name}\n"+
                                    $"Age :{age}\n" +
                                    $"Address :{address}\n"+
                                    $"Gender :{gender}\n"+
                                    $"Saved to DB  :{ isSaved}";
        }
    }
}

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

namespace CheckBoxRadioWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve input data
            string name = NameTextBox.Text;
            string age = AgeTextBox.Text;
            string address = AddressTextBox.Text;

            // Determine selected gender
            string gender = "Not specified";
            if (MaleRadioButton.IsChecked == true)
                gender = "Male";
            else if (FemaleRadioButton.IsChecked == true)
                gender = "Female";
            else if (OtherRadioButton.IsChecked == true)
                gender = "Other";

            // Check if preferences are selected
            bool isSubscribed = SubscribeCheckBox.IsChecked == true;

            // Display the output
            OutputTextBlock.Text = $"Name: {name}\n" +
                                   $"Age: {age}\n" +
                                   $"Address: {address}\n" +
                                   $"Gender: {gender}\n" +
                                   $"Subscribed to Newsletter: {isSubscribed}";
        }
    }
}
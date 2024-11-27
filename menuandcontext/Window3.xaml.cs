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



namespace MenuExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Attach Command Bindings
            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, NewCommand_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenCommand_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, SaveCommand_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, CutCommand_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, CopyCommand_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, PasteCommand_Executed));
        }

        // Command Handlers
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Clear();
            MessageBox.Show("New file created!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open file dialog would appear here!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save file dialog would appear here!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Cut();
        }

        private void CopyCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Copy();
        }

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Paste();
        }

        // Exit Menu Item Click
        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Enable Feature Menu Item Click
        private void EnableFeatureMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;

            if (menuItem.IsChecked)
            {
                MessageBox.Show("Feature Enabled!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Feature Disabled!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        // About Menu Item Click
        private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a demo application showcasing WPF Menus.", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}


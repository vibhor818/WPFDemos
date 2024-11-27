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

namespace DbDemo
{
    /// <summary>
    /// Interaction logic for MenuEx.xaml
    /// </summary>
    public partial class MenuEx : Window
    {
        public static RoutedCommand VBCommand = new RoutedCommand();
        public MenuEx()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, VBCut));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, VBCopy));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, VBPaste));
        }

        private void VBPaste(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Paste();
        }

        private void VBCopy(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Copy();
        }

        private void VBCut(object sender, ExecutedRoutedEventArgs e)
        {
            MainTextBox.Cut();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I have been updated");
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("I've finished the task.");
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}

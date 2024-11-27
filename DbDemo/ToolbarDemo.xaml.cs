using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ToolbarDemo.xaml
    /// </summary>
    public partial class ToolbarDemo : Window
    {
        public ToolbarDemo()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, Save_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Help, Help_Executed));
        }

        private void Help_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("This is help box for your subject");
            StatusText.Text = "Help opened";
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open RTF file",
                Filter = "VBRTB File (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory()
            };
            if (ofd.ShowDialog() == true)
            {
               
               StatusText.Text=$"Opened file: {ofd.FileName}";
                MainContent.Text=File.ReadAllText(ofd.FileName);
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            StatusText.Text = "Content saved";
        }
    }
}

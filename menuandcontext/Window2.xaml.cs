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

namespace menuandcontext
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open RTF File",
                Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory()
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    using (FileStream fileStream = new
                        FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        TextRange textRange = new
                            TextRange(MainRichTextBox.Document.ContentStart,
                            MainRichTextBox.Document.ContentEnd);
                        textRange.Load(fileStream, DataFormats.Rtf);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save RTF File",
                Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName = "Untitled.rtf"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (FileStream fileStream = new FileStream(filePath,
                        FileMode.Create, FileAccess.Write))
                    {
                        TextRange textRange = new
        TextRange(MainRichTextBox.Document.ContentStart,
        MainRichTextBox.Document.ContentEnd);
                        textRange.Save(fileStream, DataFormats.Rtf);
                    }

                    MessageBox.Show("File saved successfully!", "File Saved",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

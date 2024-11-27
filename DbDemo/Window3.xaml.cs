using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        CustomDialog dialog;
        private void OpenCustomDialog_Click(object sender, RoutedEventArgs e)
        {
            //using (CustomDialog dialog = new CustomDialog())
            //{
            //    dialog.Owner = this;
            //    dialog.Sam = "Test";
            // };
            //dialog.Show();
            if (dialog == null || !dialog.IsLoaded)
            {
                dialog = new CustomDialog() { Owner = this };
                dialog.Show();
                this.grid1.Children.Add(dialog);
                
            }
            //dialog.ShowDialog();
            //bool? result = dialog.ShowDialog();
            //if (result == true)
            //{
            //    MessageBox.Show("Dialog closed with OK","Info",MessageBoxButton.OK, MessageBoxImage.Information);
            //}
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open RTF file",
                Filter = "VBRTB File (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory()
            };
            if (ofd.ShowDialog()==true)
            {
                string filePath = ofd.FileName;
                try 
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        TextRange textRange = new TextRange(vbRtb.Document.ContentStart, vbRtb.Document.ContentEnd);
                        textRange.Load(fileStream, DataFormats.Rtf);
                    }
                } 
                catch (IOException ex)
                { 
                    MessageBox.Show($"Error opening file: {ex.Message}","Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {

                Title = "Open RTF file",
                Filter = "VBRTB File (*.rtf)|*.rtf|All Files (*.*)|*.*",
                InitialDirectory = Directory.GetCurrentDirectory(),
                FileName="vbunset.rtf"
            };
            if (sfd.ShowDialog() == true)
            {
                string filePath = sfd.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        TextRange textRange = new TextRange(vbRtb.Document.ContentStart, vbRtb.Document.ContentEnd);
                        textRange.Save(fileStream, DataFormats.Rtf);
                    }
                    MessageBox.Show($"File Saved successfully:" , "File Saved",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error opening file: {ex.Message}", "Error",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("This is msg box","Msg Box",MessageBoxButton.OKCancel);
        //}
    }
}

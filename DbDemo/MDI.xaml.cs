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
    /// Interaction logic for MDI.xaml
    /// </summary>
    public partial class MDI : Window
    {
        public MDI()
        {
            InitializeComponent();
        }
        private void NewChildWindow_Click(object sender, RoutedEventArgs e)
        {
            var childWindow = new ChildWindow
            {
                Title = "Child Window " + (mdiCanvas.Children.Count + 1)
            };

            childWindow.Owner = this;  // Set the MDI parent
            childWindow.Show();
            
            // Add child window to the canvas
            mdiCanvas.Children.Add(childWindow);
            Canvas.SetLeft(childWindow, 50 * mdiCanvas.Children.Count); // Position child window
            Canvas.SetTop(childWindow, 50 * mdiCanvas.Children.Count);  // Adjust vertical position
        }

        // Exit the application
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}


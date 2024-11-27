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
    /// Interaction logic for BinaryResDemo.xaml
    /// </summary>
    public partial class BinaryResDemo : Window
    {
        public BinaryResDemo()
        {
            InitializeComponent();
            LoadBinaryResource();
        }

        private void LoadBinaryResource()
        {
            var resourceUri = new Uri("pack://application:,,,/Assets/first.jpg");
            var resourceStream = Application.GetResourceStream(resourceUri).Stream;
            if (resourceStream != null )
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = resourceStream;
                bitmap.CacheOption= BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                ImageDisplay.Source=bitmap;
            }
        }
    }
}

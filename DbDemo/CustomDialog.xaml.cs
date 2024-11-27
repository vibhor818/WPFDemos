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
    /// Interaction logic for CustomDialog.xaml
    /// </summary>
    public partial class CustomDialog : Window,IDisposable
    {
        public string Sam { get; set; }
        public bool IsDragging;
        public Point mouseOffset;
        public CustomDialog()
        {
            InitializeComponent();
            //MouseLeftButtonDown += CustomDialog_MouseLeftButtonDown;
            //MouseMove += CustomDialog_MouseMove;
            //MouseLeftButtonUp += CustomDialog_MouseLeftButtonUp;
        }

        private void CustomDialog_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //IsDragging = false;
            //this.ReleaseMouseCapture();
        }

        private void CustomDialog_MouseMove(object sender, MouseEventArgs e)
        {
            //if (IsDragging)
            //{
            //    var mousePos=e.GetPosition(this.Owner);
            //    var X = mousePos.X - mouseOffset.X;
            //    var Y= mousePos.Y - mouseOffset.Y;
            //    Canvas.SetLeft(this, X);
            //    Canvas.SetTop(this, Y);
            //}
        }

        private void CustomDialog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //IsDragging = true;
            //mouseOffset= e.GetPosition(this);
            //this.CaptureMouse();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Dispose()//using will explicit call this method
        {
            //throw new NotImplementedException();
            GC.AddMemoryPressure(int.MaxValue);
        }
    }
}

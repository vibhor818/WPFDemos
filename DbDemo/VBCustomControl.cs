using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DbDemo
{
    public class VBCustomControl:Control
    {
        

        public static readonly DependencyProperty CustomNameProperty =
            DependencyProperty.Register("CustomName", typeof(string), typeof(VBCustomControl), 
                new FrameworkPropertyMetadata(
                    string.Empty,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    OnCustomNameChanged
                    ));

        private static void OnCustomNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           var control=d as VBCustomControl;
            string oldValue = (string)e.OldValue;
            string NewValue = (string)e.NewValue;
            MessageBox.Show($"CustomName changed from '{oldValue}' to '{NewValue}'", "Property Changed");
        }

        public int CustomName
        {
            get { return (int)GetValue(CustomNameProperty); }
            set { SetValue(CustomNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _height;
        private double _lowRadius;
        private double _upRadius;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void paste()
        {
            if (height_.Text != null)
                _height = Convert.ToDouble(this.height_.Text);
            else
                _height = 0;
            if (lowRadius_.Text != null)
                _lowRadius = Convert.ToDouble(this.lowRadius_.Text);
            else
                _lowRadius = 0;
            if (upRadius_.Text != null)
                _upRadius = Convert.ToDouble(this.upRadius_.Text);
            else
                _upRadius = 0;

            Debug.WriteLine("paste");
        }

        




        private void LowArea_OnClick(object sender, RoutedEventArgs e)
        {
            paste();
            area area = new area(_lowRadius);
            area.show();
            Debug.WriteLine("LowAreaClick");
        }

        private void ConeVolume_OnClick(object sender, RoutedEventArgs e)
        {
            paste();
            cutVolume volume = new cutVolume(_height, _lowRadius, _upRadius);
            volume.show();
            Debug.WriteLine("ConeVolumeClick");
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool betoltott=false;

        public MainWindow()
        {
            InitializeComponent();
            this.betoltott=true;
        }

        double[] ertekek = new double[4] { 1, 1, 1, 1 };
        private void Csusz1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[0] = csusz1.Value;
                fa1.Opacity = (1 - ertekek[0]) * ertekek[1];
                fa2.Opacity = ertekek[0] * ertekek[3];
            }
        }

        private void csusz4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (betoltott)
            {
                ertekek[1] = csusz2.Value;
                fa1.Opacity = (1 - ertekek[0]) * ertekek[1];
                fa3.Opacity = ertekek[0] * ertekek[3];
            }
        }

        private void csusz2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ertekek[0] = csusz1.Value;
            fa3.Opacity = (1 - ertekek[0]) * ertekek[1];
            fa4.Opacity = ertekek[0] * ertekek[3];
        }
    }
}

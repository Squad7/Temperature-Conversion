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

namespace Temperature_Conversion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Celcius Value is {FtoC()}: ");
        }

        public string FtoC()
        {
            if (FahrenheitBox.Text != "")
            {
               double C = ((double.Parse(FahrenheitBox.Text) - 32) / 9) * 5;
                return C.ToString(); yy 
            }
            return "";
        }
    }
}

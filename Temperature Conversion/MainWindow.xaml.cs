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

        //This converts Fahrenheit into Celcius 
        public string FtoC()
        {
            if (FahrenheitBox.Text != "")
            {
                int temp;
                if (int.TryParse(FahrenheitBox.Text, out temp))
                {
                    double C = ((double.Parse(FahrenheitBox.Text) - 32) / 9) * 5;
                    return C.ToString();
                }
                else
                {
                    MessageBox.Show("Please eneter a number");
                }
            }
            return "";
        }

        //This converts Celcius into Fahrenheight
        public string CtoF()
        {
            if (CelciusBox.Text != "")
            {
                int temp;
                if (int.TryParse(CelciusBox.Text, out temp))
                {
                    double F = ((double.Parse(CelciusBox.Text) * 9) / 5) + 32;
                    return F.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a number");
                }
            }
            return "";
        }

       private void FahrenheitBox_TextChanged(object sender, TextChangedEventArgs e)
       {
            if (FahrenheitBox.IsFocused)
            {
                CelciusBox.Text = FtoC();

            }
                
       }


        private void CelciusBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CelciusBox.IsFocused)
            {

                FahrenheitBox.Text = CtoF();
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            CelciusBox.Clear();
            FahrenheitBox.Clear();
        }
    }
}

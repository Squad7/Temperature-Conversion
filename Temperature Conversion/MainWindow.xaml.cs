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
            //Checks if there is an input into input box
            if (FahrenheitBox.Text != "")
            {
                //Converts the input into a double data type
                //Checks if the input is a number
                double tempF;
                if (double.TryParse(FahrenheitBox.Text, out tempF)|| FahrenheitBox.Text == "-")
                {
                    //If it is a number, an image is allowed to display
                    TempIMG.Visibility = Visibility.Visible;

                    //If the input into Fahrenheit box is equal to or less than 59, cold graphifical depiction shows
                    if (tempF <= 59)
                    {

                        TempIMG.Source = new BitmapImage(new Uri("Resources/COLD.png", UriKind.Relative));
                    }

                    //If the input into Fahrenheit box is greater than 59 and less than 86, mild graphifical depiction shows
                    else if (tempF > 59 && tempF < 86)
                    {
                        TempIMG.Source = new BitmapImage(new Uri("Resources/MILD.jpg", UriKind.Relative));
                    }

                    //If the input into Fahrenheit box is equal to or greater than 86, hot graphifical depiction shows
                    else if (tempF >= 86)
                    {
                        TempIMG.Source = new BitmapImage(new Uri("Resources/HOT.jpg", UriKind.Relative));
                    }
                    //Converts Fahrenheit to Celcius
                    double C = (tempF - 32) / 9 * 5;
                    return C.ToString();
                   
                }
                else
                {
                    MessageBox.Show("Please eneter a number");
                }
            }
            //If there is no input into input box no image displays
            TempIMG.Visibility = Visibility.Hidden;
            return "";
        }

        //This converts Celcius into Fahrenheit
        public string CtoF()
        {
            // Checks if there is an input into input box
            if (CelciusBox.Text != "")
            {
                //Converts the input text into a double data type
                //Checks if the input text is a number
                double temp;
                if (double.TryParse(CelciusBox.Text, out temp)|| CelciusBox.Text == "-")
                {
                    TempIMG.Visibility = Visibility.Visible;

                    //If the input into Celcius box is equal to or less than 15, cold graphifical depiction shows
                    if (temp <= 15)
                    {
                        //If it is a number, an image is allowed to display
                        TempIMG.Source = new BitmapImage(new Uri("Resources/COLD.png", UriKind.Relative));
                    }

                    //If the input into Celcius box is greater than 15 and less than 30, mild graphifical depiction shows
                    else if (temp > 15 && temp < 30)
                    {
                            TempIMG.Source = new BitmapImage(new Uri("Resources/MILD.jpg", UriKind.Relative));         
                    }

                    //If the input into Celcius box is equal to or greater than 30, hot graphifical depiction shows
                    else if (temp >= 30)
                    {
                            TempIMG.Source = new BitmapImage(new Uri("Resources/HOT.jpg", UriKind.Relative));
                    }

                    //Converts Celcius to Fahrenheit
                    double F = (temp * 9) / 5 + 32;
                    return F.ToString();

                }
                else
                {
                    
                    MessageBox.Show("Please enter a number");
                }
            }
            //If there is no input into input box no image displays
            TempIMG.Visibility = Visibility.Hidden;
            return "";

        }


        //Automatically converts inputs from Fahrenheight to Celcius
       private void FahrenheitBox_TextChanged(object sender, TextChangedEventArgs e)
       {
            if (FahrenheitBox.IsFocused)
            {
                CelciusBox.Text = FtoC();

            }
                
       }


        //Automatically converts inputs from Celcius to Fahrenheight
        private void CelciusBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CelciusBox.IsFocused)
            {

                FahrenheitBox.Text = CtoF();
            }
        }

        //Clears both text boxes
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            CelciusBox.Clear();
            FahrenheitBox.Clear();
        }

    }
}

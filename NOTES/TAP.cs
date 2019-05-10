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

namespace ToSaWPF
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

        private void randomNumberGenerator_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            int number = random.Next(1,1000000000);

            numberTextBox.Text = number.ToString();
        }
        
        //The Task asynchronous programming model in C#
        private async void checkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(numberTextBox.Text);

                await ShowCalculationResultsAsync(number);
                
            }
            catch(FormatException formatexception)
            {
                MessageBox.Show(formatexception.Message, "The input number is not in the correct format.");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "There was an onexpected error.");
            }
        }

        private async Task ShowCalculationResultsAsync(int number)
        {
            await Task.Run(async() =>
            {
                int divisors = await CountOfDivisorsAsync(number);

                MessageBox.Show(String.Format("{0} has {1} divisors", number, divisors));
            });
        }

        private async Task<int> CountOfDivisorsAsync(int number)
        {
            int divisors = await Task<int>.Run(() =>
            {
                int divisorCount = 1;

                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        divisorCount++;
                    }
                }
                return divisorCount;
            });

            return divisors;
        }
    }
}

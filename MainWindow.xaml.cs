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

namespace BasicCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(NumberOneInput.Text, out number1);
            Double.TryParse(NumberTwoInput.Text, out number2);

            double answer = number1 + number2;

            AnswerBlock.Text = answer.ToString();
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(NumberOneInput.Text, out number1);
            Double.TryParse(NumberTwoInput.Text, out number2);

            double answer = number1 - number2;

            AnswerBlock.Text = answer.ToString();
        }
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(NumberOneInput.Text, out number1);
            Double.TryParse(NumberTwoInput.Text, out number2);

            double answer = number1 * number2;

            AnswerBlock.Text = answer.ToString();
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            Double.TryParse(NumberOneInput.Text, out number1);
            Double.TryParse(NumberTwoInput.Text, out number2);

            double answer = number1 / number2;

            AnswerBlock.Text = answer.ToString();
        }
    }
}

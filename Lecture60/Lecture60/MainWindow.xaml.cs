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

namespace Lecture60
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double income = double.Parse(txt_income.Text);
            double expenditure = double.Parse(txt_expenditure.Text);
            double price = double.Parse(txt_price.Text);
            double change = income - expenditure;
            double result = price / change;
            result = Math.Ceiling(result);
            txt_result.Text = result.ToString();
        }
    }
}

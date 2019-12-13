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

namespace Lecture97
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }
        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(txt_input_value.Text);
            txt_input_value.Clear();
        }
        private void bt_show_Click(object sender, RoutedEventArgs e)
        {
            //Show
            string output = string.Empty;
            foreach (string txt_value in DataAccess.GetData())
            {
                output += txt_value + "\n";
            }
            MessageBox.Show(output);
        }
    }
}

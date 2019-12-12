using System;
using System.Collections;
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

namespace Lecture86
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse(txt_input_key.Text), txt_input_value.Text);
            txt_input_key.Clear();
            txt_input_value.Clear();

            ICollection collection = sortedList.Keys;
            string output = string.Empty;
            foreach (int key in collection)
            {
                output += sortedList[key].ToString() + "\n";
            }
            output += "\nCount = " + sortedList.Count.ToString(); //Count
            MessageBox.Show(output);
        }
    }
}

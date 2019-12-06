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

namespace Lecture84
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            //Add
            arrayList.Add(txt_input.Text);
            txt_input.Clear();
        }

        //private void bt_sort_Click(object sender, RoutedEventArgs e)
        //{
        //    arrayList.Sort();
        //}

        private void bt_show_all_Click(object sender, RoutedEventArgs e)
        {
            //Show
            string output = string.Empty;
            foreach (string txt_value in arrayList)
            {
                output += txt_value + "\n";
            }
            output += "\nCount = " + arrayList.Count.ToString(); //Count
            MessageBox.Show(output);
        }

        private void bt_remove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            arrayList.Remove(txt_input.Text);
            txt_input.Clear();
        }

        private void bt_remove_all_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Clear();
            txt_input.Clear();
        }
    }
}

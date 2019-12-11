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

namespace Lecture85
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(txt_input_key.Text,txt_input_value.Text);
            txt_input_key.Clear();
            txt_input_value.Clear();
        }

        private void bt_show_all_Click(object sender, RoutedEventArgs e)
        {
            //Show
            ICollection collection = hashtable.Keys;
            string output = string.Empty;
            foreach (string key in collection)
            {
                output += hashtable[key].ToString() + "\n";
            }
            output += "\nCount = " + hashtable.Count.ToString(); //Count
            MessageBox.Show(output);
        }

        private void bt_remove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(txt_input_key.Text);
            txt_input_key.Clear();
            txt_input_value.Clear();
        }

        private void bt_remove_all_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Clear();
            txt_input_key.Clear();
            txt_input_value.Clear();
        }
    }
}

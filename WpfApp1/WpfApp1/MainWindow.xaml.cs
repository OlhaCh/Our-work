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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Culc c = new Culc();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text += (sender as Button).Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string rez = textBox1.Text;
            if (rez.Contains('+'))
            {
                int i = rez.IndexOf('+');
                string a = rez.Substring(0, i);
                string b = rez.Substring(i + 1, rez.Length - i - 1);
                textBox2.Text = c.Positive(a, b);
            }
            if (rez.Contains('-'))
            {
                int i = rez.IndexOf('-');
                string a = rez.Substring(0, i);
                string b = rez.Substring(i + 1, rez.Length - i - 1);
                textBox2.Text = c.Negative(a, b);
            }
            if (rez.Contains('*') == true)
            {
                int i = rez.IndexOf('*');
                string a = rez.Substring(0, i);
                string b = rez.Substring(i + 1, rez.Length - i - 1);
                textBox2.Text = c.Multiply(a, b);
            }
            if (rez.Contains('/'))
            {
                int i = rez.IndexOf('/');
                string a = rez.Substring(0, i);
                string b = rez.Substring(i + 1, rez.Length - i - 1);
                textBox2.Text = c.Division(a, b);
            }
        }
    }
}

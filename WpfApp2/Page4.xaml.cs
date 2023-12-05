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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(AA.Text);
            double g = double.Parse(BB.Text);
            double y = x + Math.Sqrt(Math.Abs(1 - Math.Pow(x, 2)));
            double z = (Math.Pow(Math.Sin(x + g), 2) + Math.Cos(x)) / (x + Math.Pow(y, 2) * Math.Log(Math.Abs(x - y)));
            MessageBox.Show($"Z ={z} ", "Ответ");
        }
    }
}

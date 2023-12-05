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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double A1 = double.Parse(AA.Text);
            double B1 = double.Parse(BB.Text);
            double C1 = double.Parse(CC.Text);
            double A2 = double.Parse(AA2.Text);
            double B2 = double.Parse(AA2.Text);
            double C2 = double.Parse(CC2.Text);
            double D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;

            MessageBox.Show($"X={x} Y={y}", "Ответ");
        }
    }
}

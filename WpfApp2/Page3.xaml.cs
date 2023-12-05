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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Math_Click(object sender, RoutedEventArgs e)
        {
            double V1 = double.Parse(AA.Text);
            double V2 = double.Parse(BB.Text);
            double S1 = double.Parse(CC.Text);
            double T = double.Parse(DD.Text);
            double S2 = Math.Abs(S1 - T * (V1 + V2));
            MessageBox.Show($"S2 ={S2} ", "Ответ");
        }
    }
}

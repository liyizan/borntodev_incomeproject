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

namespace incomeproject
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

        private void conculation(object sender, RoutedEventArgs e)
        {
            double income;
            double expend;
            double want;
            double day;
            income = double.Parse(txtincome.Text);
            expend = double.Parse(txtexpend.Text);
            want = double.Parse(txtwant.Text);
            

            if (expend >= income)
            {
                MessageBox.Show("error Please try again");

            }
            else
            {
                day = want / (income - expend);
                txtday.Text = " " + day.ToString();
            }
        }
    }
}

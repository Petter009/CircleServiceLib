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
using Client.CircleService;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CircleServiceClient client = new CircleServiceClient();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void CalcDiaBtn_Click(object sender, RoutedEventArgs e)
        {
            string s = InputTxb.Text;
            double result = client.CalcDiameter(double.Parse(s));
            ResultDiaTxb.Text = result.ToString();
        }

        private void CalcOmkBtn_Click(object sender, RoutedEventArgs e)
        {
            string s = InputTxb.Text;
            double result = client.CalcCirumference(double.Parse(s));
            ResultOmkTxb.Text = result.ToString();
        }


    }
}

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


namespace Rough_UI
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

        private void PressureGauge_Click(object sender, RoutedEventArgs e)
        {
           PressureGaugeWindow pressureGaugeWindow = new PressureGaugeWindow();
           pressureGaugeWindow.Show();
        }

        private void CommSetup_Click(object sender, RoutedEventArgs e)
        {
            CommunicationSetupWindow communicationSetupWindow= new CommunicationSetupWindow();
            communicationSetupWindow.Show();
        }

        private void MPC_Click(object sender, RoutedEventArgs e)
        {
            MPCWindow mpcWindow= new MPCWindow();
            mpcWindow.Show();
        }
    }
}

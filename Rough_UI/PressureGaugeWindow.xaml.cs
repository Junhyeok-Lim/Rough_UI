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
using System.Windows.Shapes;

namespace Rough_UI
{
    /// <summary>
    /// PressureGaugeWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PressureGaugeWindow : Window
    {
        public List<string> selectUnit { get; set; } = new List<string>()
            {
                "mTorr",
                "mbar",
                "atm"
            };

        public PressureGaugeWindow()
        {
            InitializeComponent();

            ComboBoxSelectUnit.ItemsSource = selectUnit;
            

        }
    }   
}
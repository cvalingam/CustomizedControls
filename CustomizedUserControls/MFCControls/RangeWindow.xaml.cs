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

namespace CustomizedUserControls.MFCControls
{
    /// <summary>
    /// Interaction logic for Windo1.xaml
    /// </summary>
    public partial class RangeWindow : Window
    {
        public RangeWindow()
        {
            InitializeComponent();
            okBtn.Click += OkBtn_Click;
            cancelBtn.Click += CancelBtn_Click;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e) =>
            DialogResult = false;

        private void OkBtn_Click(object sender, RoutedEventArgs e) =>
            DialogResult = true;
    }
}

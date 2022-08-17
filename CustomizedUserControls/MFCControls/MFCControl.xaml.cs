using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CustomizedUserControls.MFCControls
{
    /// <summary>
    /// Interaction logic for MFCControl.xaml
    /// </summary>
    public partial class MFCControl : UserControl
    {
        public MFCControl()
        {
            InitializeComponent();
            currentValueTxtBox.PreviewMouseDoubleClick += RangeTxtBox_PreviewMouseDoubleClick;
            setPointTxtBox.PreviewMouseDoubleClick += RangeTxtBox_PreviewMouseDoubleClick;
        }

        private void RangeTxtBox_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var dialog = new RangeWindow();
            dialog.ShowDialog();

            //if (result == true)
            //{
            //    // User accepted the dialog box
            //    //MessageBox.Show("Range has been updated");
            //    //mfcMinRangeTxtBox.Text = dialog.minRangeTxtBox.Text;
            //    //mfcMaxRangeTxtBox.Text = dialog.maxRangeTxtBox.Text;
            //}
            //else
            //{
            //    // User cancelled the dialog box
            //    //MessageBox.Show("Sorry range update has been cancelled, try again later.");
            //}
        }
    }
}

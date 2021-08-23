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

namespace Wochentagrechner
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

        /// <summary>
        /// Ermitteln Wochentag und Audgabe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wochentag WD = new Wochentag();
            
            try
            {
                WD.j = Convert.ToInt32(tb_y.Text);
                WD.m = Convert.ToInt32(tb_m.Text);
                WD.t = Convert.ToInt32(tb_d.Text);
                lb_result.Content = WD.GibWochentag();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler: {ex.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                lb_result.Content = "Fehler";
                tb_d.Focus();
            }
            
        }
    }
}

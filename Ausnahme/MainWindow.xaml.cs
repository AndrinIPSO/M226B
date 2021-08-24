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
using CircleLibrary;

namespace Ausnahme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb_output.Content = "";
        }

        private void bt_ok_Click(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle();
            try
            {
                circle.Radius = Convert.ToInt32(tb_input.Text);
                lb_output.Content += $"\nKreis mit Radius von {tb_input.Text}, wurde erstellt";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler");
            }
        }
    }
}

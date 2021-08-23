using CircleLibrary;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Exceptions.Circles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lb_result.Content = "";
        }

        private void bt_noex_Click(object sender, RoutedEventArgs e)
        {

            StreamReader stream = new StreamReader(@"C:\Temp\Test.txt");
            MessageBox.Show(stream.ReadToEnd());

            stream.Close();
        }

        private void bt_ex_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader stream = new StreamReader(@"C:\Temp\Test.txt");
                MessageBox.Show(stream.ReadToEnd());

                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void bt_multiex_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader stream = new StreamReader(@"C:\Temp\Test.txt");
                MessageBox.Show(stream.ReadToEnd());

                stream.Close();
            }
            catch (ArgumentNullException aex)
            {
                MessageBox.Show(aex.Message, "Argument Null Exception");

            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Argument Exception");

            }
            catch (FileNotFoundException aex)
            {
                MessageBox.Show(aex.Message, "File not Found");

            }
            catch (DirectoryNotFoundException aex)
            {
                MessageBox.Show(aex.Message, "Directory not found");

            }
            catch (IOException aex)
            {
                MessageBox.Show(aex.Message, "IO Exception");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unbehandelter Fehler");
            }
        }

        private void bt_samplenr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_samplecircle_Click(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle(2,3,2);
            MessageBox.Show($"Kreis wurde instanziiert: {circle.ToString()}","Congrats" );
        }

        private void cb_nocrash_Checked(object sender, RoutedEventArgs e)
        {
            bt_noex.IsEnabled = false;
        }

        private void cb_nocrash_Click(object sender, RoutedEventArgs e)
        {
            if (cb_nocrash.IsChecked == true)
            {
                bt_noex.IsEnabled = false;
            }
            else
            {
                bt_noex.IsEnabled = true;
            }
        }

        private void bt_experiment_Click(object sender, RoutedEventArgs e)
        {


            StreamWriter sw = new StreamWriter(@"c:\Test.txt");
            sw.WriteLine(tb_input.Text);
            sw.Close();
            StreamReader strim = new StreamReader(@"c:\Test.txt");
            lb_result.Content = strim.ReadToEnd();
            strim.Close();
        }

        private void bt_find_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Create($@"c:\easyaccess\{tb_input.Text}");
                tb_input.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler");
            }
        }
    }
}

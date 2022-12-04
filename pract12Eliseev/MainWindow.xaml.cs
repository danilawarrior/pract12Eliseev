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
using System.Windows.Threading;

namespace pract12Eliseev
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

        private void aboutTask1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана площадь S круга. Найти его диаметр D и длину L окружности, \n ограничивающей этот круг, учитывая, что L = PI * D, S = PI * D2 / 4. \n В качестве значения PI использовать 3.14.");
        }

        private void aboutTask2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("С начала усток прошлоа N секунд. Найти Количество полных часов \n прошедших сначала суток.");
        }

        private void whoDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик Данила Елисеев, группа ИСП-31");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void calculateTask1_Click(object sender, RoutedEventArgs e)
        {
            squareOfCircleText.Focus();
            try
            {
                double squareOfCircle = Convert.ToDouble(squareOfCircleText.Text);
                diametrOfCircle.Text = "" + 2 * Math.Sqrt(squareOfCircle) / 3.14;
                circumference.Text = "" + Math.Sqrt(squareOfCircle * 4 * 3.14);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearEx1_Click(object sender, RoutedEventArgs e)
        {
            squareOfCircleText.Text = null;
            diametrOfCircle.Text = null;
            circumference.Text = null;
        }


        private void calculateTask2_Click(object sender, RoutedEventArgs e)
        {
            secondsText.Focus();
            try
            {
                int seconds = Convert.ToInt32(secondsText.Text);
                fullHoursText.Text = "" + seconds / 60 / 60;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearTask2_Click(object sender, RoutedEventArgs e)
        {
            fullHoursText.Text = null;
            secondsText.Text = null;
        }
        private void secondsText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void squareOfCircleText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void fullHoursText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            tbWatch.Text = dateTime.ToString("hh:mm:ss");
            tbDate.Text = dateTime.ToString("dd.MM.yyyy");
        }
    }
}

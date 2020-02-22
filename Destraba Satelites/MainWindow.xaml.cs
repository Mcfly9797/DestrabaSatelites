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
using Controladores;
using Entidades;

namespace Destraba_Satelites
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Sat1(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(1);
            new DestrabarPrensa().EscribirLog(log, 1);
            if ((log.Count) > 0)
            {
                MessageBox.Show("Satelite 1 destrabado!", "Destraba satelites");
                grdDatos.ItemsSource = log;
            }
            else
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
        }

        private void Button_Click_Sat2(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(2);
            new DestrabarPrensa().EscribirLog(log, 2);
            if ((log.Count) > 0)
            {
                MessageBox.Show("Satelite 2 destrabado!", "Destraba satelites");
                grdDatos.ItemsSource = log;
            }
            else
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
        }

        private void Button_Click_Sat3(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(3);
            new DestrabarPrensa().EscribirLog(log, 3);
            if ((log.Count) > 0)
            {
                MessageBox.Show("Satelite 3 destrabado!", "Destraba satelites");
                grdDatos.ItemsSource = log;
            }
            else
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
        }

        private void Button_Click_Sat4(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(4);
            new DestrabarPrensa().EscribirLog(log, 4);
            if ((log.Count) > 0)
            {
                MessageBox.Show("Satelite 4 destrabado!", "Destraba satelites");
                grdDatos.ItemsSource = log;
            }
            else
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
        }
    }
}

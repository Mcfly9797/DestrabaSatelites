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
using Entidades;
using Controladores;

namespace Destraba_Satelites_Material_Design
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

        bool flagError = false;
        private void Button_Click_Sat1(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(1, ref flagError);
            if ((log.Count) > 0 && flagError == false)
            {
                MessageBox.Show("Satelite 1 destrabado!", "Destraba satelites");
                lblPrenFalla.Content = new DestrabarPrensa().LstPrensFalla(log);
                //grdDatos.ItemsSource = log;

            }
            else if (flagError == false)
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
            else if (flagError == true)
            {
                MessageBox.Show("Hubo un error al destrabarel satelite, observar log en la ruta de ejecucion del programa", "Destraba satelites");
                flagError = false;
            }
        }


        private void Button_Click_Sat2(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(2, ref flagError);
            if ((log.Count) > 0 && flagError == false)
            {
                MessageBox.Show("Satelite 2 destrabado!", "Destraba satelites");
                //grdDatos.ItemsSource = log;
                lblPrenFalla.Content = new DestrabarPrensa().LstPrensFalla(log);
            }
            else if (flagError == false)
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
            else if (flagError == true)
            {
                MessageBox.Show("Hubo un error al destrabarel satelite, observar log en la ruta de ejecucion del programa", "Destraba satelites");
                flagError = false;
            }
            
        }


        private void Button_Click_Sat3(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(3, ref flagError);
            if ((log.Count) > 0 && flagError == false)
            {
                MessageBox.Show("Satelite 3 destrabado!", "Destraba satelites");
                //grdDatos.ItemsSource = log;
                lblPrenFalla.Content = new DestrabarPrensa().LstPrensFalla(log);
            }
            else if (flagError == false)
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
            else if (flagError == true)
            {
                MessageBox.Show("Hubo un error al destrabarel satelite, observar log en la ruta de ejecucion del programa", "Destraba satelites");
                flagError = false;
            }
        }


        private void Button_Click_Sat4(object sender, RoutedEventArgs e)
        {
            List<PrensaLog> log = new DestrabarPrensa().DestraSatTraerLogs(4, ref flagError);
            if ((log.Count) > 0 && flagError == false)
            {
                MessageBox.Show("Satelite 4 destrabado!", "Destraba satelites");
                //grdDatos.ItemsSource = log;
                lblPrenFalla.Content = new DestrabarPrensa().LstPrensFalla(log);
            }
            else if (flagError == false)
            {
                MessageBox.Show("El satelite no estaba trabado!", "Destraba satelites");
            }
            else if (flagError == true)
            {
                MessageBox.Show("Hubo un error al destrabarel satelite, observar log en la ruta de ejecucion del programa", "Destraba satelites");
                flagError = false;
            }
        }

    }
}

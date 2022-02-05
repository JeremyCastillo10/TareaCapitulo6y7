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

namespace Ejercicio_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] calificaciones = new int[3];
        private int ind = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClick_Agregar(object sender, RoutedEventArgs e)
        {
            Agregar();      
        }

        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            Promedio();
            Mayor();
            Menor();
        }
        private void Agregar()
        {
            int cal = Convert.ToInt32(txtCalificacion.Text);
            ind = ind - 0;

            if(ind <= calificaciones.Length)
            {
                calificaciones[ind] = cal;

                txtCalificacion.Text = " ";
                
                ind = ind + 1;
            }
            else
            {
                MessageBox.Show("llego al limite de calificaciones", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Promedio()
        {
            float suma = 0;
            float promedio = 0;
            for(int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
                promedio = suma/i;
            }
            txtPromedio.Text = promedio.ToString();
        }

        private void Mayor()
        {
            float mayor = 0;  
            for(int i = 0; i < calificaciones.Length; i++)
            {
                mayor = calificaciones.Max();
            }
            txtMayor.Text = mayor.ToString();
        }

        private void Menor()
        {
            float menor = 0;
            
            for(int i = 0; i < calificaciones.Length; i++)
            {
                menor = calificaciones.Min();
            }
            txtMenor.Text = menor.ToString();
        }
    }
}

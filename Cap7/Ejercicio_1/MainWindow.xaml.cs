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

namespace Ejercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
       {
        private List<float> List = new List<float>();
        public MainWindow()
        {
            InitializeComponent();
        }
         private void ButtonClick_Agregar(object sender, RoutedEventArgs e)
        {
            List.Add(float.Parse(txtCalificacion.Text));
            MessageBox.Show("Se ha agregado con exito");
            txtCalificacion.Text = " ";
        }
        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            float total = 0.0f;
            float prom = 0.0f; 
            float min = 0.0f;
            float max = 0.0f;
            
            for(int i = 0; i < List.Count; i++)
            {
                total = total+List[i];
                max = List.Max();
                min = List.Min();
            }

            prom = total / List.Count;

            txtPromedio.Text = prom.ToString();
            txtMaxima.Text = max.ToString();
            txtMinima.Text = min.ToString();
        }
    }
}

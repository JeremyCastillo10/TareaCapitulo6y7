using System;
using System.Collections;
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

namespace Ejercicio_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable tabla = new Hashtable();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClick_Guardar(object sender, RoutedEventArgs e)
        {
            tabla.Add(txtPalabra.Text, txtDefinicion.Text);
            txtPalabra.Text = " ";
            txtDefinicion.Text = " ";

        }

        private void ButtonClick_Mostrar(object sender, RoutedEventArgs e)
        {
            foreach(DictionaryEntry  tablaHash in tabla)
            {
                Resultado.Items.Add(tablaHash.Key);
                Resultado.Items.Add(tablaHash.Value);
            }

        }

        private void ButtonClick_Limpiar(object sender, RoutedEventArgs e)
        {
            txtPalabra.Text = string.Empty;
            txtDefinicion.Text = string.Empty;

            Resultado.Items.Clear();

        }
    }
}

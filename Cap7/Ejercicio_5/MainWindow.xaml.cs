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

namespace Ejercicio_5
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
            tabla.Add(txtNombre.Text, txtTelefono.Text);
            txtNombre.Text = " ";
            txtTelefono.Text = " ";

        }
        private void ButtonClick_Mostrar(object sender, RoutedEventArgs e)
        {
            foreach(DictionaryEntry  tablaHash in tabla)
            {
                Resultado.Items.Add($"Nombre: {tablaHash.Key}");
                Resultado.Items.Add($"Telefono: {tablaHash.Value}");
            }

        }

        private void ButtonClick_Limpiar(object sender, RoutedEventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

            this.Resultado.Items.Clear();

        }
    }
}

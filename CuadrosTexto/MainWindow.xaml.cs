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

namespace CuadrosTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MensajeNombreYApellido(object sender, KeyEventArgs e)
        {
            String tag = (sender as TextBox).Tag.ToString();
            if (e.Key == Key.F1)
            {
                if (tag == "Apellido")
                {
                    if (MensajeApellidoTextBlock.Visibility != Visibility.Hidden)
                        MensajeApellidoTextBlock.Visibility = Visibility.Hidden;
                    else MensajeApellidoTextBlock.Visibility = Visibility.Visible;
                }
                else
                {
                    if (MensajeNombreTextBlock.Visibility != Visibility.Hidden)
                        MensajeNombreTextBlock.Visibility = Visibility.Hidden;
                    else MensajeNombreTextBlock.Visibility = Visibility.Visible;
                }
            }
        }

        private void MensajeEdad(object sender, KeyEventArgs e)
        {
            bool esNumero = int.TryParse(EdadTextBox.Text, out _);

            if (e.Key == Key.F2)
            {
                if (!esNumero)
                    MensajeEdadTextBlock.Visibility = Visibility.Visible;
                else
                    MensajeEdadTextBlock.Visibility = Visibility.Hidden;
            }
        }
    }
}

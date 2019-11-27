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



namespace ProyectoFinal3erParcial_Problemas_Con_El_Ateriror
{
    /// <summary>
    /// Lógica de interacción para P_SeleccionDePelicula_O_Serie.xaml
    /// </summary>
    public partial class P_SeleccionDePelicula_O_Serie : UserControl
    {
        public P_SeleccionDePelicula_O_Serie()
        {
            InitializeComponent();
            rbtnPelicula.IsChecked = true;
        }

        private void RbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnPelicula.IsChecked == true)
            {
              
                txtProductor.Visibility = Visibility.Hidden;
                txbProductor.Visibility = Visibility.Hidden;
                txtTemporadas.Visibility = Visibility.Hidden;
                txbTemporadas.Visibility = Visibility.Hidden;
                lstDirector.Visibility = Visibility.Visible;
                txtDirector.Visibility = Visibility.Visible;
                cmbGenero.Visibility = Visibility.Visible;
            }
        }

        private void RbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnSerie.IsChecked == true)
            {
              
                txtProductor.Visibility = Visibility.Visible;
                txbProductor.Visibility = Visibility.Visible;
                txtTemporadas.Visibility = Visibility.Visible;
                txbTemporadas.Visibility = Visibility.Visible;
                lstDirector.Visibility = Visibility.Hidden;
                txtDirector.Visibility = Visibility.Hidden;
            }
        }
    }
}

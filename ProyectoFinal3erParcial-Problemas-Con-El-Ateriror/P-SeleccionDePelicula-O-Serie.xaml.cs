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
using System.Collections.ObjectModel;


namespace ProyectoFinal3erParcial_Problemas_Con_El_Ateriror
{
    /// <summary>
    /// Lógica de interacción para P_SeleccionDePelicula_O_Serie.xaml
    /// </summary>
    public partial class P_SeleccionDePelicula_O_Serie : UserControl
    {
        ObservableCollection<Q_PeliculaEAV> peliculaEavs = new ObservableCollection<Q_PeliculaEAV>();

        public P_SeleccionDePelicula_O_Serie()
        {
            InitializeComponent();
            rbtnPelicula.IsChecked = true;
            grdSeriePelicula.Children.Add(new Q_PeliculaEAV());
        }

        private void RbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdSeriePelicula.Children.Clear();
            grdSeriePelicula.Children.Add(new Q_PeliculaEAV());

            peliculaEavs.Add(new Q_PeliculaEAV());
        }

        private void RbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdSeriePelicula.Children.Clear();
            grdSeriePelicula.Children.Add(new R_SerieEAV());
        }
    }
}

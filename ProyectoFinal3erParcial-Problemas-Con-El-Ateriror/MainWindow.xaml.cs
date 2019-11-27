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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<T_Extra2> PS = new ObservableCollection<T_Extra2>();
        public MainWindow()
        {
            InitializeComponent();

            PS.Add(new Qr_Pelicula("Batman", 1989, "Tim Burton",  "Accion", "El caballero oscuro conocido como Batman defiende a la " +
                "corrupta e insegura ciudad de Gotham de su enemigo principal, un payaso homicida conocido como Joker.", 10));

           PS.Add(new Rs_Serie("Gotham", 2014, "Accion", "Scott White",  5,  "El detective James Gordon se desenvuelve por el mundo " +
                "peligrosamente corrupto de Gotham City, mientras que un joven Bruce Wayne encuentra su camino para convertirse en un héroe.", 10));
            lstCar.ItemsSource = PS;
        }

        private void BtnNueEle_Click(object sender, RoutedEventArgs e)
        {
            grdEle.Children.Clear();
            grdEle.Children.Add(new P_SeleccionDePelicula_O_Serie());
            btnNueEle.Visibility = Visibility.Hidden;
            btnAsTitulo.Visibility = Visibility.Hidden;
            btnDesTitulo.Visibility = Visibility.Hidden;
            btnAsAño.Visibility = Visibility.Hidden;
            btnDesAño.Visibility = Visibility.Hidden;
            btnGuEleNuevo.Visibility = Visibility.Visible;
            btnCanEleNuevo.Visibility = Visibility.Visible;
        }

        private void BtnGuEleNuevo_Click(object sender, RoutedEventArgs e)
        {
            var vPS = ((P_SeleccionDePelicula_O_Serie)(grdEle.Children[0]));
            if(vPS.rbtnPelicula.IsChecked==true)
            {
                PS.Add(new Qr_Pelicula(vPS.txtTitulo.Text, Convert.ToInt32(vPS.txtAño.Text), vPS.txtDirector.Text, vPS.cmbGenero.Text, vPS.txtSinopsis.Text, Convert.ToInt32(vPS.cmbRating.Text)));
            }
            if(vPS.rbtnSerie.IsChecked==true)
            {
                PS.Add(new Rs_Serie(vPS.txtTitulo.Text, Convert.ToInt32(vPS.txtAño.Text), vPS.txtProductor.Text, vPS.cmbGenero.Text, Convert.ToInt32(vPS.txbTemporadas.Text), vPS.txtSinopsis.Text, Convert.ToInt32(vPS.cmbRating.Text)));
            }


            btnNueEle.Visibility = Visibility.Visible;
            btnAsTitulo.Visibility = Visibility.Visible;
            btnDesTitulo.Visibility = Visibility.Visible;
            btnAsAño.Visibility = Visibility.Visible;
            btnDesAño.Visibility = Visibility.Visible;
            btnGuEleNuevo.Visibility = Visibility.Hidden;
            btnCanEleNuevo.Visibility = Visibility.Hidden;
            btnActEdicion.Visibility = Visibility.Hidden;
            btnEliElemento.Visibility = Visibility.Hidden;
            grdEle.Children.Clear();
        }

        private void BtnCanEleNuevo_Click(object sender, RoutedEventArgs e)
        {
            grdEle.Children.Clear();
            btnNueEle.Visibility = Visibility.Visible;
            btnAsTitulo.Visibility = Visibility.Visible;
            btnDesTitulo.Visibility = Visibility.Visible;
            btnAsAño.Visibility = Visibility.Visible;
            btnDesAño.Visibility = Visibility.Visible;
            btnGuEleNuevo.Visibility = Visibility.Hidden;
            btnCanEleNuevo.Visibility = Visibility.Hidden;
            btnEliElemento.Visibility = Visibility.Hidden;
            btnHabEdicion.Visibility = Visibility.Hidden;
            btnActEdicion.Visibility = Visibility.Hidden;
        }

        private void LstCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCar.SelectedIndex != -1)
            {
                grdEle.Children.Clear();
                grdEle.Children.Add(new S_Extra());
                btnNueEle.Visibility = Visibility.Hidden;
                btnAsTitulo.Visibility = Visibility.Hidden;
                btnDesTitulo.Visibility = Visibility.Hidden;
                btnAsAño.Visibility = Visibility.Hidden;
                btnDesAño.Visibility = Visibility.Hidden;
                btnEliElemento.Visibility = Visibility.Visible;
                btnHabEdicion.Visibility = Visibility.Visible;
                btnActEdicion.Visibility = Visibility.Hidden;
                btnCanEleNuevo.Visibility = Visibility.Visible;

                var vPS = ((S_Extra)(grdEle.Children[0]));
                var pL = PS[lstCar.SelectedIndex];
                if (pL.Tipo == "Pelicula")
                {
                    vPS.lblTipo.Text = pL.Tipo;
                    vPS.txtTitulo.Text = pL.Titulo;
                    vPS.txtAño.Text = pL.Año.ToString();
                    vPS.txtDirector.Text = pL.Director;
                    vPS.cmbGenero.Text = pL.Genero;
                    vPS.txtSinopsis.Text = pL.Sinopsis;
                    vPS.cmbRating.Text = pL.Rating.ToString();
                    vPS.txtTitulo.IsEnabled = false;
                    vPS.txtAño.IsEnabled = false;
                    vPS.txtDirector.IsEnabled = false;
                    vPS.cmbGenero.IsEnabled = false;
                    vPS.txtSinopsis.IsEnabled = false;
                    vPS.cmbRating.IsEnabled = false;

                }
                if (pL.Tipo == "Serie")
                {
                    vPS.lblTipo.Text = pL.Tipo;
                    vPS.txtTitulo.Text = pL.Titulo;
                    vPS.txtAño.Text = pL.Año.ToString();
                    vPS.txtDirector.Visibility = Visibility.Hidden;
                    vPS.lblDirector.Visibility = Visibility.Hidden;
                    vPS.txtProductor.Visibility = Visibility.Visible;
                    vPS.lblProductor.Visibility = Visibility.Visible;
                    vPS.txtProductor.Text = pL.Productor;
                    vPS.txtSinopsis.Visibility = Visibility.Hidden;
                    vPS.lblSinopsis.Visibility = Visibility.Hidden;
                    vPS.txtDescripcion.Visibility = Visibility.Visible;
                    vPS.lblDescripcion.Visibility = Visibility.Visible;
                    vPS.txtDescripcion.Text = pL.Descripcion;
                    vPS.cmbTemporadas.Visibility = Visibility.Visible;
                    vPS.lblTemporadas.Visibility = Visibility.Visible;
                    vPS.cmbTemporadas.Text = pL.Temporada.ToString();
                    vPS.cmbGenero.Text = pL.Genero;
                    vPS.cmbRating.Text = pL.Rating.ToString();
                    vPS.txtTitulo.IsEnabled = false;
                    vPS.txtAño.IsEnabled = false;
                    vPS.txtProductor.IsEnabled = false;
                    vPS.cmbGenero.IsEnabled = false;
                    vPS.txtDescripcion.IsEnabled = false;
                    vPS.cmbRating.IsEnabled = false;
                    vPS.cmbTemporadas.IsEnabled = false;
                }

            }
        }

        private void BtnAsAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = PS.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < PS.Count; i++)
                {
                    if (gap + i < PS.Count && PS[i].Año > PS[gap + i].Año)
                    {
                        var temp = PS[i];
                        PS[i] = PS[gap + i];
                        PS[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnDesAño_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = PS.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < PS.Count; i++)
                {
                    if (gap + i < PS.Count && PS[i].Año < PS[gap + i].Año)
                    {
                        var temp = PS[i];
                        PS[i] = PS[gap + i];
                        PS[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void BtnAsTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (PS.Count - 1); i++)
                {
                    if (string.Compare(PS[i].Titulo, PS[i + 1].Titulo) > 0)
                    {
                        var temp = PS[i];
                        PS[i] = PS[i + 1];
                        PS[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnDesTitulo_Click(object sender, RoutedEventArgs e)
        {
            bool cambio;
            do
            {
                cambio = false;
                for (int i = 0; i < (PS.Count - 1); i++)
                {
                    if (string.Compare(PS[i].Titulo, PS[i + 1].Titulo) < 0)
                    {
                        var temp = PS[i];
                        PS[i] = PS[i + 1];
                        PS[i + 1] = temp;
                        cambio = true;
                    }
                }
            } while (cambio == true);
        }

        private void BtnEliElemento_Click(object sender, RoutedEventArgs e)
        {
            
            grdEle.Children.Clear();
            btnNueEle.Visibility = Visibility.Visible;
            btnAsTitulo.Visibility = Visibility.Visible;
            btnDesTitulo.Visibility = Visibility.Visible;
            btnAsAño.Visibility = Visibility.Visible;
            btnDesAño.Visibility = Visibility.Visible;
            btnGuEleNuevo.Visibility = Visibility.Hidden;
            btnCanEleNuevo.Visibility = Visibility.Hidden;
            btnEliElemento.Visibility = Visibility.Hidden;
            btnHabEdicion.Visibility = Visibility.Hidden;
            btnActEdicion.Visibility = Visibility.Hidden;

            if (lstCar.SelectedIndex != -1)
            {
                PS.RemoveAt(lstCar.SelectedIndex);
            }
        }

        private void BtnHabEdicion_Click(object sender, RoutedEventArgs e)
        {
            btnHabEdicion.Visibility = Visibility.Hidden;
            btnActEdicion.Visibility = Visibility.Visible;

            var vPS = ((S_Extra)(grdEle.Children[0]));

            vPS.txtTitulo.IsEnabled = true;
            vPS.txtAño.IsEnabled = true;
            vPS.txtDirector.IsEnabled = true;
            vPS.cmbGenero.IsEnabled = true;
            vPS.txtSinopsis.IsEnabled = true;
            vPS.cmbRating.IsEnabled = true;
            vPS.cmbTemporadas.IsEnabled = true;
        }

        private void BtnActEdicion_Click(object sender, RoutedEventArgs e)
        {
            var vPS = ((S_Extra)(grdEle.Children[0]));
            var pL = PS[lstCar.SelectedIndex];

            pL.Titulo = vPS.txtTitulo.Text;
            pL.Año = Convert.ToInt32(vPS.txtAño.Text);
            pL.Productor = vPS.txtDirector.Text;
            pL.Genero = vPS.cmbGenero.Text;
            pL.Descripcion = vPS.txtSinopsis.Text;
            pL.Rating = Convert.ToInt32(vPS.cmbRating.Text);
            pL.Director = vPS.txtDirector.Text;
            pL.Sinopsis = vPS.txtSinopsis.Text;

            lstCar.Items.Refresh();

            vPS.txtTitulo.IsEnabled = false;
            vPS.txtAño.IsEnabled = false;
            vPS.txtDirector.IsEnabled = false;
            vPS.cmbGenero.IsEnabled = false;
            vPS.txtSinopsis.IsEnabled = false;
            vPS.cmbRating.IsEnabled = false;
            vPS.txtDirector.IsEnabled = false;
            vPS.txtSinopsis.IsEnabled = false;

            btnActEdicion.Visibility = Visibility.Hidden;
            btnHabEdicion.Visibility = Visibility.Visible;
        }

        private void BtnCanEleNuevo_Click_1(object sender, RoutedEventArgs e)
        {
            grdEle.Children.Clear();
            btnNueEle.Visibility = Visibility.Visible;
            btnAsTitulo.Visibility = Visibility.Visible;
            btnDesTitulo.Visibility = Visibility.Visible;
            btnAsAño.Visibility = Visibility.Visible;
            btnDesAño.Visibility = Visibility.Visible;
            btnGuEleNuevo.Visibility = Visibility.Hidden;
            btnCanEleNuevo.Visibility = Visibility.Hidden;
            btnEliElemento.Visibility = Visibility.Hidden;
            btnHabEdicion.Visibility = Visibility.Hidden;
            btnActEdicion.Visibility = Visibility.Hidden;
        }
        private void rbtnSerie_Checked(object sender, RoutedEventArgs e)
        {
            grdEle.Children.Clear();
            grdEle.Children.Add(new R_SerieEAV());
            btnGuEleNuevo.Visibility = Visibility.Visible;
        }
        private void rbtnPelicula_Checked(object sender, RoutedEventArgs e)
        {
            grdEle.Children.Clear();
            grdEle.Children.Add(new Q_PeliculaEAV());
            btnGuEleNuevo.Visibility = Visibility.Visible;
        }
    }
    
}

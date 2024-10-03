using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP2_Peliculas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Instancio una lista de la clase lista_generos
            List<lista_generos> generos = new List<lista_generos>();

            // Agrego los generos a la lista
            generos.Add(new lista_generos { genero = "Comedia" });
            generos.Add(new lista_generos { genero = "Drama" });
            generos.Add(new lista_generos { genero = "Terror" });
            generos.Add(new lista_generos { genero = "Accion" });
            generos.Add(new lista_generos { genero = "Romance" });
            generos.Add(new lista_generos { genero = "Policial" });
            generos.Add(new lista_generos { genero = "Anime" });
            generos.Add(new lista_generos { genero = "Infantil" });

            // Vinculo el combobox con los campos de la lista
            generoPelicula.ItemsSource = generos;
        }

        // Creo la clase que contendra la informacion de losgeneros
        public class lista_generos
        {
            public string genero { get; set; }

        }

        // funcion para realizar las validaciones
        public void validar( TextBox textbox , int limite )
        {
            MessageBox.Show($"Excedio los {limite} caracteres", "Mensaje", MessageBoxButton.OK);
            textbox.Text = string.Empty;
        }

        // Evento que maneja la validacion del nombre de la pelicula
        private void nombrePelicula_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nombrePelicula.Text.Length > 50)
            {
                validar(nombrePelicula, 50);
            }
        }

        // Evento que maneja la validacion del nombre del director
        private void nombreDirector_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nombreDirector.Text.Length > 30)
            {
                validar( nombreDirector, 30);
            }
        }
    }
}
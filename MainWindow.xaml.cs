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

namespace WpfLIstBox
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Erstellung einer Liste 
            List<Spiel> spiele = new List<Spiel>();
            spiele.Add(new Spiel() { Team1="Bayern München", Team2="Real Madrid", Tore1=3, Tore2=2, Fortschritt=86 });
            spiele.Add(new Spiel() { Team1 = "PSG", Team2 = "BVB", Tore1 = 1, Tore2 = 1, Fortschritt = 32 });
            spiele.Add(new Spiel() { Team1 = "Bayern München", Team2 = "Freiburg", Tore1 = 5, Tore2 = 1, Fortschritt = 45 });
            spiele.Add(new Spiel() { Team1 = "HSV", Team2 = "BVB", Tore1 = 2, Tore2 = 3, Fortschritt = 75 });
            listBoxSpiele.ItemsSource = spiele;

            
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxSpiele.SelectedItem == null)
            {
                MessageBox.Show("du hast nix ausgewählt");
                MessageBox.Show("bitte wähle zuesrt das spiel aus, um einen exlizites ergebnis zu erhalten");
            }
            else
            {
                MessageBox.Show("Ausgewähltes Spiel: " +
                (listBoxSpiele.SelectedItem as Spiel).Team1 + " " +
                (listBoxSpiele.SelectedItem as Spiel).Tore1 + " " +
                (listBoxSpiele.SelectedItem as Spiel).Tore2 + " " +
                (listBoxSpiele.SelectedItem as Spiel).Team2);
            }
            
        }
    }
}
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

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void klickBeräkna(object sender, RoutedEventArgs e)
    {
        bool lyckas = int.TryParse(txbVikt.Text, out int gram);
        int frimärken = gram / 50;
        int pris = frimärken * 22;
            lblResultat.Content = "Brev som väger " + gram + " g kostar " + pris + " kr (" + frimärken + "frimärke)";
    }
    
}
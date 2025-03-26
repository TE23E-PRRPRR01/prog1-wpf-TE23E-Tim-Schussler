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

namespace KlappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    //Variabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];
    public MainWindow()
    {
        InitializeComponent();

        // Lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;
    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // Läst av rutan
        string antal = txbAntal.Text;

        // Första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Vg ange ett heltal";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                stpMax.IsEnabled = false;

                        // Lås gränssnitt
        stpInmatning.IsEnabled = true;
        stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "Vg ange ett heltal";
            }
        }
    }

        private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        
    }

        private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }
}
using System.Numerics;
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

namespace AritmetikApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        int tal1 = 0;
        int tal2 = 0;
        bool lyckades = int.TryParse(txbTal1.Text, out tal1);
        if (lyckades){} else {
            lblResultat.Content = "Vänligen ange ett heltal i ruta ett";
            return;
        }
        bool lyckades2 = int.TryParse(txbTal2.Text, out tal2);
        if (lyckades2){} else {
            lblResultat.Content = "Vänligen ange ett heltal i ruta två";
            return;
        }
          string operatort = txbOperator.Content;
        if (operatort == "*"){}else{
            if (operatort == "+"){}else{
                if (operatort == "-"){}else{
                    if (operatort == "/"){}else{
                                    lblResultat.Content = "Vänligen ange en operator i ruta operator";

                    }
                }
            }
        }
    
    }
}
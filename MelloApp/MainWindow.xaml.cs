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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int antalRöd = 0;
    int antalBlå = 0;
    int antalGrön = 0;
    int antalGul = 0;
    int antalLila = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void rösta(object sender, RoutedEventArgs e)
    {
        // VEM VAR DET SOM KLICKA?
        if (sender == red)
        {
                    // För varje klick +1
            antalRöd++;
        } else if (sender == blue) {
            antalBlå++;
        } else if (sender == green){
            antalGrön++;
        } else if (sender == yellow){
            antalGul++;
        } else if (sender == purple){
            antalLila++;
        }
        txbresultat.Text = $"Röd: {antalRöd} Blå: {antalBlå} Grön: {antalGrön} Gul: {antalGul} Lila: {antalLila}";
    }
    private void reset(object sender, RoutedEventArgs e){
    antalRöd = 0;
    antalBlå = 0;
    antalGrön = 0;
    antalGul = 0;
    antalLila = 0;
                txbresultat.Text = $"Röd: {antalRöd} Blå: {antalBlå} Grön: {antalGrön} Gul: {antalGul} Lila: {antalLila}";
    }
}
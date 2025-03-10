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

namespace BrannBollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


        int poängInne = 0;
        int poängUte = 0;  
    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {


        poängInne += 5;
        txbInne.Text = $"{poängInne}";
        txbHistorik.Text += $"\n {DateTime.Now.ToString("HH:mm:ss")} Lag inne +5, totalt: Inne - {poängInne}   Ute - {poängUte}";
    }
        private void KlickBränning(object sender, RoutedEventArgs e)
    {


        poängUte += 2;
        txbUte.Text = $"{poängUte}";
        txbHistorik.Text += $"\n {DateTime.Now.ToString("HH:mm:ss")} Lag ute  +2, totalt: Inne - {poängInne}   Ute - {poängUte}";
    }
        private void KlickLyra(object sender, RoutedEventArgs e)
    {


        poängUte += 3;
        txbUte.Text = $"{poängUte}";
        txbHistorik.Text += $"\n {DateTime.Now.ToString("HH:mm:ss")} Lag ute  +3, totalt: Inne - {poängInne}   Ute - {poängUte}";
    }
        private void KlickVarv(object sender, RoutedEventArgs e)
    {


        poängInne += 1;
        txbInne.Text = $"{poängInne}";
        txbHistorik.Text += $"\n {DateTime.Now.ToString("HH:mm:ss")} Lag inne +1, totalt: Inne - {poängInne}   Ute - {poängUte}";
        
    }
}
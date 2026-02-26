using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Holds player data (name, balance, bet)
        public List<Adatok> jatekosNevek = new List<Adatok>();
        // Holds bets as integers for easy numeric operations
        public List<int> jatekosTetek = new List<int>();
    }
}

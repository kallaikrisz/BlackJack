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
        public List<Adatok> jatekosAdatok = new List<Adatok>();
        public int OsztoPont = 0;
        public int AktualJatekos = 0;
    }
}

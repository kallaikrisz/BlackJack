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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] pakli = new string[]
        {
            "1;H2;2", "2;H3;3", "3;H4;4", "4;H5;5", "5;H6;6", "6;H7;7",
            "7;H8;8", "8;H9;9", "9;H10;10", "10;HJ;10", "11;HQ;10", "12;HK;10", "13;HA;11",
            "14;D2;2", "15;D3;3", "16;D4;4", "17;D5;5", "18;D6;6", "19;D7;7",
            "20;D8;8", "21;D9;9", "22;D10;10", "23;DJ;10", "24;DQ;10", "25;DK;10", "26;DA;11",
            "27;C2;2", "28;C3;3", "29;C4;4", "30;C5;5", "31;C6;6", "32;C7;7",
            "33;C8;8", "34;C9;9", "35;C10;10", "36;CJ;10", "37;CQ;10", "38;CK;10", "39;CA;11",
            "40;S2;2", "41;S3;3", "42;S4;4", "43;S5;5", "44;S6;6", "45;S7;7",
            "46;S8;8", "47;S9;9", "48;S10;10", "49;SJ;10", "50;SQ;10", "51;SK;10", "52;SA;11"
        };
    }
}
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
using System.Threading; 

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> lines = new List<string>() { "I've come to bring good news of great joy.", "Do not be afraid, for while you yourself may not recognize me, I know you.", "I know everything about what makes you human.", "I know what you love.", "I know what you dread.", "...", "Anyways get in your bed you moron it's " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() };
        private int i = 0;
        private MessageWindow mw = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LineDisplay(string l)
        {
            mw.Line_TextBlock.Text = l;
            mw.Show();
        }


        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (i < lines.Count())
            {
                if (mw != null)
                {
                    mw.Close();
                }

                mw = new MessageWindow();
                mw.Owner = this;

                LineDisplay(" ");

                Thread.Sleep(1000);
                string l = lines[i];

                LineDisplay(l);

                ++i;
            }
        }
    }
}
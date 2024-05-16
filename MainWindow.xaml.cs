using System.Collections.ObjectModel;
using System.Net.Http;
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
using System.Net.Http.Headers;

namespace Prog122_S24_L10_NewWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            //NewControl nc = new NewControl();
            //nc.Width = 300;
            //nc.Height = 300;
            

            //canvasMain.Children.Add(nc);
            //MessageBox.Show(canvasMain.Children.Count.ToString());
        }

        private void btnVisability_Click(object sender, RoutedEventArgs e)
        {
   
            //userControlNewControl.Visibility = 
            //    (userControlNewControl.IsVisible) ?
            //    Visibility.Hidden :
            //    Visibility.Visible;







        }

        private void btnNewControl_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;

            NewControl nc = new NewControl();
            nc.Width = canWidth;
            nc.Height = canHeight;

            canvasDisplay.Children.Add(nc);

        }

        private void btnUCWindow2_Click(object sender, RoutedEventArgs e)
        {
            ClearCanvas();
            double canWidth = canvasDisplay.Width;
            double canHeight = canvasDisplay.Height;

            UCWindow2 ucw = new UCWindow2();
            ucw.Width = canWidth;
            ucw.Height = canHeight;

            canvasDisplay.Children.Add(ucw);
        }

        public void ClearCanvas()
        {
            canvasDisplay.Children.Clear();
        }
    }
}
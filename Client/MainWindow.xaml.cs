using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.ServiceChat;
namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            double a = Math.PI / (Convert.ToDouble(A.Text));
            double b = Math.PI * (Convert.ToDouble(B.Text));
            double c = Convert.ToDouble(C.Text);
            double x = Convert.ToDouble(X.Text) / Math.Pow(Math.PI, 2);

            ServiceChatClient serviceChatClient = new ServiceChatClient();
            double result = serviceChatClient.TASK(a,b,c,x);
            RESULT.Content = result;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void X_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

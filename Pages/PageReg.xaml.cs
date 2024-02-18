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

namespace ShopDNS.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {

            string login = textBoxLogin.Text.Trim();

            string password = textBoxPassword.Text.Trim();

            string email = textBoxEmail.Text.Trim().ToLower();



            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введено не корректно";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (password.Length < 5 || !password.Contains("!") && !password.Contains(".") && !password.Contains("*") && !password.Contains("?") && !password.Contains("&"))
            {
                textBoxPassword.ToolTip = "Это поле введено не корректно";
                textBoxPassword.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;

                textBoxPassword.ToolTip = "";
                textBoxPassword.Background = Brushes.Transparent;

                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;


                Classes.ClassFrame.frmObj.Navigate(new Pages.PageOne());


            }

        }
    }
}

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
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Login1
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

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            var check = con.QueryAsync<Login>("exec SP_Retrieve_Login @username @password", new
            {
                username = tb_username.Text,
                password = tb_pwd.Password
            }
            ).Result.SingleOrDefault();
            string username = check.username;
            string password = check.password;

            if (username == tb_username.Text)
            {
                if (password == tb_pwd.Password)
                {
                    Main_page reg = new Main_page();
                    reg.Show();
                    this.Close();
                }
                else if (username != tb_username.Text)
                {
                    MessageBox.Show("Invalid Login");
                }
                else
                {
                    MessageBox.Show("Invalid Login ");
                }
                con.Close();
            }
        }
    }
}
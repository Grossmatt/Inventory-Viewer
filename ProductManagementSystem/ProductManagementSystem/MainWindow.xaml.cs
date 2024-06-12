using MySql.Data.MySqlClient;
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

namespace ProductManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string? TestText { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            /*this.DataContext = this;

            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "temp";
            dbCon.UserName = "admin";
            dbCon.Password = "admin";
            if (dbCon.IsConnect())
            {
                string query = "SELECT * FROM products";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int someStringFromColumnZero = reader.GetInt32(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    int someStringFromColumnTwo = reader.GetInt32(2);
                    TestText = someStringFromColumnZero + ", " + someStringFromColumnOne + ", " + someStringFromColumnTwo;
                }
                dbCon.Close();
            }*/
        }
    }
}
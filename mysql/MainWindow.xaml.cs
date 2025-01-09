using System.Data;
using System.Windows;
using System.Windows.Media.Media3D;
using MySql.Data.MySqlClient;

namespace mysql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect();
        }

        private void Connect()
        {
            string connexionString = "server=109.234.165.136;database=sc4judi6669_test;uid=sc4judi6669_oceane;password=E_*J$d(*F.Sh";
            MySqlConnection connexion = new MySqlConnection(connexionString);
            MySqlCommand cmd = new MySqlCommand("SELECT name as NOM FROM users;", connexion);
            DataTable dt = new DataTable();

            try
            {
                connexion.Open();
                dt.Load(cmd.ExecuteReader());
                connexion.Close();
            }
            catch(Exception e ) {
                throw new Exception("Erreur à l'ouverture de la bdd : " + e.Message);
            }

            dg.ItemsSource = dt.DefaultView;
        }
    }
}
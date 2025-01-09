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
            string connexionString = "server=localhost;database=test;uid=root;password=;";
            MySqlConnection connexion = new MySqlConnection(connexionString);
            try
            {
                connexion.Open();
                MessageBox.Show("Bdd ouverte !");
                connexion.Close();
            }
            catch(Exception e ) {
                throw new Exception("Erreur à l'ouverture de la bdd : " + e.Message);
            }
        }
    }
}
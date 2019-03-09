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
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace consulta_adop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Clsconexion conec = new Clsconexion();
        SqlCommand cm;
        DataTable dt;

        public DataTable DT_mascota()
        {
            string sp_mas = "sp_searc";
            cm = new SqlCommand(sp_mas, conec.conec);

            SqlDataAdapter ad = new SqlDataAdapter(cm);
            dt = new DataTable();
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            ad.SelectCommand.Parameters.AddWithValue("@Busca", txtsr.Text.Trim());
            ad.Fill(dt);
            grid1.DataContext = dt;
            return dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DT_mascota();
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
           
            
                string sp_mas = "sp_busca";
                cm = new SqlCommand(sp_mas, conec.conec);

                SqlDataAdapter ad = new SqlDataAdapter(cm);
                dt = new DataTable();
                ad.SelectCommand.CommandType = CommandType.StoredProcedure;
                ad.SelectCommand.Parameters.AddWithValue("@dt_cuidador", txtsr.Text.Trim());
                ad.Fill(dt);
                grid1.DataContext = dt;
                
           

        }
    }
}

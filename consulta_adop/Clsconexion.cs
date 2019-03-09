using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace consulta_adop
{
    class Clsconexion
    {
        public SqlConnection conec;
        public Clsconexion()
        {
            try
            {
                conec = new SqlConnection(ConfigurationManager.ConnectionStrings["consulta_adop.Properties.Settings.conexion"].ConnectionString);
                conec.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nose puede conectar" + ex.ToString());
            }
        }
    }
}

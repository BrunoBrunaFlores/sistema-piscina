using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SISTEMA_PISCINA
{
    public partial class Ganacia_por_fecha : Form
    {
        private Form frm;
        public static OleDbConnection conexion = null;
        public Ganacia_por_fecha(Form frm_)
        {
            frm = frm_;
            InitializeComponent();

            OleDbConnectionStringBuilder b4 = new OleDbConnectionStringBuilder();
            b4.Provider = "Microsoft.ACE.OLEDB.12.0";
            b4.DataSource = "BaseDeDatosPiscina.accdb";
            conexion = new OleDbConnection(b4.ToString());
            conexion.Open();
        }

        private void btnConsultar_Click(object sender, EventArgs e) //BOTON CONSULTAR GANANCIA POR FECHA
        {
            String Fecha = FechaBuscada.Text;

            OleDbCommand cmd = new OleDbCommand("SELECT SUM(Costo_de_entrada) FROM Registros_de_por_vida WHERE Fecha = @fecha ", conexion);
            cmd.Parameters.AddWithValue("@fecha", Fecha);
            cmd.ExecuteNonQuery();

            if (Convert.ToString(cmd.ExecuteScalar()) != "")
            {
                int Ganancia = Convert.ToInt32(cmd.ExecuteScalar());
                LblGanacia.Text = Ganancia.ToString();
            }
            else
            {
                LblGanacia.Text = "No hubo ganacia";
            }
        }
    }
}

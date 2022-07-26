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
    public partial class Form1 : Form
    {
        public static OleDbConnection conexion = null;
        public Form1()
        {
            InitializeComponent();
            OleDbConnectionStringBuilder b = new OleDbConnectionStringBuilder();
            b.Provider = "Microsoft.ACE.OLEDB.12.0";
            b.DataSource = "BaseDeDatosPiscina.accdb";
            conexion = new OleDbConnection(b.ToString());
            conexion.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MAL
        }
        private void button1_Click(object sender, EventArgs e) //BOTON ENTRAR
        {
            int cartel = 0;

            OleDbCommand seleccionarNombre = new OleDbCommand("SELECT usuarios, contraseñas From Accesos", conexion);

            OleDbDataReader LectorRegistros = seleccionarNombre.ExecuteReader();

            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
            {
                cartel = 9;

                while (LectorRegistros.Read())
                {
                    if ((txtUsuario.Text == LectorRegistros.GetValue(0).ToString()) && (txtContraseña.Text == LectorRegistros.GetValue(1).ToString()))
                    {
                        cartel = 0;
                        principal form = new principal(this);
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete la información necesaria en los campos!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (cartel == 9)
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e) //BOTON AYUDA
        {
            MessageBox.Show("Ingrese en los campos la información necesaria para acceder al sistema", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e) //BOTON SALIR
        {
            this.Close();
        }
    }
}

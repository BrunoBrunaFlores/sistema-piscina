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
    public partial class principal : Form
    {
        private Form frm;
        public static OleDbConnection conexion = null;
        public principal(Form frm_)
        {
            frm = frm_;
            InitializeComponent();
            OleDbConnectionStringBuilder b3 = new OleDbConnectionStringBuilder();
            b3.Provider = "Microsoft.ACE.OLEDB.12.0";
            b3.DataSource = "BaseDeDatosPiscina.accdb";
            conexion = new OleDbConnection(b3.ToString());
            conexion.Open();

            Mostrar_Lista_Temporal();
            Mostrar_Lista_Reportes();
            timer1.Start();
        }
        DataTable resulta;
        private void button1_Click(object sender, EventArgs e) //BOTON REGISTRAR
        { 
            String Nombres = txtNombres.Text;
            String Tipo_entrada = null;
            Decimal Costo_entrada = 0;
            String Nro_candado = txtCandado.Text;
            String Sexo = null;
            String Saldo = txtSaldo.Text;
            String Observaciones = txtObservaciones.Text;

            String Hora = DateTime.Now.ToLongTimeString();
            String Fecha =DateTime.Now.ToLongDateString();
 

            if (rdoNiño.Checked || rdoGeneral.Checked || rdoEspecifica.Checked) //GUARDA DATOS DEL TIPO DE ENTRADA
            {
                if (rdoNiño.Checked)
                {
                    Tipo_entrada = "NIÑO";
                    Costo_entrada = 2;
                }
                if (rdoGeneral.Checked)
                {
                    Tipo_entrada = "GENERAL";
                    Costo_entrada = 3;
                }
                if (rdoEspecifica.Checked)
                {   
                    if(txtNombreEspecifi.Text!="" && txtPrecioEspecifi.Text!="")
                    {
                        Tipo_entrada = txtNombreEspecifi.Text;
                        Costo_entrada = Convert.ToDecimal(txtPrecioEspecifi.Text);
                    }
                    else
                    {
                            MessageBox.Show("¡Asegurece de llenar los campos el apartado especifica!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("¡No se registro el tipo de entrada!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (rdoMujer.Checked || rdoVaron.Checked) //GUARDA DATOS DEL TIPO DE SEXO
            {
                if (rdoMujer.Checked)
                {
                    Sexo = "MUJER";
                }
                if (rdoVaron.Checked)
                {
                    Sexo = "VARÓN";
                }
            }
            else
            {
                MessageBox.Show("¡No se registro el tipo de sexo!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Nombres != "" && Tipo_entrada != null && Nro_candado != "" && Sexo != "") //CONDICION ANTES DE LLENAR LA BD
            {
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Registros_temporal (Nombres_y_apellidos,Tipo_de_entrada,Costo_de_entrada,Nro_candado,Sexo,Saldo,Observaciones,Hora,Fecha) VALUES (@nombres,@entrada,@costo,@candado,@sexo,@saldo,@observaciones,@hora,@fecha)", conexion);
                cmd.Parameters.AddWithValue("@nombres", Nombres);
                cmd.Parameters.AddWithValue("@entrada", Tipo_entrada);
                cmd.Parameters.AddWithValue("@costo", Costo_entrada);
                cmd.Parameters.AddWithValue("@candado", Nro_candado);
                cmd.Parameters.AddWithValue("@sexo", Sexo);
                cmd.Parameters.AddWithValue("@saldo", Saldo);
                cmd.Parameters.AddWithValue("@observaciones", Observaciones);
                cmd.Parameters.AddWithValue("@hora", Hora);
                cmd.Parameters.AddWithValue("@fecha", Fecha);

                cmd.ExecuteNonQuery();

                //PARA EL REGISTRO DE POR VIDA

                OleDbCommand cmd2 = new OleDbCommand("INSERT INTO Registros_de_por_vida (Nombres_y_apellidos,Tipo_de_entrada,Costo_de_entrada,Nro_candado,Sexo,Saldo,Observaciones,Hora,Fecha) VALUES (@nombres,@entrada,@costo,@candado,@sexo,@saldo,@observaciones,@hora,@fecha)", conexion);
                cmd2.Parameters.AddWithValue("@nombres", Nombres);
                cmd2.Parameters.AddWithValue("@entrada", Tipo_entrada);
                cmd2.Parameters.AddWithValue("@costo", Costo_entrada);
                cmd2.Parameters.AddWithValue("@candado", Nro_candado);
                cmd2.Parameters.AddWithValue("@sexo", Sexo);
                cmd2.Parameters.AddWithValue("@saldo", Saldo);
                cmd2.Parameters.AddWithValue("@observaciones", Observaciones);
                cmd2.Parameters.AddWithValue("@hora", Hora);
                cmd2.Parameters.AddWithValue("@fecha", Fecha);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("¡REGISTRADO!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mostrar_Lista_Temporal();
                Mostrar_Lista_Reportes();
            }
            else
            {
                MessageBox.Show("¡Asegurece de llenar correctamente los campos con (*) !", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void principal_Load(object sender, EventArgs e)
        {
            //mal
        }
        private void principal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            frm.Close();
        }
        void Mostrar_Lista_Temporal() //TABLA TEMPORAL
        {
            OleDbCommand aux = new OleDbCommand("SELECT * FROM Registros_temporal", conexion);

            resulta = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(aux);
            adapter.Fill(resulta);

            tblListaTemporal.DataSource = resulta;
        }
        void Mostrar_Lista_Reportes() //TABLA DE POR VIDA
        {
            OleDbCommand aux = new OleDbCommand("SELECT * FROM Registros_de_por_vida", conexion);

            DataTable results = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(aux);
            adapter.Fill(results);

            tblListaReportes.DataSource = results;
        }
        private void timer1_Tick(object sender, EventArgs e) //HORA CORRIENDO EN EL SISTEMA
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void button3_Click(object sender, EventArgs e) //METODO GANANCIAS DEL DIA
        {
            String Fecha = DateTime.Now.ToLongDateString();

            OleDbCommand cmd = new OleDbCommand("SELECT SUM(Costo_de_entrada) FROM Registros_de_por_vida WHERE Fecha = @fecha ", conexion);
            cmd.Parameters.AddWithValue("@fecha", Fecha);
            cmd.ExecuteNonQuery();

            if (Convert.ToString(cmd.ExecuteScalar())!="")
            {
                int Ganancia = Convert.ToInt32(cmd.ExecuteScalar());
                LblGananciaDia.Text = Ganancia.ToString();
            }
            else
            {
                LblGananciaDia.Text = "Aún no hay ganancia";
            }
        }
        private void button4_Click(object sender, EventArgs e) //BOTON GANANCIA POR FECHA
        {
            Ganacia_por_fecha form = new Ganacia_por_fecha(this);
            form.Show();
        }
        private void btnSalida_Click(object sender, EventArgs e) //BOTON MARCAR SALIDA
        {
            var Id = this.tblListaTemporal.CurrentRow.Cells[0].Value;

            int id = Convert.ToInt16(Id);

            OleDbCommand cmd = new OleDbCommand("DELETE FROM Registros_temporal WHERE id=@id", conexion);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            Mostrar_Lista_Temporal();
            MessageBox.Show("¡Salida marcada!", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdoEspecifica_CheckedChanged(object sender, EventArgs e) //METODO PARA CONTROLAR EL GRUPO ESPECIFICA
        {
            if (rdoEspecifica.Checked == true)
            {
                GrpEspecifica.Enabled = true;
            }
            if (rdoEspecifica.Checked == false)
            {
                GrpEspecifica.Enabled = false;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e) //METODO FILTRAR BUSQUEDA POR NOMBRES
        {
            DataView BQ = new DataView(resulta);
            BQ.RowFilter = string.Format("Nombres_y_apellidos LIKE '%{0}%'",txtBuscaNombre.Text);
            tblListaTemporal.DataSource = BQ;
        }
        private void txtBuscaCandado_TextChanged(object sender, EventArgs e) //METODO FILTRAR BUSQUEDA POR CANDADO
        {
            DataView BQ = new DataView(resulta);
            BQ.RowFilter = string.Format(" Nro_candado LIKE '%{0}%'", txtBuscaCandado.Text);
            tblListaTemporal.DataSource = BQ;
        }
        private void txtBuscaFecha_TextChanged(object sender, EventArgs e) //METODO FILTRAR BUSQUEDA POR HORA (falta corregir)
        {
            DataView BQ = new DataView(resulta);
            BQ.RowFilter = string.Format(" Hora LIKE '%{0}%'", txtBuscaCandado.Text);
            tblListaTemporal.DataSource = BQ;
        }
        
    }
}

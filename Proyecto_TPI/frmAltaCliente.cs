using Proyecto_TPI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TPI
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            cargarCombosLocalidad();
            LimpiarCampos();
            CargarGrilla();
            cargarCombosBarrios();

            //cboBarrio.Enabled = false;
            //cboBarrio.Items.Add("Los caldenes");
            //cboLocalidad.Items.Add("Cordoba");
        }

        private void cargarCombosLocalidad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Localidad";


                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboBarrio.DataSource = tabla;

                cboBarrio.DisplayMember = "nombre";
                cboBarrio.ValueMember = "id_localidad";
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        private void cargarCombosBarrios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Barrios";


                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                cboLocalidad.DataSource = tabla;

                cboLocalidad.DisplayMember = "nombre";
                cboLocalidad.ValueMember = "id_Barrio";
                

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }



        private void CargarGrilla()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];


            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT nro_cliente, nombre_cliente, calle, nro_calle, id_barrio, id_localidad FROM Cliente";


                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                gdrClientes.DataSource = tabla;


                
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocalidad.SelectedIndex != -1)
            {
                cboBarrio.Enabled =true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtNroCliente.Text = "";
            txtNombre.Text = "";
            txtCalle.Text = "";
            txtNroCasa.Text = "";
            
            cboLocalidad.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
        }


        private void AgregarCliente(Cliente cli)
        {
            DataGridViewRow fila = new DataGridViewRow();


            DataGridViewTextBoxCell celdaNumero = new DataGridViewTextBoxCell();
            celdaNumero.Value = cli.NumeroCliente;
            fila.Cells.Add(celdaNumero);

            DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
            celdaNombre.Value = cli.NombreCliente;
            fila.Cells.Add(celdaNombre);

            gdrClientes.Rows.Add(fila);

            MessageBox.Show("Persona agregada con exito");
            LimpiarCampos();
            txtNroCliente.Focus();

        }

        
        private Cliente ObtenerDatosCliente()
        {
            Cliente c = new Cliente();
            c.NumeroCliente = txtNroCliente.Text.Trim();
            c.NombreCliente = txtNombre.Text.Trim();
            c.calle = txtCalle.Text.Trim();
            c.nroCalle = txtNroCasa.Text.Trim();
            c.barrio = (int)cboBarrio.SelectedValue;
            c.localidad = (int)cboLocalidad.SelectedValue;
            return c;

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente cli = ObtenerDatosCliente();

            bool resultado = AgregarClienteABD(cli);
            if (resultado)
            {
                MessageBox.Show("Persona Agregada con exito....");
                LimpiarCampos();
                cargarCombosBarrios();
                cargarCombosLocalidad();
                CargarGrilla();

            }
            else
            {
                MessageBox.Show("Error al agregar la persona...");
            }
        }

        private bool AgregarClienteABD(Cliente cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO cliente (nro_cliente, nombre_cliente, calle, nro_calle, id_barrio, id_localidad) VALUES (@nroCliente, @nomCliente, @calle, @nroCalle, @Barrio, @Localidad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCliente", cli.NumeroCliente);
                cmd.Parameters.AddWithValue("@nomCliente", cli.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", cli.calle);
                cmd.Parameters.AddWithValue("@Barrio", cli.barrio);
                cmd.Parameters.AddWithValue("@Localidad", cli.localidad);
                cmd.Parameters.AddWithValue("@nroCalle", cli.nroCalle);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        private void gdrClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrClientes.Rows[indice];

            string nroCliente = filaSeleccionada.Cells["Numero"].Value.ToString();

            Cliente cli = ObtenerPersona(nroCliente);
            LimpiarCampos();
            CargarCampos(cli);

        }

        private void CargarCampos(Cliente cli)
        {
            txtNroCliente.Text =  cli.NumeroCliente.ToString();
            txtNombre.Text = cli.NombreCliente;
            txtCalle.Text = cli.nroCalle;
            txtNroCasa.Text = cli.nroCalle.ToString();
            cboBarrio.SelectedValue = cli.barrio;
            cboLocalidad.SelectedValue = cli.localidad;
        }

        private Cliente ObtenerPersona(string numeroCli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Cliente cli = new Cliente();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Cliente WHERE 1=1 AND nro_cliente like @nroCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCliente", numeroCli);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr !=null && dr.Read())
                {
                    cli.NumeroCliente = dr["nro_cliente"].ToString();
                    cli.NombreCliente = dr["nombre_cliente"].ToString();
                    cli.calle = dr["calle"].ToString();
                    cli.nroCalle = dr["nro_calle"].ToString();
                    cli.barrio = int.Parse(dr["id_barrio"].ToString());
                    cli.localidad = int.Parse( dr["id_localidad"].ToString());

                }

            }
            catch (Exception)
            {

                throw;
            }
            return cli;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cli = ObtenerDatosCliente();
            bool resultado = ActualizarCliente(cli);
            if (resultado)
            {
                MessageBox.Show("Cliente actualizada con exito");
                LimpiarCampos();
                CargarGrilla();
                cargarCombosBarrios();
                cargarCombosLocalidad();
            }
            else
            {
                MessageBox.Show("Error al actualizar cliente...");
            }
        }
        private bool ActualizarCliente(Cliente cli)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE cliente " +
                    "SET nro_cliente=@nroCliente, nombre_cliente=@nomCliente, calle=@calle, nro_calle=@nroCalle, id_barrio=@Barrio, id_localidad=@Localidad " +
                    "Where nro_cliente like @nroCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroCliente", cli.NumeroCliente);
                cmd.Parameters.AddWithValue("@nomCliente", cli.NombreCliente);
                cmd.Parameters.AddWithValue("@calle", cli.calle);
                cmd.Parameters.AddWithValue("@Barrio", cli.barrio);
                cmd.Parameters.AddWithValue("@Localidad", cli.localidad);
                cmd.Parameters.AddWithValue("@nroCalle", cli.nroCalle);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;

        }

        /*private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;
            for (int i = 0; i < gdrClientes.Rows.Count; i++)
            {
                if (gdrClientes.Rows[i].Cells["Numero"].Value.Equals(criterioABuscar))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }*/


    }
}

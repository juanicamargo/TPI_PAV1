using Proyecto_TPI.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Proyecto_TPI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);



            if (txtUsuario.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Ingre nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string pass = txtPassword.Text;
                bool resultado = false;
                try
                {
                    resultado = ValidarUsuario(nombreDeUsuario, pass);
                    if (resultado)
                    {

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el usuario");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar usuario");
                    
                }

                
                
                

            }

            //string usuCorrecto = "Juan";
            //string passwordCorrecto = "1234";

            


        }

        public bool ValidarUsuario(string pUsuario, string pPassword)
        {
            

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];

           
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                //Inicializamos la variable usuarioValido en false, para que solo si el usuario es valido retorne true
                bool usuarioValido = false;
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM usuarios WHERE usuario like @nombreUsu AND password like @pass" ;


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", pUsuario);
                cmd.Parameters.AddWithValue("@pass", pPassword);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);


                if (tabla.Rows.Count > 0) { usuarioValido = true; }

                return usuarioValido;
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


    }
}
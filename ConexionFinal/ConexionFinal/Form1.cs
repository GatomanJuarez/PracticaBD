using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionFinal
{
    public partial class Form1 : Form
    {
        //se construye la direccion de la bd
        MySqlConnectionStringBuilder direcc = new MySqlConnectionStringBuilder();
        //Se crea una conexion a mysql
        MySqlConnection conexion = null;
        MySqlCommand comando = null;
        MySqlDataAdapter con = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
            direcc.Server = "localhost";//localhost o 127.0.0.1
            direcc.UserID = "root";
            direcc.Password = "hola";
            direcc.Database = "eventos";
            //Guardamos el constructor de la coneccion (convertido a string), en la coneccion
            conexion = new MySqlConnection(direcc.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conex();
        }

        private void conex()
        { 
            //Se intenta conexion
            try
            {
                conexion.Open();
                //Muestra el mensaje
                MessageBox.Show("La coneccion se realizo correctamente", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al conectarse", "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                conexion.Close();
            }

         }

        private void btnconex_Click(object sender, EventArgs e)
        {
            conex();
        }
        
        private void consult()
        {
            try
            {            
                conexion.Open();
                //aqui le decimos que le vamos a pasar un comando '" + txtnombres.Text + "'
                comando = new MySqlCommand("Select * from Usuarios ", conexion);
                //Creamos un adaptador de informacion
                //Recupera la totalidad de la tabla
                con = new MySqlDataAdapter(comando);
                //Para los valores que obtengamos de la tabla
                //Representa un conjunto de datos, tablas,
                ds = new DataSet();
                //Se llenan los valores y los guarda el adaptador
                //utiliza el formato de la tabla
                con.Fill(ds);
                //Se muestra en el DataGridView, se empieza en la posicion 
                //Para el origen de los datos
                Dgview.DataSource = ds.Tables[0];
                //Cerramos la conexion
                conexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show("Error al consultar " + error);
                conexion.Close();
            }
        }

        private void consulta_Click(object sender, EventArgs e)
        {
            consult();   
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando = new MySqlCommand("insert into Usuarios(nombre,edad)values('"+txtnombre.Text+"','"+txtedad.Text+"')", conexion);
                txtnombre.Text = ""; txtedad.Text = "";
                //Ejecuta la instruccion del comando y devuelve el numero de columnas afectada
                int uno = comando.ExecuteNonQuery();
                MessageBox.Show("Numero de filas afectada: " + uno,"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                conexion.Close();
                consult();
            }
            catch (MySqlException errorr)
            {
                MessageBox.Show("Error al insertar " + errorr);
                conexion.Close();
            }

            }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando = new MySqlCommand("delete from Usuarios where nombre='" + txtnombres.Text + "'", conexion);
                txtnombres.Text = "";
                //Ejecuta el comando de arriba y nos dice cuantas filas se afectaron
                int uno = comando.ExecuteNonQuery();
                MessageBox.Show("Numero de filas afectada: " + uno, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
                consult();
            }
            catch (MySqlException errorr)
            {
                MessageBox.Show("Error al insertar " + errorr);
                conexion.Close();
            }
    }
        
        private void btnordenar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                comando = new MySqlCommand("Select * from Usuarios order by nombre", conexion);
                con = new MySqlDataAdapter(comando);
                //Para los valores que obtengamos de la tabla
                ds = new DataSet();
                //Se llenan los valores y los guarda el adaptador
                con.Fill(ds);
                //Se muestra en el DataGridView, se empieza en la posicion 
                Dgview.DataSource = ds.Tables[0];
                //Cerramos la conexion
                conexion.Close();
            }
            catch (MySqlException errorr)
            {
                MessageBox.Show("Error al ordenar " + errorr);
                conexion.Close();
            }   
        }
    }
}

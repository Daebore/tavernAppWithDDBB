using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.database1DataSet.Usuarios);

        }

        private void cartelregistro_Click(object sender, EventArgs e)
        {

        }

        private void label_user_Click(object sender, EventArgs e)
        {

        }

        private void label_pass_Click(object sender, EventArgs e)
        {

        }

        private void meter_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_registro_Click(object sender, EventArgs e)
        {

            // Declaramos un boolean que va a permitirnos comprobar si ya existe en la BBDD un usuario registrado
            // con ese nombre
            Boolean existe = false;

            // Con esta sentencia, nos conectamos a la tabla Usuarios de la BBDD
            Database1DataSetTableAdapters.UsuariosTableAdapter adapter = new Database1DataSetTableAdapters.UsuariosTableAdapter();

            // Con lo anterior, creamos un array bidimensional (tupla-campo) con la información de la tabla
            Database1DataSet.UsuariosDataTable tablaUsuarios = adapter.GetData();

            // Recorremos el array
            for (int i = 0; i < tablaUsuarios.Count; i++)
            {
                // Si el primer elemento (el nombre) coincide con lo que hay en el campo meter_usuario
                // significa qyue ya existe un usuario registrado con ese nombre
                if (tablaUsuarios[i][0].ToString().Trim() == meter_usuario.Text)
                {
                    existe = true;
                    label_error.Visible = true;

                }
            }

            // Si el valor de existe es falseo, significa que no existe ningún usuario con el mismo nombre en la BBDD
            if (existe == false)
            {
                // Volvemos a hacer lo mismo
                Database1DataSetTableAdapters.UsuariosTableAdapter tablaUsuario = new Database1DataSetTableAdapters.UsuariosTableAdapter();

                // Hacemos el insert en la BBDD
                tablaUsuario.Insert(meter_usuario.Text, meter_pass.Text);

                // Vaciamos los campos de nobmre y contraseña
                meter_usuario.Text = "";
                meter_pass.Text = "";

                label_exito.Visible = true;
                label_error.Visible = false;
                fallo_vacio.Visible = false;
            }

        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Reiniciamos el valor de los registros y escondemos los mensajes de error
            label_creado.Visible = false;
            label_error.Visible = false;
            fallo_vacio.Visible = false;
            meter_usuario.Text = "";
            meter_pass.Text = "";
        }

        private void antorchaI_Click(object sender, EventArgs e)
        {

        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            //Volvemos a la pantalla principal y escondemos la actual
            new ventana().Show();
            this.Close();
        }

        private void meter_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void label_creado_Click(object sender, EventArgs e)
        {

        }

        private void dark_souls2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_crearUser_Click(object sender, EventArgs e)
        {

        }

        private void fallo_vacio_Click(object sender, EventArgs e)
        {

        }

        private void registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void label_exito_Click(object sender, EventArgs e)
        {

        }
    }
}

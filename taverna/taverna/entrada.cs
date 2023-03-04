using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taverna
{
    public partial class ventana : Form
    {

        public ventana()
        {
            InitializeComponent();
            contarUsers();

        }

        private void ventana_Load(object sender, EventArgs e)
        {


        }

        private void antorchaD_Click(object sender, EventArgs e)
        {

        }

        private void boton_entrar_Click(object sender, EventArgs e)
        {
            // Creamos un array bidimensional con el quie vamos a poder acceder a todos los elementos de la tabla Usuarios
            // La primera posición del array bidimensional coincide con la tupla y la segunda con los elementos de la taba
            // (posición 0 será el nombre y la posición 1 la contraseña)
           Database1DataSetTableAdapters.UsuariosTableAdapter adapter = new Database1DataSetTableAdapters.UsuariosTableAdapter();
            Database1DataSet.UsuariosDataTable tablaUsuarios = adapter.GetData();

            for (int i = 0; i < tablaUsuarios.Count; i++)
            {
                // Comprobamos que el nombre introducido en meter_usuario.Text coincide con algún nombre de la BBDD
                if (tablaUsuarios[i][0].ToString().Trim() == meter_usuario.Text)
                {
                    // Comprobamos que la contraseña introducida en meter_pass.Text coincide con alguna contraseña de la BBDD
                    if (tablaUsuarios[i][1].ToString().Trim() == meter_pass.Text)
                    {
                        // Si ambos coinciden, guardamos el nombre del usuario en la variable estática nombreUser
                        // que pertenece al form salonTaberna (para poder mostrar el nombre del usuario registrado
                        // en la siguiente ventana), nos vamos a salonTaberna y cerramos el form actual
                        salonTaberna.nombreUser = meter_usuario.Text;
                        new salonTaberna().Show();
                        this.Close();
                    }
                }

                // Si no coincide el nombre, mostramos un mensaje de error (es redundante comporbar la contraseña
                // si el nombre no coincide)
                label_error.Visible = true;
            }
             
        }

        private void boton_salir_Click(object sender, EventArgs e)
        {
            //Salimos del programa
            this.Close();
        }

        private void meter_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_usuario_Click(object sender, EventArgs e)
        {

        }

        private void boton_borrar_Click(object sender, EventArgs e)
        {
            //Si pulsamos en el botón borrar, escondemos el mensaje de error y reiniciamos los 
            //registros de los textBox de nombre y contraseña
            label_error.Visible = false;
            meter_usuario.Text = "";
            meter_pass.Text = "";
        }

        private void meter_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_pass_Click(object sender, EventArgs e)
        {

        }

        private void cartelgrande_Click(object sender, EventArgs e)
        {

        }

        private void boton_registro_Click(object sender, EventArgs e)
        {
            //Nos movemos a la pantalla de registro y escondemos la actual
            new registro().Show();
            this.Close();
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }
        
        private void contarUsers()
        {
            // Contamos el número de registros de la BBDD con Count() y lo guardamos en una variable
            Database1DataSetTableAdapters.UsuariosTableAdapter adapter = new Database1DataSetTableAdapters.UsuariosTableAdapter();
            Database1DataSet.UsuariosDataTable tablaUsuarios = adapter.GetData();

            label_registados.Text += tablaUsuarios.Count;

        }

        private void label_registados_Click(object sender, EventArgs e)
        {

        }

        private void pergamino_numUser_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void ventana_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.cerrar();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void usuariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

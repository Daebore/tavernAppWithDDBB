namespace taverna
{
    partial class registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.cartelregistro = new System.Windows.Forms.PictureBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.meter_usuario = new System.Windows.Forms.TextBox();
            this.meter_pass = new System.Windows.Forms.TextBox();
            this.boton_registro = new System.Windows.Forms.Button();
            this.boton_borrar = new System.Windows.Forms.Button();
            this.antorchaI = new System.Windows.Forms.PictureBox();
            this.antorchaD = new System.Windows.Forms.PictureBox();
            this.boton_salir = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.label_creado = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.PictureBox();
            this.dark_souls2 = new System.Windows.Forms.PictureBox();
            this.label_crearUser = new System.Windows.Forms.Label();
            this.fallo_vacio = new System.Windows.Forms.Label();
            this.database1DataSet = new taverna.Database1DataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new taverna.Database1DataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new taverna.Database1DataSetTableAdapters.TableAdapterManager();
            this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.label_exito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartelregistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antorchaI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antorchaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dark_souls2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
            this.usuariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartelregistro
            // 
            this.cartelregistro.BackColor = System.Drawing.Color.Transparent;
            this.cartelregistro.Image = ((System.Drawing.Image)(resources.GetObject("cartelregistro.Image")));
            this.cartelregistro.Location = new System.Drawing.Point(104, -22);
            this.cartelregistro.Name = "cartelregistro";
            this.cartelregistro.Size = new System.Drawing.Size(649, 406);
            this.cartelregistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartelregistro.TabIndex = 11;
            this.cartelregistro.TabStop = false;
            this.cartelregistro.Click += new System.EventHandler(this.cartelregistro_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Image = ((System.Drawing.Image)(resources.GetObject("label_user.Image")));
            this.label_user.Location = new System.Drawing.Point(260, 229);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(117, 33);
            this.label_user.TabIndex = 26;
            this.label_user.Text = "Usuario";
            this.label_user.Click += new System.EventHandler(this.label_user_Click);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Image = ((System.Drawing.Image)(resources.GetObject("label_pass.Image")));
            this.label_pass.Location = new System.Drawing.Point(260, 295);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(167, 33);
            this.label_pass.TabIndex = 27;
            this.label_pass.Text = "Contraseña";
            this.label_pass.Click += new System.EventHandler(this.label_pass_Click);
            // 
            // meter_usuario
            // 
            this.meter_usuario.BackColor = System.Drawing.Color.NavajoWhite;
            this.meter_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meter_usuario.Location = new System.Drawing.Point(431, 225);
            this.meter_usuario.Name = "meter_usuario";
            this.meter_usuario.Size = new System.Drawing.Size(162, 41);
            this.meter_usuario.TabIndex = 28;
            this.meter_usuario.TextChanged += new System.EventHandler(this.meter_usuario_TextChanged);
            // 
            // meter_pass
            // 
            this.meter_pass.BackColor = System.Drawing.Color.NavajoWhite;
            this.meter_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meter_pass.Location = new System.Drawing.Point(431, 285);
            this.meter_pass.Name = "meter_pass";
            this.meter_pass.PasswordChar = '*';
            this.meter_pass.Size = new System.Drawing.Size(162, 41);
            this.meter_pass.TabIndex = 29;
            this.meter_pass.TextChanged += new System.EventHandler(this.meter_pass_TextChanged);
            // 
            // boton_registro
            // 
            this.boton_registro.BackColor = System.Drawing.Color.Peru;
            this.boton_registro.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_registro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boton_registro.Location = new System.Drawing.Point(369, 340);
            this.boton_registro.Name = "boton_registro";
            this.boton_registro.Size = new System.Drawing.Size(129, 35);
            this.boton_registro.TabIndex = 30;
            this.boton_registro.Text = "Registrarse";
            this.boton_registro.UseVisualStyleBackColor = false;
            this.boton_registro.Click += new System.EventHandler(this.boton_registro_Click);
            // 
            // boton_borrar
            // 
            this.boton_borrar.BackColor = System.Drawing.Color.Peru;
            this.boton_borrar.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_borrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boton_borrar.Location = new System.Drawing.Point(507, 340);
            this.boton_borrar.Name = "boton_borrar";
            this.boton_borrar.Size = new System.Drawing.Size(86, 35);
            this.boton_borrar.TabIndex = 31;
            this.boton_borrar.Text = "Borrar";
            this.boton_borrar.UseVisualStyleBackColor = false;
            this.boton_borrar.Click += new System.EventHandler(this.boton_borrar_Click);
            // 
            // antorchaI
            // 
            this.antorchaI.BackColor = System.Drawing.Color.Transparent;
            this.antorchaI.Image = ((System.Drawing.Image)(resources.GetObject("antorchaI.Image")));
            this.antorchaI.Location = new System.Drawing.Point(25, 192);
            this.antorchaI.Name = "antorchaI";
            this.antorchaI.Size = new System.Drawing.Size(73, 140);
            this.antorchaI.TabIndex = 32;
            this.antorchaI.TabStop = false;
            this.antorchaI.Click += new System.EventHandler(this.antorchaI_Click);
            // 
            // antorchaD
            // 
            this.antorchaD.BackColor = System.Drawing.Color.Transparent;
            this.antorchaD.Image = ((System.Drawing.Image)(resources.GetObject("antorchaD.Image")));
            this.antorchaD.Location = new System.Drawing.Point(705, 186);
            this.antorchaD.Name = "antorchaD";
            this.antorchaD.Size = new System.Drawing.Size(73, 140);
            this.antorchaD.TabIndex = 33;
            this.antorchaD.TabStop = false;
            // 
            // boton_salir
            // 
            this.boton_salir.BackColor = System.Drawing.Color.IndianRed;
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.boton_salir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boton_salir.Location = new System.Drawing.Point(735, 423);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(65, 28);
            this.boton_salir.TabIndex = 34;
            this.boton_salir.Text = "Salir";
            this.boton_salir.UseVisualStyleBackColor = false;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.BackColor = System.Drawing.Color.Peru;
            this.boton_volver.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.boton_volver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boton_volver.Location = new System.Drawing.Point(270, 340);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(84, 35);
            this.boton_volver.TabIndex = 38;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = false;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(323, 399);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(210, 24);
            this.label_error.TabIndex = 41;
            this.label_error.Text = "Ya existe ese usuario";
            this.label_error.Visible = false;
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // label_creado
            // 
            this.label_creado.AutoSize = true;
            this.label_creado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_creado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creado.ForeColor = System.Drawing.Color.Red;
            this.label_creado.Location = new System.Drawing.Point(301, 423);
            this.label_creado.Name = "label_creado";
            this.label_creado.Size = new System.Drawing.Size(244, 24);
            this.label_creado.TabIndex = 42;
            this.label_creado.Text = "Usuario creado con éxito";
            this.label_creado.Visible = false;
            this.label_creado.Click += new System.EventHandler(this.label_creado_Click);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Image = ((System.Drawing.Image)(resources.GetObject("welcome.Image")));
            this.welcome.Location = new System.Drawing.Point(286, -31);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(287, 192);
            this.welcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcome.TabIndex = 45;
            this.welcome.TabStop = false;
            // 
            // dark_souls2
            // 
            this.dark_souls2.BackColor = System.Drawing.Color.Transparent;
            this.dark_souls2.Image = ((System.Drawing.Image)(resources.GetObject("dark_souls2.Image")));
            this.dark_souls2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dark_souls2.Location = new System.Drawing.Point(87, 176);
            this.dark_souls2.Name = "dark_souls2";
            this.dark_souls2.Size = new System.Drawing.Size(167, 288);
            this.dark_souls2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dark_souls2.TabIndex = 46;
            this.dark_souls2.TabStop = false;
            this.dark_souls2.Click += new System.EventHandler(this.dark_souls2_Click_1);
            // 
            // label_crearUser
            // 
            this.label_crearUser.AutoSize = true;
            this.label_crearUser.BackColor = System.Drawing.Color.NavajoWhite;
            this.label_crearUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_crearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_crearUser.Image = ((System.Drawing.Image)(resources.GetObject("label_crearUser.Image")));
            this.label_crearUser.Location = new System.Drawing.Point(286, 176);
            this.label_crearUser.Name = "label_crearUser";
            this.label_crearUser.Size = new System.Drawing.Size(280, 33);
            this.label_crearUser.TabIndex = 47;
            this.label_crearUser.Text = "Crear nuevo usuario";
            this.label_crearUser.Click += new System.EventHandler(this.label_crearUser_Click);
            // 
            // fallo_vacio
            // 
            this.fallo_vacio.AutoSize = true;
            this.fallo_vacio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fallo_vacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fallo_vacio.ForeColor = System.Drawing.Color.Red;
            this.fallo_vacio.Location = new System.Drawing.Point(266, 378);
            this.fallo_vacio.Name = "fallo_vacio";
            this.fallo_vacio.Size = new System.Drawing.Size(307, 24);
            this.fallo_vacio.TabIndex = 48;
            this.fallo_vacio.Text = "No puede haber campos vacíos";
            this.fallo_vacio.Visible = false;
            this.fallo_vacio.Click += new System.EventHandler(this.fallo_vacio_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.database1DataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BebidasTableAdapter = null;
            this.tableAdapterManager.ComidasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = taverna.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // usuariosBindingNavigator
            // 
            this.usuariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
            this.usuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuariosBindingNavigatorSaveItem});
            this.usuariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
            this.usuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuariosBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.usuariosBindingNavigator.TabIndex = 49;
            this.usuariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usuariosBindingNavigatorSaveItem
            // 
            this.usuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
            this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
            this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuariosBindingNavigatorSaveItem.Text = "Save Data";
            this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuariosBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn2.HeaderText = "password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user";
            this.dataGridViewTextBoxColumn1.HeaderText = "user";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Location = new System.Drawing.Point(270, 93);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.Size = new System.Drawing.Size(256, 57);
            this.usuariosDataGridView.TabIndex = 49;
            this.usuariosDataGridView.Visible = false;
            // 
            // label_exito
            // 
            this.label_exito.AutoSize = true;
            this.label_exito.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_exito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exito.ForeColor = System.Drawing.Color.Red;
            this.label_exito.Location = new System.Drawing.Point(336, 387);
            this.label_exito.Name = "label_exito";
            this.label_exito.Size = new System.Drawing.Size(152, 24);
            this.label_exito.TabIndex = 50;
            this.label_exito.Text = "Usuario creado";
            this.label_exito.Visible = false;
            this.label_exito.Click += new System.EventHandler(this.label_exito_Click);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 484);
            this.Controls.Add(this.label_exito);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.usuariosBindingNavigator);
            this.Controls.Add(this.meter_pass);
            this.Controls.Add(this.fallo_vacio);
            this.Controls.Add(this.label_crearUser);
            this.Controls.Add(this.antorchaI);
            this.Controls.Add(this.dark_souls2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label_creado);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.antorchaD);
            this.Controls.Add(this.boton_borrar);
            this.Controls.Add(this.boton_registro);
            this.Controls.Add(this.meter_usuario);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.cartelregistro);
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registro_FormClosed);
            this.Load += new System.EventHandler(this.registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartelregistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antorchaI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antorchaD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dark_souls2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
            this.usuariosBindingNavigator.ResumeLayout(false);
            this.usuariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cartelregistro;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox meter_usuario;
        private System.Windows.Forms.TextBox meter_pass;
        private System.Windows.Forms.Button boton_registro;
        private System.Windows.Forms.Button boton_borrar;
        private System.Windows.Forms.PictureBox antorchaI;
        private System.Windows.Forms.PictureBox antorchaD;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_creado;
        private System.Windows.Forms.PictureBox welcome;
        private System.Windows.Forms.PictureBox dark_souls2;
        private System.Windows.Forms.Label label_crearUser;
        private System.Windows.Forms.Label fallo_vacio;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Database1DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.Label label_exito;
    }
}
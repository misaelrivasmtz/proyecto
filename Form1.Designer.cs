namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mspTools = new System.Windows.Forms.MenuStrip();
            this.tspInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEventsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.tspCollectionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEjemplares = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosYReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspRedes = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teléfonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSelectEventImage = new System.Windows.Forms.OpenFileDialog();
            this.tpgEditEvent = new System.Windows.Forms.TabPage();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEventState = new System.Windows.Forms.Label();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.cmbEventArea = new System.Windows.Forms.ComboBox();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.lblEventArea = new System.Windows.Forms.Label();
            this.lblEventID = new System.Windows.Forms.Label();
            this.picEventImage = new System.Windows.Forms.PictureBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnSelectEventImage = new System.Windows.Forms.Button();
            this.dtpEventEnds = new System.Windows.Forms.DateTimePicker();
            this.lblEventAssistants = new System.Windows.Forms.Label();
            this.lblEventEnds = new System.Windows.Forms.Label();
            this.dtpEventStart = new System.Windows.Forms.DateTimePicker();
            this.numEventAssistants = new System.Windows.Forms.NumericUpDown();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.numEventID = new System.Windows.Forms.NumericUpDown();
            this.lblEventStart = new System.Windows.Forms.Label();
            this.tpgHome = new System.Windows.Forms.TabPage();
            this.tclTools = new System.Windows.Forms.TabControl();
            this.tpgEditCollections = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numCollectionID = new System.Windows.Forms.NumericUpDown();
            this.lblCollectionStatus = new System.Windows.Forms.Label();
            this.btnDeleteCollection = new System.Windows.Forms.Button();
            this.btnUpdateCollection = new System.Windows.Forms.Button();
            this.btnAddNewCollection = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblCollectionGender = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblCollectionID = new System.Windows.Forms.Label();
            this.lblCollectionName = new System.Windows.Forms.Label();
            this.lblCollectionType = new System.Windows.Forms.Label();
            this.txtCollectionName = new System.Windows.Forms.TextBox();
            this.tpgShowEvents = new System.Windows.Forms.TabPage();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.tpgCollections = new System.Windows.Forms.TabPage();
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.tpgEditUsers = new System.Windows.Forms.TabPage();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserInst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserDir = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.txtUserOccupation = new System.Windows.Forms.TextBox();
            this.numUserID = new System.Windows.Forms.NumericUpDown();
            this.tpgShowUsers = new System.Windows.Forms.TabPage();
            this.tpgEditEj = new System.Windows.Forms.TabPage();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnDeleteEj = new System.Windows.Forms.Button();
            this.btnNewEj = new System.Windows.Forms.Button();
            this.btnUpdateEj = new System.Windows.Forms.Button();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchLegend = new System.Windows.Forms.Label();
            this.rbFormat = new System.Windows.Forms.RadioButton();
            this.rbAutor = new System.Windows.Forms.RadioButton();
            this.rbPartialTitle = new System.Windows.Forms.RadioButton();
            this.rbWords = new System.Windows.Forms.RadioButton();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.dgvFiltered = new System.Windows.Forms.DataGridView();
            this.dtPub = new System.Windows.Forms.DateTimePicker();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.cmbCollection = new System.Windows.Forms.ComboBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.cmbEjTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtEjName = new System.Windows.Forms.TextBox();
            this.lblEjPub = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblEjID = new System.Windows.Forms.Label();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.lblEjName = new System.Windows.Forms.Label();
            this.btnSelectPort = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblEjCollection = new System.Windows.Forms.Label();
            this.numEjID = new System.Windows.Forms.NumericUpDown();
            this.lblEjEditorial = new System.Windows.Forms.Label();
            this.tpsShowEj = new System.Windows.Forms.TabPage();
            this.dgvEj = new System.Windows.Forms.DataGridView();
            this.tpgPrest = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tpgRes = new System.Windows.Forms.TabPage();
            this.ofdSelectUserImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdSelectBook = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgvPrestamoEjemplar = new System.Windows.Forms.DataGridView();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.databankPOObjDataSet = new Proyecto.databankPOObjDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Proyecto.databankPOObjDataSetTableAdapters.USUARIOTableAdapter();
            this.databankPOObjDataSet1 = new Proyecto.databankPOObjDataSet1();
            this.eJEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eJEMPLARTableAdapter = new Proyecto.databankPOObjDataSet1TableAdapters.EJEMPLARTableAdapter();
            this.databankPOObjDataSet2 = new Proyecto.databankPOObjDataSet2();
            this.rESERVAXEJEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESERVAXEJEMPLARTableAdapter = new Proyecto.databankPOObjDataSet2TableAdapters.RESERVAXEJEMPLARTableAdapter();
            this.ejemplarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEVOLUCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databankPOObjDataSet3 = new Proyecto.databankPOObjDataSet3();
            this.pRESTAMOXEJEMPLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRESTAMOXEJEMPLARTableAdapter = new Proyecto.databankPOObjDataSet3TableAdapters.PRESTAMOXEJEMPLARTableAdapter();
            this.ejemplarIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databankPOObjDataSet4 = new Proyecto.databankPOObjDataSet4();
            this.uSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter1 = new Proyecto.databankPOObjDataSet4TableAdapters.USUARIOTableAdapter();
            this.usuarioIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mostrarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mspTools.SuspendLayout();
            this.tpgEditEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEventAssistants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEventID)).BeginInit();
            this.tclTools.SuspendLayout();
            this.tpgEditCollections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectionID)).BeginInit();
            this.tpgShowEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.tpgCollections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            this.tpgEditUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserID)).BeginInit();
            this.tpgShowUsers.SuspendLayout();
            this.tpgEditEj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEjID)).BeginInit();
            this.tpsShowEj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEj)).BeginInit();
            this.tpgPrest.SuspendLayout();
            this.tpgRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoEjemplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJEMPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVAXEJEMPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESTAMOXEJEMPLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspTools
            // 
            this.mspTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspInicio,
            this.tspEventsButton,
            this.tspCollectionsMenu,
            this.tspEjemplares,
            this.tspUsers,
            this.préstamosYReservasToolStripMenuItem,
            this.tspRedes,
            this.tspSettings});
            this.mspTools.Location = new System.Drawing.Point(0, 0);
            this.mspTools.Name = "mspTools";
            this.mspTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mspTools.Size = new System.Drawing.Size(1120, 44);
            this.mspTools.TabIndex = 0;
            // 
            // tspInicio
            // 
            this.tspInicio.AutoSize = false;
            this.tspInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspInicio.Image = ((System.Drawing.Image)(resources.GetObject("tspInicio.Image")));
            this.tspInicio.Name = "tspInicio";
            this.tspInicio.Size = new System.Drawing.Size(110, 40);
            this.tspInicio.Text = "Inicio";
            this.tspInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tspEventsButton
            // 
            this.tspEventsButton.AutoSize = false;
            this.tspEventsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarEventosToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.tspEventsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspEventsButton.Image = ((System.Drawing.Image)(resources.GetObject("tspEventsButton.Image")));
            this.tspEventsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tspEventsButton.Name = "tspEventsButton";
            this.tspEventsButton.Size = new System.Drawing.Size(110, 40);
            this.tspEventsButton.Text = "Eventos";
            this.tspEventsButton.Click += new System.EventHandler(this.tspEventsButton_Click);
            // 
            // tspCollectionsMenu
            // 
            this.tspCollectionsMenu.AutoSize = false;
            this.tspCollectionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.editarToolStripMenuItem1});
            this.tspCollectionsMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspCollectionsMenu.Image = ((System.Drawing.Image)(resources.GetObject("tspCollectionsMenu.Image")));
            this.tspCollectionsMenu.Name = "tspCollectionsMenu";
            this.tspCollectionsMenu.Size = new System.Drawing.Size(110, 30);
            this.tspCollectionsMenu.Text = "Colecciones";
            this.tspCollectionsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tspEjemplares
            // 
            this.tspEjemplares.AutoSize = false;
            this.tspEjemplares.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1,
            this.editarToolStripMenuItem2});
            this.tspEjemplares.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspEjemplares.Image = ((System.Drawing.Image)(resources.GetObject("tspEjemplares.Image")));
            this.tspEjemplares.Name = "tspEjemplares";
            this.tspEjemplares.Size = new System.Drawing.Size(122, 30);
            this.tspEjemplares.Text = "Ejemplares";
            this.tspEjemplares.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tspUsers
            // 
            this.tspUsers.AutoSize = false;
            this.tspUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem2,
            this.editarToolStripMenuItem3});
            this.tspUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspUsers.Image = ((System.Drawing.Image)(resources.GetObject("tspUsers.Image")));
            this.tspUsers.Name = "tspUsers";
            this.tspUsers.Size = new System.Drawing.Size(122, 30);
            this.tspUsers.Text = "Usuarios";
            this.tspUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // préstamosYReservasToolStripMenuItem
            // 
            this.préstamosYReservasToolStripMenuItem.AutoSize = false;
            this.préstamosYReservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préstamosToolStripMenuItem,
            this.reservasToolStripMenuItem});
            this.préstamosYReservasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.préstamosYReservasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("préstamosYReservasToolStripMenuItem.Image")));
            this.préstamosYReservasToolStripMenuItem.Name = "préstamosYReservasToolStripMenuItem";
            this.préstamosYReservasToolStripMenuItem.Size = new System.Drawing.Size(122, 30);
            this.préstamosYReservasToolStripMenuItem.Text = "Acciones";
            this.préstamosYReservasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.préstamosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            this.préstamosToolStripMenuItem.Click += new System.EventHandler(this.préstamosToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reservasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click_1);
            // 
            // tspRedes
            // 
            this.tspRedes.AutoSize = false;
            this.tspRedes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.teléfonosToolStripMenuItem});
            this.tspRedes.Image = ((System.Drawing.Image)(resources.GetObject("tspRedes.Image")));
            this.tspRedes.Name = "tspRedes";
            this.tspRedes.Size = new System.Drawing.Size(122, 30);
            this.tspRedes.Text = "Contáctanos";
            this.tspRedes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tspRedes.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.AutoSize = false;
            this.twitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("twitterToolStripMenuItem.Image")));
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.AutoSize = false;
            this.facebookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facebookToolStripMenuItem.Image")));
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.facebookToolStripMenuItem.Text = "Facebook";
            // 
            // teléfonosToolStripMenuItem
            // 
            this.teléfonosToolStripMenuItem.AutoSize = false;
            this.teléfonosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("teléfonosToolStripMenuItem.Image")));
            this.teléfonosToolStripMenuItem.Name = "teléfonosToolStripMenuItem";
            this.teléfonosToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.teléfonosToolStripMenuItem.Text = "Teléfono";
            // 
            // tspSettings
            // 
            this.tspSettings.Image = ((System.Drawing.Image)(resources.GetObject("tspSettings.Image")));
            this.tspSettings.Name = "tspSettings";
            this.tspSettings.Size = new System.Drawing.Size(28, 40);
            this.tspSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ofdSelectEventImage
            // 
            this.ofdSelectEventImage.FileName = "ofdSelectEventImage";
            // 
            // tpgEditEvent
            // 
            this.tpgEditEvent.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgEditEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgEditEvent.BackgroundImage")));
            this.tpgEditEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgEditEvent.Controls.Add(this.txtEventName);
            this.tpgEditEvent.Controls.Add(this.label1);
            this.tpgEditEvent.Controls.Add(this.lblEventState);
            this.tpgEditEvent.Controls.Add(this.btnEliminarRegistro);
            this.tpgEditEvent.Controls.Add(this.btnEditEvent);
            this.tpgEditEvent.Controls.Add(this.cmbEventArea);
            this.tpgEditEvent.Controls.Add(this.btnAddNewEvent);
            this.tpgEditEvent.Controls.Add(this.lblEventArea);
            this.tpgEditEvent.Controls.Add(this.lblEventID);
            this.tpgEditEvent.Controls.Add(this.picEventImage);
            this.tpgEditEvent.Controls.Add(this.lblEventName);
            this.tpgEditEvent.Controls.Add(this.btnSelectEventImage);
            this.tpgEditEvent.Controls.Add(this.dtpEventEnds);
            this.tpgEditEvent.Controls.Add(this.lblEventAssistants);
            this.tpgEditEvent.Controls.Add(this.lblEventEnds);
            this.tpgEditEvent.Controls.Add(this.dtpEventStart);
            this.tpgEditEvent.Controls.Add(this.numEventAssistants);
            this.tpgEditEvent.Controls.Add(this.txtEventDescription);
            this.tpgEditEvent.Controls.Add(this.numEventID);
            this.tpgEditEvent.Controls.Add(this.lblEventStart);
            this.tpgEditEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpgEditEvent.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpgEditEvent.Location = new System.Drawing.Point(4, 22);
            this.tpgEditEvent.Name = "tpgEditEvent";
            this.tpgEditEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEditEvent.Size = new System.Drawing.Size(1112, 507);
            this.tpgEditEvent.TabIndex = 1;
            this.tpgEditEvent.Text = "editevent";
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.Color.White;
            this.txtEventName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventName.Location = new System.Drawing.Point(417, 164);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(306, 20);
            this.txtEventName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(206, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Objetivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEventState
            // 
            this.lblEventState.BackColor = System.Drawing.Color.Transparent;
            this.lblEventState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventState.ForeColor = System.Drawing.Color.Red;
            this.lblEventState.Location = new System.Drawing.Point(8, 468);
            this.lblEventState.Name = "lblEventState";
            this.lblEventState.Size = new System.Drawing.Size(186, 20);
            this.lblEventState.TabIndex = 27;
            this.lblEventState.Text = "Nombre:";
            this.lblEventState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(991, 461);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(100, 35);
            this.btnEliminarRegistro.TabIndex = 26;
            this.btnEliminarRegistro.Text = "Eliminar";
            this.btnEliminarRegistro.UseVisualStyleBackColor = true;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditEvent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditEvent.Location = new System.Drawing.Point(869, 461);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(100, 35);
            this.btnEditEvent.TabIndex = 25;
            this.btnEditEvent.Text = "Actualizar";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // cmbEventArea
            // 
            this.cmbEventArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventArea.FormattingEnabled = true;
            this.cmbEventArea.Location = new System.Drawing.Point(417, 337);
            this.cmbEventArea.Name = "cmbEventArea";
            this.cmbEventArea.Size = new System.Drawing.Size(306, 23);
            this.cmbEventArea.TabIndex = 24;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewEvent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewEvent.Location = new System.Drawing.Point(748, 461);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(100, 35);
            this.btnAddNewEvent.TabIndex = 23;
            this.btnAddNewEvent.Text = "Nuevo";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // lblEventArea
            // 
            this.lblEventArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventArea.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventArea.Location = new System.Drawing.Point(209, 336);
            this.lblEventArea.Name = "lblEventArea";
            this.lblEventArea.Size = new System.Drawing.Size(81, 20);
            this.lblEventArea.TabIndex = 22;
            this.lblEventArea.Text = "Área:";
            this.lblEventArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEventID
            // 
            this.lblEventID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventID.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventID.Location = new System.Drawing.Point(209, 132);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(68, 20);
            this.lblEventID.TabIndex = 18;
            this.lblEventID.Text = "ID:";
            this.lblEventID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picEventImage
            // 
            this.picEventImage.BackColor = System.Drawing.Color.Silver;
            this.picEventImage.Location = new System.Drawing.Point(903, 132);
            this.picEventImage.Name = "picEventImage";
            this.picEventImage.Size = new System.Drawing.Size(150, 187);
            this.picEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEventImage.TabIndex = 3;
            this.picEventImage.TabStop = false;
            // 
            // lblEventName
            // 
            this.lblEventName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventName.Location = new System.Drawing.Point(206, 164);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(81, 20);
            this.lblEventName.TabIndex = 17;
            this.lblEventName.Text = "Nombre:";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSelectEventImage
            // 
            this.btnSelectEventImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectEventImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectEventImage.Location = new System.Drawing.Point(903, 332);
            this.btnSelectEventImage.Name = "btnSelectEventImage";
            this.btnSelectEventImage.Size = new System.Drawing.Size(150, 30);
            this.btnSelectEventImage.TabIndex = 1;
            this.btnSelectEventImage.Text = "Seleccionar Imagen";
            this.btnSelectEventImage.UseVisualStyleBackColor = true;
            this.btnSelectEventImage.Click += new System.EventHandler(this.btnSelectEventImage_Click);
            // 
            // dtpEventEnds
            // 
            this.dtpEventEnds.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dtpEventEnds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpEventEnds.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpEventEnds.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventEnds.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventEnds.Location = new System.Drawing.Point(417, 267);
            this.dtpEventEnds.Name = "dtpEventEnds";
            this.dtpEventEnds.Size = new System.Drawing.Size(182, 20);
            this.dtpEventEnds.TabIndex = 16;
            // 
            // lblEventAssistants
            // 
            this.lblEventAssistants.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventAssistants.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventAssistants.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventAssistants.Location = new System.Drawing.Point(206, 299);
            this.lblEventAssistants.Name = "lblEventAssistants";
            this.lblEventAssistants.Size = new System.Drawing.Size(143, 20);
            this.lblEventAssistants.TabIndex = 14;
            this.lblEventAssistants.Text = "Asistentes:";
            this.lblEventAssistants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEventEnds
            // 
            this.lblEventEnds.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventEnds.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEnds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventEnds.Location = new System.Drawing.Point(206, 267);
            this.lblEventEnds.Name = "lblEventEnds";
            this.lblEventEnds.Size = new System.Drawing.Size(162, 20);
            this.lblEventEnds.TabIndex = 13;
            this.lblEventEnds.Text = "Finalización:";
            this.lblEventEnds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEventStart
            // 
            this.dtpEventStart.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEventStart.Location = new System.Drawing.Point(417, 230);
            this.dtpEventStart.Name = "dtpEventStart";
            this.dtpEventStart.Size = new System.Drawing.Size(182, 20);
            this.dtpEventStart.TabIndex = 6;
            // 
            // numEventAssistants
            // 
            this.numEventAssistants.Location = new System.Drawing.Point(417, 299);
            this.numEventAssistants.Name = "numEventAssistants";
            this.numEventAssistants.Size = new System.Drawing.Size(75, 20);
            this.numEventAssistants.TabIndex = 12;
            this.numEventAssistants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(417, 197);
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(306, 20);
            this.txtEventDescription.TabIndex = 6;
            // 
            // numEventID
            // 
            this.numEventID.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEventID.Location = new System.Drawing.Point(417, 132);
            this.numEventID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEventID.Name = "numEventID";
            this.numEventID.Size = new System.Drawing.Size(75, 20);
            this.numEventID.TabIndex = 6;
            this.numEventID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEventID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEventID.ValueChanged += new System.EventHandler(this.numEventID_ValueChanged);
            // 
            // lblEventStart
            // 
            this.lblEventStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEventStart.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEventStart.Location = new System.Drawing.Point(206, 231);
            this.lblEventStart.Name = "lblEventStart";
            this.lblEventStart.Size = new System.Drawing.Size(71, 20);
            this.lblEventStart.TabIndex = 11;
            this.lblEventStart.Text = "Inicio:";
            this.lblEventStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgHome
            // 
            this.tpgHome.Location = new System.Drawing.Point(4, 22);
            this.tpgHome.Name = "tpgHome";
            this.tpgHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpgHome.Size = new System.Drawing.Size(1112, 507);
            this.tpgHome.TabIndex = 0;
            this.tpgHome.Text = "Inicio";
            this.tpgHome.UseVisualStyleBackColor = true;
            // 
            // tclTools
            // 
            this.tclTools.Controls.Add(this.tpgEditEvent);
            this.tclTools.Controls.Add(this.tpgHome);
            this.tclTools.Controls.Add(this.tpgEditCollections);
            this.tclTools.Controls.Add(this.tpgShowEvents);
            this.tclTools.Controls.Add(this.tpgCollections);
            this.tclTools.Controls.Add(this.tpgEditUsers);
            this.tclTools.Controls.Add(this.tpgShowUsers);
            this.tclTools.Controls.Add(this.tpgEditEj);
            this.tclTools.Controls.Add(this.tpsShowEj);
            this.tclTools.Controls.Add(this.tpgPrest);
            this.tclTools.Controls.Add(this.tpgRes);
            this.tclTools.Location = new System.Drawing.Point(0, 47);
            this.tclTools.Name = "tclTools";
            this.tclTools.SelectedIndex = 0;
            this.tclTools.Size = new System.Drawing.Size(1120, 533);
            this.tclTools.TabIndex = 5;
            // 
            // tpgEditCollections
            // 
            this.tpgEditCollections.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgEditCollections.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgEditCollections.BackgroundImage")));
            this.tpgEditCollections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgEditCollections.Controls.Add(this.label2);
            this.tpgEditCollections.Controls.Add(this.pictureBox2);
            this.tpgEditCollections.Controls.Add(this.numCollectionID);
            this.tpgEditCollections.Controls.Add(this.lblCollectionStatus);
            this.tpgEditCollections.Controls.Add(this.btnDeleteCollection);
            this.tpgEditCollections.Controls.Add(this.btnUpdateCollection);
            this.tpgEditCollections.Controls.Add(this.btnAddNewCollection);
            this.tpgEditCollections.Controls.Add(this.cmbGender);
            this.tpgEditCollections.Controls.Add(this.lblCollectionGender);
            this.tpgEditCollections.Controls.Add(this.cmbTypes);
            this.tpgEditCollections.Controls.Add(this.lblCollectionID);
            this.tpgEditCollections.Controls.Add(this.lblCollectionName);
            this.tpgEditCollections.Controls.Add(this.lblCollectionType);
            this.tpgEditCollections.Controls.Add(this.txtCollectionName);
            this.tpgEditCollections.Location = new System.Drawing.Point(4, 22);
            this.tpgEditCollections.Name = "tpgEditCollections";
            this.tpgEditCollections.Size = new System.Drawing.Size(1112, 507);
            this.tpgEditCollections.TabIndex = 2;
            this.tpgEditCollections.Text = "tabPage1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(699, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 93);
            this.label2.TabIndex = 73;
            this.label2.Text = "Una colección es un conjunto de libros, publicados por una editorial, reunidos ba" +
    "jo un mismo epígrafe, generalmente utilizando distintivos, formatos y caracterís" +
    "ticas comunes\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(926, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // numCollectionID
            // 
            this.numCollectionID.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCollectionID.Location = new System.Drawing.Point(225, 133);
            this.numCollectionID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCollectionID.Name = "numCollectionID";
            this.numCollectionID.Size = new System.Drawing.Size(75, 20);
            this.numCollectionID.TabIndex = 72;
            this.numCollectionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCollectionID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCollectionStatus
            // 
            this.lblCollectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCollectionStatus.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblCollectionStatus.Location = new System.Drawing.Point(5, 479);
            this.lblCollectionStatus.Name = "lblCollectionStatus";
            this.lblCollectionStatus.Size = new System.Drawing.Size(295, 20);
            this.lblCollectionStatus.TabIndex = 52;
            this.lblCollectionStatus.Text = "Nombre:";
            this.lblCollectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteCollection
            // 
            this.btnDeleteCollection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteCollection.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCollection.Location = new System.Drawing.Point(738, 452);
            this.btnDeleteCollection.Name = "btnDeleteCollection";
            this.btnDeleteCollection.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteCollection.TabIndex = 51;
            this.btnDeleteCollection.Text = "Eliminar";
            this.btnDeleteCollection.UseVisualStyleBackColor = true;
            this.btnDeleteCollection.Click += new System.EventHandler(this.btnDeleteCollection_Click);
            // 
            // btnUpdateCollection
            // 
            this.btnUpdateCollection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateCollection.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateCollection.Location = new System.Drawing.Point(863, 452);
            this.btnUpdateCollection.Name = "btnUpdateCollection";
            this.btnUpdateCollection.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateCollection.TabIndex = 50;
            this.btnUpdateCollection.Text = "Actualizar";
            this.btnUpdateCollection.UseVisualStyleBackColor = true;
            this.btnUpdateCollection.Click += new System.EventHandler(this.btnUpdateCollection_Click);
            // 
            // btnAddNewCollection
            // 
            this.btnAddNewCollection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewCollection.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewCollection.Location = new System.Drawing.Point(986, 452);
            this.btnAddNewCollection.Name = "btnAddNewCollection";
            this.btnAddNewCollection.Size = new System.Drawing.Size(100, 35);
            this.btnAddNewCollection.TabIndex = 49;
            this.btnAddNewCollection.Text = "Nuevo";
            this.btnAddNewCollection.UseVisualStyleBackColor = true;
            this.btnAddNewCollection.Click += new System.EventHandler(this.btnAddNewCollection_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(225, 344);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(310, 21);
            this.cmbGender.TabIndex = 48;
            // 
            // lblCollectionGender
            // 
            this.lblCollectionGender.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionGender.Location = new System.Drawing.Point(222, 315);
            this.lblCollectionGender.Name = "lblCollectionGender";
            this.lblCollectionGender.Size = new System.Drawing.Size(81, 16);
            this.lblCollectionGender.TabIndex = 47;
            this.lblCollectionGender.Text = "Género:";
            this.lblCollectionGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(225, 274);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(310, 21);
            this.cmbTypes.TabIndex = 44;
            // 
            // lblCollectionID
            // 
            this.lblCollectionID.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionID.Location = new System.Drawing.Point(222, 100);
            this.lblCollectionID.Name = "lblCollectionID";
            this.lblCollectionID.Size = new System.Drawing.Size(52, 20);
            this.lblCollectionID.TabIndex = 41;
            this.lblCollectionID.Text = "ID:";
            this.lblCollectionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.BackColor = System.Drawing.Color.Transparent;
            this.lblCollectionName.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionName.Location = new System.Drawing.Point(219, 171);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(81, 16);
            this.lblCollectionName.TabIndex = 40;
            this.lblCollectionName.Text = "Nombre:";
            this.lblCollectionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCollectionType
            // 
            this.lblCollectionType.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionType.Location = new System.Drawing.Point(222, 245);
            this.lblCollectionType.Name = "lblCollectionType";
            this.lblCollectionType.Size = new System.Drawing.Size(81, 16);
            this.lblCollectionType.TabIndex = 38;
            this.lblCollectionType.Text = "Tipo:";
            this.lblCollectionType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCollectionName
            // 
            this.txtCollectionName.Location = new System.Drawing.Point(225, 200);
            this.txtCollectionName.Name = "txtCollectionName";
            this.txtCollectionName.Size = new System.Drawing.Size(310, 20);
            this.txtCollectionName.TabIndex = 30;
            // 
            // tpgShowEvents
            // 
            this.tpgShowEvents.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgShowEvents.Controls.Add(this.dgvEvents);
            this.tpgShowEvents.Location = new System.Drawing.Point(4, 22);
            this.tpgShowEvents.Name = "tpgShowEvents";
            this.tpgShowEvents.Size = new System.Drawing.Size(1112, 507);
            this.tpgShowEvents.TabIndex = 3;
            this.tpgShowEvents.Text = "ShowEvents";
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(-4, 0);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.Size = new System.Drawing.Size(1120, 507);
            this.dgvEvents.TabIndex = 0;
            // 
            // tpgCollections
            // 
            this.tpgCollections.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgCollections.Controls.Add(this.dgvCollections);
            this.tpgCollections.Location = new System.Drawing.Point(4, 22);
            this.tpgCollections.Name = "tpgCollections";
            this.tpgCollections.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCollections.Size = new System.Drawing.Size(1112, 507);
            this.tpgCollections.TabIndex = 4;
            this.tpgCollections.Text = "showCollections";
            // 
            // dgvCollections
            // 
            this.dgvCollections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCollections.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvCollections.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(-4, 0);
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.Size = new System.Drawing.Size(1120, 511);
            this.dgvCollections.TabIndex = 1;
            // 
            // tpgEditUsers
            // 
            this.tpgEditUsers.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgEditUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgEditUsers.BackgroundImage")));
            this.tpgEditUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgEditUsers.Controls.Add(this.txtUserMail);
            this.tpgEditUsers.Controls.Add(this.label12);
            this.tpgEditUsers.Controls.Add(this.txtUserPhone);
            this.tpgEditUsers.Controls.Add(this.label9);
            this.tpgEditUsers.Controls.Add(this.label8);
            this.tpgEditUsers.Controls.Add(this.txtUserInst);
            this.tpgEditUsers.Controls.Add(this.label5);
            this.tpgEditUsers.Controls.Add(this.txtUserDir);
            this.tpgEditUsers.Controls.Add(this.txtUserName);
            this.tpgEditUsers.Controls.Add(this.label3);
            this.tpgEditUsers.Controls.Add(this.lblUserStatus);
            this.tpgEditUsers.Controls.Add(this.btnDeleteUser);
            this.tpgEditUsers.Controls.Add(this.btnUpdateUser);
            this.tpgEditUsers.Controls.Add(this.btnAddUser);
            this.tpgEditUsers.Controls.Add(this.label6);
            this.tpgEditUsers.Controls.Add(this.picUser);
            this.tpgEditUsers.Controls.Add(this.label7);
            this.tpgEditUsers.Controls.Add(this.btnSelectUser);
            this.tpgEditUsers.Controls.Add(this.txtUserOccupation);
            this.tpgEditUsers.Controls.Add(this.numUserID);
            this.tpgEditUsers.Location = new System.Drawing.Point(4, 22);
            this.tpgEditUsers.Name = "tpgEditUsers";
            this.tpgEditUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEditUsers.Size = new System.Drawing.Size(1112, 507);
            this.tpgEditUsers.TabIndex = 5;
            this.tpgEditUsers.Text = "editUsers";
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(345, 361);
            this.txtUserMail.MaxLength = 50;
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(267, 20);
            this.txtUserMail.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(229, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Correo:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(345, 323);
            this.txtUserPhone.MaxLength = 8;
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(267, 20);
            this.txtUserPhone.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(228, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Teléfono:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(229, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "Institución:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserInst
            // 
            this.txtUserInst.Location = new System.Drawing.Point(345, 285);
            this.txtUserInst.MaxLength = 50;
            this.txtUserInst.Name = "txtUserInst";
            this.txtUserInst.Size = new System.Drawing.Size(267, 20);
            this.txtUserInst.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(229, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Dirección:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserDir
            // 
            this.txtUserDir.Location = new System.Drawing.Point(345, 247);
            this.txtUserDir.MaxLength = 50;
            this.txtUserDir.Name = "txtUserDir";
            this.txtUserDir.Size = new System.Drawing.Size(267, 20);
            this.txtUserDir.TabIndex = 51;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(345, 172);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(267, 20);
            this.txtUserName.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(229, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ocupación:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUserStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.Red;
            this.lblUserStatus.Location = new System.Drawing.Point(38, 469);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(186, 20);
            this.lblUserStatus.TabIndex = 47;
            this.lblUserStatus.Text = "Nombre:";
            this.lblUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteUser.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteUser.Location = new System.Drawing.Point(764, 461);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteUser.TabIndex = 46;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateUser.Location = new System.Drawing.Point(882, 461);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateUser.TabIndex = 45;
            this.btnUpdateUser.Text = "Actualizar";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(1004, 462);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 35);
            this.btnAddUser.TabIndex = 43;
            this.btnAddUser.Text = "Nuevo";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(229, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "ID:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Silver;
            this.picUser.Location = new System.Drawing.Point(882, 172);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(135, 155);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 31;
            this.picUser.TabStop = false;
            // 
            // label7
            // 
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(229, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectUser.Location = new System.Drawing.Point(882, 333);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(135, 35);
            this.btnSelectUser.TabIndex = 30;
            this.btnSelectUser.Text = "Seleccionar Imagen";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            // 
            // txtUserOccupation
            // 
            this.txtUserOccupation.Location = new System.Drawing.Point(345, 213);
            this.txtUserOccupation.MaxLength = 50;
            this.txtUserOccupation.Name = "txtUserOccupation";
            this.txtUserOccupation.Size = new System.Drawing.Size(267, 20);
            this.txtUserOccupation.TabIndex = 32;
            // 
            // numUserID
            // 
            this.numUserID.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUserID.Location = new System.Drawing.Point(345, 135);
            this.numUserID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUserID.Name = "numUserID";
            this.numUserID.Size = new System.Drawing.Size(75, 20);
            this.numUserID.TabIndex = 34;
            this.numUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUserID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tpgShowUsers
            // 
            this.tpgShowUsers.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgShowUsers.Controls.Add(this.dgvAllUsers);
            this.tpgShowUsers.Location = new System.Drawing.Point(4, 22);
            this.tpgShowUsers.Name = "tpgShowUsers";
            this.tpgShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgShowUsers.Size = new System.Drawing.Size(1112, 507);
            this.tpgShowUsers.TabIndex = 6;
            this.tpgShowUsers.Text = "tpgShowUsers";
            // 
            // tpgEditEj
            // 
            this.tpgEditEj.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgEditEj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpgEditEj.BackgroundImage")));
            this.tpgEditEj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tpgEditEj.Controls.Add(this.lblAutor);
            this.tpgEditEj.Controls.Add(this.txtAutor);
            this.tpgEditEj.Controls.Add(this.btnDeleteEj);
            this.tpgEditEj.Controls.Add(this.btnNewEj);
            this.tpgEditEj.Controls.Add(this.btnUpdateEj);
            this.tpgEditEj.Controls.Add(this.cmbTag);
            this.tpgEditEj.Controls.Add(this.btnBuscar);
            this.tpgEditEj.Controls.Add(this.txtSearch);
            this.tpgEditEj.Controls.Add(this.lblSearchLegend);
            this.tpgEditEj.Controls.Add(this.rbFormat);
            this.tpgEditEj.Controls.Add(this.rbAutor);
            this.tpgEditEj.Controls.Add(this.rbPartialTitle);
            this.tpgEditEj.Controls.Add(this.rbWords);
            this.tpgEditEj.Controls.Add(this.rbTitle);
            this.tpgEditEj.Controls.Add(this.dgvFiltered);
            this.tpgEditEj.Controls.Add(this.dtPub);
            this.tpgEditEj.Controls.Add(this.cmbEditorial);
            this.tpgEditEj.Controls.Add(this.cmbCollection);
            this.tpgEditEj.Controls.Add(this.cmbFormat);
            this.tpgEditEj.Controls.Add(this.cmbEjTag);
            this.tpgEditEj.Controls.Add(this.lblTag);
            this.tpgEditEj.Controls.Add(this.txtEjName);
            this.tpgEditEj.Controls.Add(this.lblEjPub);
            this.tpgEditEj.Controls.Add(this.cmbLanguage);
            this.tpgEditEj.Controls.Add(this.lblLanguage);
            this.tpgEditEj.Controls.Add(this.lblEjID);
            this.tpgEditEj.Controls.Add(this.picBook);
            this.tpgEditEj.Controls.Add(this.lblEjName);
            this.tpgEditEj.Controls.Add(this.btnSelectPort);
            this.tpgEditEj.Controls.Add(this.lblFormat);
            this.tpgEditEj.Controls.Add(this.lblEjCollection);
            this.tpgEditEj.Controls.Add(this.numEjID);
            this.tpgEditEj.Controls.Add(this.lblEjEditorial);
            this.tpgEditEj.Location = new System.Drawing.Point(4, 22);
            this.tpgEditEj.Name = "tpgEditEj";
            this.tpgEditEj.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEditEj.Size = new System.Drawing.Size(1112, 507);
            this.tpgEditEj.TabIndex = 7;
            this.tpgEditEj.Text = "edit/filt";
            // 
            // lblAutor
            // 
            this.lblAutor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAutor.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAutor.Location = new System.Drawing.Point(11, 208);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(162, 20);
            this.lblAutor.TabIndex = 77;
            this.lblAutor.Text = "Autor:";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.Color.White;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Location = new System.Drawing.Point(222, 208);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(306, 20);
            this.txtAutor.TabIndex = 76;
            // 
            // btnDeleteEj
            // 
            this.btnDeleteEj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEj.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteEj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteEj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteEj.Location = new System.Drawing.Point(586, 153);
            this.btnDeleteEj.Name = "btnDeleteEj";
            this.btnDeleteEj.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteEj.TabIndex = 75;
            this.btnDeleteEj.Text = "Eliminar";
            this.btnDeleteEj.UseVisualStyleBackColor = false;
            this.btnDeleteEj.Click += new System.EventHandler(this.btnDeleteEj_Click);
            // 
            // btnNewEj
            // 
            this.btnNewEj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewEj.BackColor = System.Drawing.Color.LightGray;
            this.btnNewEj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewEj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewEj.Location = new System.Drawing.Point(834, 153);
            this.btnNewEj.Name = "btnNewEj";
            this.btnNewEj.Size = new System.Drawing.Size(100, 35);
            this.btnNewEj.TabIndex = 74;
            this.btnNewEj.Text = "Nuevo";
            this.btnNewEj.UseVisualStyleBackColor = false;
            this.btnNewEj.Click += new System.EventHandler(this.btnNewEj_Click);
            // 
            // btnUpdateEj
            // 
            this.btnUpdateEj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateEj.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateEj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateEj.Location = new System.Drawing.Point(713, 153);
            this.btnUpdateEj.Name = "btnUpdateEj";
            this.btnUpdateEj.Size = new System.Drawing.Size(100, 35);
            this.btnUpdateEj.TabIndex = 73;
            this.btnUpdateEj.Text = "Actualizar";
            this.btnUpdateEj.UseVisualStyleBackColor = true;
            this.btnUpdateEj.Click += new System.EventHandler(this.btnUpdateEj_Click);
            // 
            // cmbTag
            // 
            this.cmbTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(685, 314);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(202, 21);
            this.cmbTag.TabIndex = 72;
            this.cmbTag.ValueMember = "ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscar.Location = new System.Drawing.Point(984, 315);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 20);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Aplicar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(598, 315);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(380, 20);
            this.txtSearch.TabIndex = 70;
            // 
            // lblSearchLegend
            // 
            this.lblSearchLegend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSearchLegend.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLegend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearchLegend.Location = new System.Drawing.Point(13, 315);
            this.lblSearchLegend.Name = "lblSearchLegend";
            this.lblSearchLegend.Size = new System.Drawing.Size(100, 20);
            this.lblSearchLegend.TabIndex = 69;
            this.lblSearchLegend.Text = "Buscar por:";
            this.lblSearchLegend.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // rbFormat
            // 
            this.rbFormat.AutoSize = true;
            this.rbFormat.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFormat.Location = new System.Drawing.Point(503, 314);
            this.rbFormat.Name = "rbFormat";
            this.rbFormat.Size = new System.Drawing.Size(67, 19);
            this.rbFormat.TabIndex = 68;
            this.rbFormat.TabStop = true;
            this.rbFormat.Text = "Formato";
            this.rbFormat.UseVisualStyleBackColor = true;
            // 
            // rbAutor
            // 
            this.rbAutor.AutoSize = true;
            this.rbAutor.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutor.Location = new System.Drawing.Point(442, 314);
            this.rbAutor.Name = "rbAutor";
            this.rbAutor.Size = new System.Drawing.Size(55, 19);
            this.rbAutor.TabIndex = 67;
            this.rbAutor.TabStop = true;
            this.rbAutor.Text = "Autor";
            this.rbAutor.UseVisualStyleBackColor = true;
            // 
            // rbPartialTitle
            // 
            this.rbPartialTitle.AutoSize = true;
            this.rbPartialTitle.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPartialTitle.Location = new System.Drawing.Point(212, 314);
            this.rbPartialTitle.Name = "rbPartialTitle";
            this.rbPartialTitle.Size = new System.Drawing.Size(109, 19);
            this.rbPartialTitle.TabIndex = 66;
            this.rbPartialTitle.TabStop = true;
            this.rbPartialTitle.Text = "Título Parcial";
            this.rbPartialTitle.UseVisualStyleBackColor = true;
            // 
            // rbWords
            // 
            this.rbWords.AutoSize = true;
            this.rbWords.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWords.Location = new System.Drawing.Point(327, 314);
            this.rbWords.Name = "rbWords";
            this.rbWords.Size = new System.Drawing.Size(109, 19);
            this.rbWords.TabIndex = 65;
            this.rbWords.TabStop = true;
            this.rbWords.Text = "Palabras clave";
            this.rbWords.UseVisualStyleBackColor = true;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitle.Location = new System.Drawing.Point(139, 314);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(67, 19);
            this.rbTitle.TabIndex = 64;
            this.rbTitle.TabStop = true;
            this.rbTitle.Text = "Título ";
            this.rbTitle.UseVisualStyleBackColor = true;
            // 
            // dgvFiltered
            // 
            this.dgvFiltered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltered.Location = new System.Drawing.Point(8, 345);
            this.dgvFiltered.Name = "dgvFiltered";
            this.dgvFiltered.Size = new System.Drawing.Size(1096, 159);
            this.dgvFiltered.TabIndex = 63;
            // 
            // dtPub
            // 
            this.dtPub.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dtPub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPub.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPub.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPub.Location = new System.Drawing.Point(222, 101);
            this.dtPub.Name = "dtPub";
            this.dtPub.Size = new System.Drawing.Size(306, 20);
            this.dtPub.TabIndex = 51;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(222, 138);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(306, 21);
            this.cmbEditorial.TabIndex = 50;
            this.cmbEditorial.ValueMember = "ID";
            // 
            // cmbCollection
            // 
            this.cmbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCollection.FormattingEnabled = true;
            this.cmbCollection.Location = new System.Drawing.Point(222, 172);
            this.cmbCollection.Name = "cmbCollection";
            this.cmbCollection.Size = new System.Drawing.Size(306, 21);
            this.cmbCollection.TabIndex = 49;
            this.cmbCollection.ValueMember = "ColeccionID";
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(732, 41);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(202, 21);
            this.cmbFormat.TabIndex = 48;
            this.cmbFormat.ValueMember = "ID";
            // 
            // cmbEjTag
            // 
            this.cmbEjTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEjTag.FormattingEnabled = true;
            this.cmbEjTag.Location = new System.Drawing.Point(732, 111);
            this.cmbEjTag.Name = "cmbEjTag";
            this.cmbEjTag.Size = new System.Drawing.Size(202, 21);
            this.cmbEjTag.TabIndex = 47;
            this.cmbEjTag.ValueMember = "ID";
            // 
            // lblTag
            // 
            this.lblTag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTag.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTag.Location = new System.Drawing.Point(586, 113);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(81, 20);
            this.lblTag.TabIndex = 46;
            this.lblTag.Text = "Etiqueta:";
            this.lblTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEjName
            // 
            this.txtEjName.BackColor = System.Drawing.Color.White;
            this.txtEjName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEjName.Location = new System.Drawing.Point(222, 69);
            this.txtEjName.Name = "txtEjName";
            this.txtEjName.Size = new System.Drawing.Size(306, 20);
            this.txtEjName.TabIndex = 45;
            // 
            // lblEjPub
            // 
            this.lblEjPub.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEjPub.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjPub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjPub.Location = new System.Drawing.Point(11, 101);
            this.lblEjPub.Name = "lblEjPub";
            this.lblEjPub.Size = new System.Drawing.Size(101, 20);
            this.lblEjPub.TabIndex = 44;
            this.lblEjPub.Text = "Publicación:";
            this.lblEjPub.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(732, 75);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(202, 21);
            this.cmbLanguage.TabIndex = 43;
            this.cmbLanguage.ValueMember = "ID";
            // 
            // lblLanguage
            // 
            this.lblLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLanguage.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLanguage.Location = new System.Drawing.Point(586, 79);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(81, 20);
            this.lblLanguage.TabIndex = 42;
            this.lblLanguage.Text = "Idioma:";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEjID
            // 
            this.lblEjID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEjID.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjID.Location = new System.Drawing.Point(14, 37);
            this.lblEjID.Name = "lblEjID";
            this.lblEjID.Size = new System.Drawing.Size(68, 20);
            this.lblEjID.TabIndex = 41;
            this.lblEjID.Text = "ID:";
            this.lblEjID.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picBook
            // 
            this.picBook.BackColor = System.Drawing.Color.Silver;
            this.picBook.Location = new System.Drawing.Point(984, 32);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(100, 120);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBook.TabIndex = 31;
            this.picBook.TabStop = false;
            // 
            // lblEjName
            // 
            this.lblEjName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEjName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjName.Location = new System.Drawing.Point(11, 69);
            this.lblEjName.Name = "lblEjName";
            this.lblEjName.Size = new System.Drawing.Size(81, 20);
            this.lblEjName.TabIndex = 40;
            this.lblEjName.Text = "Nombre:";
            this.lblEjName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSelectPort
            // 
            this.btnSelectPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectPort.Location = new System.Drawing.Point(984, 158);
            this.btnSelectPort.Name = "btnSelectPort";
            this.btnSelectPort.Size = new System.Drawing.Size(100, 30);
            this.btnSelectPort.TabIndex = 30;
            this.btnSelectPort.Text = "Seleccionar Imagen";
            this.btnSelectPort.UseVisualStyleBackColor = true;
            this.btnSelectPort.Click += new System.EventHandler(this.btnSelectPort_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFormat.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFormat.Location = new System.Drawing.Point(583, 42);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(143, 20);
            this.lblFormat.TabIndex = 38;
            this.lblFormat.Text = "Formato:";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEjCollection
            // 
            this.lblEjCollection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEjCollection.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjCollection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjCollection.Location = new System.Drawing.Point(11, 172);
            this.lblEjCollection.Name = "lblEjCollection";
            this.lblEjCollection.Size = new System.Drawing.Size(162, 20);
            this.lblEjCollection.TabIndex = 37;
            this.lblEjCollection.Text = "Colección:";
            this.lblEjCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEjID
            // 
            this.numEjID.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEjID.Location = new System.Drawing.Point(222, 37);
            this.numEjID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEjID.Name = "numEjID";
            this.numEjID.Size = new System.Drawing.Size(75, 20);
            this.numEjID.TabIndex = 34;
            this.numEjID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEjID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEjID.ValueChanged += new System.EventHandler(this.numEjID_ValueChanged);
            // 
            // lblEjEditorial
            // 
            this.lblEjEditorial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEjEditorial.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjEditorial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEjEditorial.Location = new System.Drawing.Point(11, 136);
            this.lblEjEditorial.Name = "lblEjEditorial";
            this.lblEjEditorial.Size = new System.Drawing.Size(84, 20);
            this.lblEjEditorial.TabIndex = 35;
            this.lblEjEditorial.Text = "Editorial:";
            this.lblEjEditorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpsShowEj
            // 
            this.tpsShowEj.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpsShowEj.Controls.Add(this.dgvEj);
            this.tpsShowEj.Location = new System.Drawing.Point(4, 22);
            this.tpsShowEj.Name = "tpsShowEj";
            this.tpsShowEj.Size = new System.Drawing.Size(1112, 507);
            this.tpsShowEj.TabIndex = 8;
            this.tpsShowEj.Text = "showEj";
            // 
            // dgvEj
            // 
            this.dgvEj.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvEj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEj.Location = new System.Drawing.Point(-4, 3);
            this.dgvEj.Name = "dgvEj";
            this.dgvEj.Size = new System.Drawing.Size(1120, 501);
            this.dgvEj.TabIndex = 28;
            // 
            // tpgPrest
            // 
            this.tpgPrest.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgPrest.Controls.Add(this.button5);
            this.tpgPrest.Controls.Add(this.button6);
            this.tpgPrest.Controls.Add(this.button7);
            this.tpgPrest.Controls.Add(this.dgvPrestamoEjemplar);
            this.tpgPrest.Controls.Add(this.comboBox2);
            this.tpgPrest.Controls.Add(this.comboBox1);
            this.tpgPrest.Controls.Add(this.label4);
            this.tpgPrest.Controls.Add(this.label10);
            this.tpgPrest.Controls.Add(this.dateTimePicker1);
            this.tpgPrest.Controls.Add(this.label11);
            this.tpgPrest.Controls.Add(this.dateTimePicker2);
            this.tpgPrest.Controls.Add(this.label13);
            this.tpgPrest.Location = new System.Drawing.Point(4, 22);
            this.tpgPrest.Name = "tpgPrest";
            this.tpgPrest.Size = new System.Drawing.Size(1112, 507);
            this.tpgPrest.TabIndex = 9;
            this.tpgPrest.Text = "prest";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(28, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ejemplar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(28, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Usuario:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(28, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Finalización:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(28, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Inicio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tpgRes
            // 
            this.tpgRes.BackColor = System.Drawing.Color.RoyalBlue;
            this.tpgRes.Controls.Add(this.dgvReservas);
            this.tpgRes.Controls.Add(this.button8);
            this.tpgRes.Controls.Add(this.button9);
            this.tpgRes.Controls.Add(this.button10);
            this.tpgRes.Controls.Add(this.comboBox3);
            this.tpgRes.Controls.Add(this.comboBox4);
            this.tpgRes.Controls.Add(this.label14);
            this.tpgRes.Controls.Add(this.label15);
            this.tpgRes.Controls.Add(this.dateTimePicker3);
            this.tpgRes.Controls.Add(this.label16);
            this.tpgRes.Controls.Add(this.dateTimePicker4);
            this.tpgRes.Controls.Add(this.label17);
            this.tpgRes.Location = new System.Drawing.Point(4, 22);
            this.tpgRes.Name = "tpgRes";
            this.tpgRes.Size = new System.Drawing.Size(1112, 507);
            this.tpgRes.TabIndex = 10;
            this.tpgRes.Text = "res";
            // 
            // ofdSelectUserImage
            // 
            this.ofdSelectUserImage.FileName = "ofdSelectUserImage";
            // 
            // ofdSelectBook
            // 
            this.ofdSelectBook.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.eJEMPLARBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.uSUARIOBindingSource;
            this.comboBox2.DisplayMember = "Nombre";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(310, 21);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "UsuarioID";
            // 
            // dgvPrestamoEjemplar
            // 
            this.dgvPrestamoEjemplar.AllowUserToAddRows = false;
            this.dgvPrestamoEjemplar.AllowUserToDeleteRows = false;
            this.dgvPrestamoEjemplar.AutoGenerateColumns = false;
            this.dgvPrestamoEjemplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamoEjemplar.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvPrestamoEjemplar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPrestamoEjemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamoEjemplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejemplarIDDataGridViewTextBoxColumn1,
            this.usuarioIDDataGridViewTextBoxColumn1,
            this.prestamoDataGridViewTextBoxColumn,
            this.devolucionDataGridViewTextBoxColumn1});
            this.dgvPrestamoEjemplar.DataSource = this.pRESTAMOXEJEMPLARBindingSource;
            this.dgvPrestamoEjemplar.Location = new System.Drawing.Point(-4, 232);
            this.dgvPrestamoEjemplar.Name = "dgvPrestamoEjemplar";
            this.dgvPrestamoEjemplar.ReadOnly = true;
            this.dgvPrestamoEjemplar.Size = new System.Drawing.Size(1120, 272);
            this.dgvPrestamoEjemplar.TabIndex = 47;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AutoGenerateColumns = false;
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioIDDataGridViewTextBoxColumn2,
            this.nombreDataGridViewTextBoxColumn,
            this.ocupacionDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.institucionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fotografiaDataGridViewImageColumn,
            this.correoDataGridViewTextBoxColumn});
            this.dgvAllUsers.DataSource = this.uSUARIOBindingSource1;
            this.dgvAllUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.Size = new System.Drawing.Size(1120, 507);
            this.dgvAllUsers.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(18, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.TabIndex = 78;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(266, 174);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.TabIndex = 77;
            this.button6.Text = "Nuevo";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(145, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.TabIndex = 76;
            this.button7.Text = "Actualizar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.LightGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(19, 173);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 35);
            this.button8.TabIndex = 89;
            this.button8.Text = "Eliminar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.LightGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(267, 173);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 35);
            this.button9.TabIndex = 88;
            this.button9.Text = "Nuevo";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(146, 173);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 35);
            this.button10.TabIndex = 87;
            this.button10.Text = "Actualizar";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.uSUARIOBindingSource;
            this.comboBox3.DisplayMember = "Nombre";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(240, 30);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(310, 21);
            this.comboBox3.TabIndex = 86;
            this.comboBox3.ValueMember = "UsuarioID";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.eJEMPLARBindingSource;
            this.comboBox4.DisplayMember = "Nombre";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(240, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(310, 21);
            this.comboBox4.TabIndex = 85;
            this.comboBox4.ValueMember = "ID";
            // 
            // label14
            // 
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(29, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 20);
            this.label14.TabIndex = 84;
            this.label14.Text = "Ejemplar";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label15
            // 
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(29, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 83;
            this.label15.Text = "Usuario:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker3.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker3.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(240, 134);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker3.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(29, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 20);
            this.label16.TabIndex = 81;
            this.label16.Text = "Finalización:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(240, 97);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker4.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(29, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 80;
            this.label17.Text = "Inicio:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ejemplarIDDataGridViewTextBoxColumn,
            this.usuarioIDDataGridViewTextBoxColumn,
            this.rESERVADataGridViewTextBoxColumn,
            this.dEVOLUCIONDataGridViewTextBoxColumn});
            this.dgvReservas.DataSource = this.rESERVAXEJEMPLARBindingSource;
            this.dgvReservas.Location = new System.Drawing.Point(-4, 239);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(1120, 272);
            this.dgvReservas.TabIndex = 90;
            // 
            // databankPOObjDataSet
            // 
            this.databankPOObjDataSet.DataSetName = "databankPOObjDataSet";
            this.databankPOObjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.databankPOObjDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // databankPOObjDataSet1
            // 
            this.databankPOObjDataSet1.DataSetName = "databankPOObjDataSet1";
            this.databankPOObjDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eJEMPLARBindingSource
            // 
            this.eJEMPLARBindingSource.DataMember = "EJEMPLAR";
            this.eJEMPLARBindingSource.DataSource = this.databankPOObjDataSet1;
            // 
            // eJEMPLARTableAdapter
            // 
            this.eJEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // databankPOObjDataSet2
            // 
            this.databankPOObjDataSet2.DataSetName = "databankPOObjDataSet2";
            this.databankPOObjDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESERVAXEJEMPLARBindingSource
            // 
            this.rESERVAXEJEMPLARBindingSource.DataMember = "RESERVAXEJEMPLAR";
            this.rESERVAXEJEMPLARBindingSource.DataSource = this.databankPOObjDataSet2;
            // 
            // rESERVAXEJEMPLARTableAdapter
            // 
            this.rESERVAXEJEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // ejemplarIDDataGridViewTextBoxColumn
            // 
            this.ejemplarIDDataGridViewTextBoxColumn.DataPropertyName = "EjemplarID";
            this.ejemplarIDDataGridViewTextBoxColumn.HeaderText = "EjemplarID";
            this.ejemplarIDDataGridViewTextBoxColumn.Name = "ejemplarIDDataGridViewTextBoxColumn";
            this.ejemplarIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn
            // 
            this.usuarioIDDataGridViewTextBoxColumn.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn.Name = "usuarioIDDataGridViewTextBoxColumn";
            this.usuarioIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rESERVADataGridViewTextBoxColumn
            // 
            this.rESERVADataGridViewTextBoxColumn.DataPropertyName = "RESERVA";
            this.rESERVADataGridViewTextBoxColumn.HeaderText = "RESERVA";
            this.rESERVADataGridViewTextBoxColumn.Name = "rESERVADataGridViewTextBoxColumn";
            this.rESERVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dEVOLUCIONDataGridViewTextBoxColumn
            // 
            this.dEVOLUCIONDataGridViewTextBoxColumn.DataPropertyName = "DEVOLUCION";
            this.dEVOLUCIONDataGridViewTextBoxColumn.HeaderText = "DEVOLUCION";
            this.dEVOLUCIONDataGridViewTextBoxColumn.Name = "dEVOLUCIONDataGridViewTextBoxColumn";
            this.dEVOLUCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // databankPOObjDataSet3
            // 
            this.databankPOObjDataSet3.DataSetName = "databankPOObjDataSet3";
            this.databankPOObjDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRESTAMOXEJEMPLARBindingSource
            // 
            this.pRESTAMOXEJEMPLARBindingSource.DataMember = "PRESTAMOXEJEMPLAR";
            this.pRESTAMOXEJEMPLARBindingSource.DataSource = this.databankPOObjDataSet3;
            // 
            // pRESTAMOXEJEMPLARTableAdapter
            // 
            this.pRESTAMOXEJEMPLARTableAdapter.ClearBeforeFill = true;
            // 
            // ejemplarIDDataGridViewTextBoxColumn1
            // 
            this.ejemplarIDDataGridViewTextBoxColumn1.DataPropertyName = "EjemplarID";
            this.ejemplarIDDataGridViewTextBoxColumn1.HeaderText = "EjemplarID";
            this.ejemplarIDDataGridViewTextBoxColumn1.Name = "ejemplarIDDataGridViewTextBoxColumn1";
            this.ejemplarIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn1
            // 
            this.usuarioIDDataGridViewTextBoxColumn1.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn1.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn1.Name = "usuarioIDDataGridViewTextBoxColumn1";
            this.usuarioIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // prestamoDataGridViewTextBoxColumn
            // 
            this.prestamoDataGridViewTextBoxColumn.DataPropertyName = "Prestamo";
            this.prestamoDataGridViewTextBoxColumn.HeaderText = "Prestamo";
            this.prestamoDataGridViewTextBoxColumn.Name = "prestamoDataGridViewTextBoxColumn";
            this.prestamoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devolucionDataGridViewTextBoxColumn1
            // 
            this.devolucionDataGridViewTextBoxColumn1.DataPropertyName = "Devolucion";
            this.devolucionDataGridViewTextBoxColumn1.HeaderText = "Devolucion";
            this.devolucionDataGridViewTextBoxColumn1.Name = "devolucionDataGridViewTextBoxColumn1";
            this.devolucionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // databankPOObjDataSet4
            // 
            this.databankPOObjDataSet4.DataSetName = "databankPOObjDataSet4";
            this.databankPOObjDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource1
            // 
            this.uSUARIOBindingSource1.DataMember = "USUARIO";
            this.uSUARIOBindingSource1.DataSource = this.databankPOObjDataSet4;
            // 
            // uSUARIOTableAdapter1
            // 
            this.uSUARIOTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioIDDataGridViewTextBoxColumn2
            // 
            this.usuarioIDDataGridViewTextBoxColumn2.DataPropertyName = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn2.HeaderText = "UsuarioID";
            this.usuarioIDDataGridViewTextBoxColumn2.Name = "usuarioIDDataGridViewTextBoxColumn2";
            this.usuarioIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ocupacionDataGridViewTextBoxColumn
            // 
            this.ocupacionDataGridViewTextBoxColumn.DataPropertyName = "Ocupacion";
            this.ocupacionDataGridViewTextBoxColumn.HeaderText = "Ocupacion";
            this.ocupacionDataGridViewTextBoxColumn.Name = "ocupacionDataGridViewTextBoxColumn";
            this.ocupacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // institucionDataGridViewTextBoxColumn
            // 
            this.institucionDataGridViewTextBoxColumn.DataPropertyName = "Institucion";
            this.institucionDataGridViewTextBoxColumn.HeaderText = "Institucion";
            this.institucionDataGridViewTextBoxColumn.Name = "institucionDataGridViewTextBoxColumn";
            this.institucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotografiaDataGridViewImageColumn
            // 
            this.fotografiaDataGridViewImageColumn.DataPropertyName = "Fotografia";
            this.fotografiaDataGridViewImageColumn.HeaderText = "Fotografia";
            this.fotografiaDataGridViewImageColumn.Name = "fotografiaDataGridViewImageColumn";
            this.fotografiaDataGridViewImageColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mostrarEventosToolStripMenuItem
            // 
            this.mostrarEventosToolStripMenuItem.Name = "mostrarEventosToolStripMenuItem";
            this.mostrarEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarEventosToolStripMenuItem.Text = "Mostrar";
            this.mostrarEventosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEventosToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem1.Text = "Editar";
            this.editarToolStripMenuItem1.Click += new System.EventHandler(this.editarToolStripMenuItem1_Click);
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            this.mostrarToolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem2.Text = "Editar";
            this.editarToolStripMenuItem2.Click += new System.EventHandler(this.editarToolStripMenuItem2_Click);
            // 
            // mostrarToolStripMenuItem2
            // 
            this.mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2";
            this.mostrarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem2.Text = "Mostrar";
            this.mostrarToolStripMenuItem2.Click += new System.EventHandler(this.mostrarToolStripMenuItem2_Click);
            // 
            // editarToolStripMenuItem3
            // 
            this.editarToolStripMenuItem3.Name = "editarToolStripMenuItem3";
            this.editarToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem3.Text = "Editar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 577);
            this.Controls.Add(this.tclTools);
            this.Controls.Add(this.mspTools);
            this.MainMenuStrip = this.mspTools;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mspTools.ResumeLayout(false);
            this.mspTools.PerformLayout();
            this.tpgEditEvent.ResumeLayout(false);
            this.tpgEditEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEventAssistants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEventID)).EndInit();
            this.tclTools.ResumeLayout(false);
            this.tpgEditCollections.ResumeLayout(false);
            this.tpgEditCollections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCollectionID)).EndInit();
            this.tpgShowEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.tpgCollections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            this.tpgEditUsers.ResumeLayout(false);
            this.tpgEditUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUserID)).EndInit();
            this.tpgShowUsers.ResumeLayout(false);
            this.tpgEditEj.ResumeLayout(false);
            this.tpgEditEj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEjID)).EndInit();
            this.tpsShowEj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEj)).EndInit();
            this.tpgPrest.ResumeLayout(false);
            this.tpgRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamoEjemplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJEMPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVAXEJEMPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESTAMOXEJEMPLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databankPOObjDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspTools;
        private System.Windows.Forms.ToolStripMenuItem tspInicio;
        private System.Windows.Forms.ToolStripMenuItem tspEventsButton;
        private System.Windows.Forms.ToolStripMenuItem tspCollectionsMenu;
        private System.Windows.Forms.ToolStripMenuItem tspEjemplares;
        private System.Windows.Forms.ToolStripMenuItem tspUsers;
        private System.Windows.Forms.ToolStripMenuItem préstamosYReservasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdSelectEventImage;
        private System.Windows.Forms.TabPage tpgHome;
        private System.Windows.Forms.TabControl tclTools;
        private System.Windows.Forms.ToolStripMenuItem tspRedes;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teléfonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspSettings;
        private System.Windows.Forms.Label lblEventState;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.ComboBox cmbEventArea;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Label lblEventArea;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.PictureBox picEventImage;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnSelectEventImage;
        private System.Windows.Forms.DateTimePicker dtpEventEnds;
        private System.Windows.Forms.Label lblEventAssistants;
        private System.Windows.Forms.Label lblEventEnds;
        private System.Windows.Forms.DateTimePicker dtpEventStart;
        private System.Windows.Forms.NumericUpDown numEventAssistants;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label lblEventStart;
        private System.Windows.Forms.NumericUpDown numEventID;
        private System.Windows.Forms.TabPage tpgShowEvents;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabPage tpgEditEvent;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.TabPage tpgCollections;
        private System.Windows.Forms.DataGridView dgvCollections;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TabPage tpgEditCollections;
        private System.Windows.Forms.Label lblCollectionStatus;
        private System.Windows.Forms.Button btnDeleteCollection;
        private System.Windows.Forms.Button btnUpdateCollection;
        private System.Windows.Forms.Button btnAddNewCollection;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblCollectionGender;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblCollectionID;
        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.Label lblCollectionType;
        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.NumericUpDown numCollectionID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpgEditUsers;
        private System.Windows.Forms.TabPage tpgShowUsers;
        private System.Windows.Forms.TabPage tpgEditEj;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.TextBox txtUserOccupation;
        private System.Windows.Forms.NumericUpDown numUserID;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserInst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserDir;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog ofdSelectUserImage;
        private System.Windows.Forms.TabPage tpsShowEj;
        private System.Windows.Forms.TabPage tpgPrest;
        private System.Windows.Forms.TabPage tpgRes;
        private System.Windows.Forms.DateTimePicker dtPub;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.ComboBox cmbCollection;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.ComboBox cmbEjTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtEjName;
        private System.Windows.Forms.Label lblEjPub;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblEjID;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Label lblEjName;
        private System.Windows.Forms.Button btnSelectPort;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblEjCollection;
        private System.Windows.Forms.NumericUpDown numEjID;
        private System.Windows.Forms.Label lblEjEditorial;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.DataGridView dgvFiltered;
        private System.Windows.Forms.RadioButton rbFormat;
        private System.Windows.Forms.RadioButton rbAutor;
        private System.Windows.Forms.RadioButton rbPartialTitle;
        private System.Windows.Forms.RadioButton rbWords;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchLegend;
        private System.Windows.Forms.Button btnDeleteEj;
        private System.Windows.Forms.Button btnNewEj;
        private System.Windows.Forms.Button btnUpdateEj;
        private System.Windows.Forms.OpenFileDialog ofdSelectBook;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.DataGridView dgvEj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dgvPrestamoEjemplar;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label17;
        private databankPOObjDataSet databankPOObjDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private databankPOObjDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private databankPOObjDataSet1 databankPOObjDataSet1;
        private System.Windows.Forms.BindingSource eJEMPLARBindingSource;
        private databankPOObjDataSet1TableAdapters.EJEMPLARTableAdapter eJEMPLARTableAdapter;
        private databankPOObjDataSet2 databankPOObjDataSet2;
        private System.Windows.Forms.BindingSource rESERVAXEJEMPLARBindingSource;
        private databankPOObjDataSet2TableAdapters.RESERVAXEJEMPLARTableAdapter rESERVAXEJEMPLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejemplarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESERVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVOLUCIONDataGridViewTextBoxColumn;
        private databankPOObjDataSet3 databankPOObjDataSet3;
        private System.Windows.Forms.BindingSource pRESTAMOXEJEMPLARBindingSource;
        private databankPOObjDataSet3TableAdapters.PRESTAMOXEJEMPLARTableAdapter pRESTAMOXEJEMPLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ejemplarIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucionDataGridViewTextBoxColumn1;
        private databankPOObjDataSet4 databankPOObjDataSet4;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource1;
        private databankPOObjDataSet4TableAdapters.USUARIOTableAdapter uSUARIOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografiaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem mostrarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem3;
    }
}


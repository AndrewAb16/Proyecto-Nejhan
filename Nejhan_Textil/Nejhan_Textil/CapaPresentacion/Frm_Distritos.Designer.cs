﻿namespace CapaPresentacion
{
    partial class Frm_Distritos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Distritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pnl_Listado_po = new System.Windows.Forms.Panel();
            this.Btn_retornar1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_buscar1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_buscar1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Dgv_provincias = new System.Windows.Forms.DataGridView();
            this.Txt_descripcion_po = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion_di = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_lupa1 = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.pnl_titulo_form = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.Tbc_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_Listado_po.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_provincias)).BeginInit();
            this.pnl_titulo_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Controls.Add(this.tabPage1);
            this.Tbc_principal.Controls.Add(this.tabPage2);
            this.Tbc_principal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.Tbc_principal.Location = new System.Drawing.Point(34, 60);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(969, 381);
            this.Tbc_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Menu;
            this.Dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Dgv_principal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Dgv_principal.ColumnHeadersHeight = 35;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_principal.EnableHeadersVisualStyles = false;
            this.Dgv_principal.Location = new System.Drawing.Point(19, 56);
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            this.Dgv_principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_principal.Size = new System.Drawing.Size(923, 234);
            this.Dgv_principal.TabIndex = 3;
            this.Dgv_principal.DoubleClick += new System.EventHandler(this.Dgv_principal_DoubleClick);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(317, 26);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 24);
            this.Btn_buscar.TabIndex = 2;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(65, 27);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(246, 23);
            this.Txt_buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pnl_Listado_po);
            this.tabPage2.Controls.Add(this.Txt_descripcion_po);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.Txt_descripcion_di);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Btn_lupa1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pnl_Listado_po
            // 
            this.Pnl_Listado_po.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Pnl_Listado_po.Controls.Add(this.Btn_retornar1);
            this.Pnl_Listado_po.Controls.Add(this.Btn_buscar1);
            this.Pnl_Listado_po.Controls.Add(this.label9);
            this.Pnl_Listado_po.Controls.Add(this.Txt_buscar1);
            this.Pnl_Listado_po.Controls.Add(this.label8);
            this.Pnl_Listado_po.Controls.Add(this.Dgv_provincias);
            this.Pnl_Listado_po.Location = new System.Drawing.Point(392, 262);
            this.Pnl_Listado_po.Name = "Pnl_Listado_po";
            this.Pnl_Listado_po.Size = new System.Drawing.Size(594, 216);
            this.Pnl_Listado_po.TabIndex = 19;
            this.Pnl_Listado_po.Visible = false;
            // 
            // Btn_retornar1
            // 
            this.Btn_retornar1.ImageKey = "retornar.png";
            this.Btn_retornar1.ImageList = this.imageList2;
            this.Btn_retornar1.Location = new System.Drawing.Point(269, 40);
            this.Btn_retornar1.Name = "Btn_retornar1";
            this.Btn_retornar1.Size = new System.Drawing.Size(34, 23);
            this.Btn_retornar1.TabIndex = 25;
            this.Btn_retornar1.UseVisualStyleBackColor = true;
            this.Btn_retornar1.Click += new System.EventHandler(this.Btn_retornar1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "lupa.png");
            this.imageList2.Images.SetKeyName(1, "retornar.png");
            // 
            // Btn_buscar1
            // 
            this.Btn_buscar1.ImageKey = "lupa.png";
            this.Btn_buscar1.ImageList = this.imageList2;
            this.Btn_buscar1.Location = new System.Drawing.Point(234, 40);
            this.Btn_buscar1.Name = "Btn_buscar1";
            this.Btn_buscar1.Size = new System.Drawing.Size(34, 23);
            this.Btn_buscar1.TabIndex = 24;
            this.Btn_buscar1.UseVisualStyleBackColor = true;
            this.Btn_buscar1.Click += new System.EventHandler(this.Btn_buscar1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Buscar:";
            // 
            // Txt_buscar1
            // 
            this.Txt_buscar1.Location = new System.Drawing.Point(61, 41);
            this.Txt_buscar1.Name = "Txt_buscar1";
            this.Txt_buscar1.Size = new System.Drawing.Size(167, 23);
            this.Txt_buscar1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "LISTADO DE PROVINCIAS";
            // 
            // Dgv_provincias
            // 
            this.Dgv_provincias.AllowUserToAddRows = false;
            this.Dgv_provincias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Menu;
            this.Dgv_provincias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.Dgv_provincias.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Dgv_provincias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_provincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_provincias.ColumnHeadersHeight = 35;
            this.Dgv_provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_provincias.EnableHeadersVisualStyles = false;
            this.Dgv_provincias.Location = new System.Drawing.Point(15, 67);
            this.Dgv_provincias.Name = "Dgv_provincias";
            this.Dgv_provincias.ReadOnly = true;
            this.Dgv_provincias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_provincias.Size = new System.Drawing.Size(565, 139);
            this.Dgv_provincias.TabIndex = 20;
            this.Dgv_provincias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_provincias_CellDoubleClick);
            // 
            // Txt_descripcion_po
            // 
            this.Txt_descripcion_po.Location = new System.Drawing.Point(131, 47);
            this.Txt_descripcion_po.MaxLength = 100;
            this.Txt_descripcion_po.Name = "Txt_descripcion_po";
            this.Txt_descripcion_po.ReadOnly = true;
            this.Txt_descripcion_po.Size = new System.Drawing.Size(264, 23);
            this.Txt_descripcion_po.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Provincia: (*)";
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar.Location = new System.Drawing.Point(293, 136);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(76, 26);
            this.Btn_retornar.TabIndex = 4;
            this.Btn_retornar.Text = "Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Visible = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.Location = new System.Drawing.Point(211, 135);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(76, 26);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.Location = new System.Drawing.Point(129, 135);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(76, 26);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_descripcion_di
            // 
            this.Txt_descripcion_di.Location = new System.Drawing.Point(130, 79);
            this.Txt_descripcion_di.MaxLength = 100;
            this.Txt_descripcion_di.Name = "Txt_descripcion_di";
            this.Txt_descripcion_di.ReadOnly = true;
            this.Txt_descripcion_di.Size = new System.Drawing.Size(265, 23);
            this.Txt_descripcion_di.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Distrito: (*)";
            // 
            // Btn_lupa1
            // 
            this.Btn_lupa1.ImageKey = "lupa.png";
            this.Btn_lupa1.ImageList = this.imageList2;
            this.Btn_lupa1.Location = new System.Drawing.Point(407, 47);
            this.Btn_lupa1.Name = "Btn_lupa1";
            this.Btn_lupa1.Size = new System.Drawing.Size(34, 23);
            this.Btn_lupa1.TabIndex = 10;
            this.Btn_lupa1.UseVisualStyleBackColor = true;
            this.Btn_lupa1.Visible = false;
            this.Btn_lupa1.Click += new System.EventHandler(this.Btn_lupa1_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.Khaki;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ImageKey = "nuevo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(607, 485);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 60);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.ImageKey = "actualizar.png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(688, 485);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 60);
            this.Btn_actualizar.TabIndex = 2;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.ImageKey = "eliminar.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(769, 485);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 60);
            this.Btn_eliminar.TabIndex = 3;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.Khaki;
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporte.ImageKey = "reporte.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(850, 485);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(75, 60);
            this.Btn_reporte.TabIndex = 4;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.Khaki;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.ImageKey = "salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(931, 485);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 60);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // pnl_titulo_form
            // 
            this.pnl_titulo_form.BackColor = System.Drawing.Color.Olive;
            this.pnl_titulo_form.Controls.Add(this.label16);
            this.pnl_titulo_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo_form.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo_form.Name = "pnl_titulo_form";
            this.pnl_titulo_form.Size = new System.Drawing.Size(1059, 54);
            this.pnl_titulo_form.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(439, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "DISTRITOS";
            // 
            // Frm_Distritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1059, 576);
            this.Controls.Add(this.pnl_titulo_form);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Tbc_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Distritos";
            this.Text = "DISTRITOS";
            this.Load += new System.EventHandler(this.Frm_Distritos_Load);
            this.Tbc_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_Listado_po.ResumeLayout(false);
            this.Pnl_Listado_po.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_provincias)).EndInit();
            this.pnl_titulo_form.ResumeLayout(false);
            this.pnl_titulo_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion_di;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_lupa1;
        private System.Windows.Forms.TextBox Txt_descripcion_po;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pnl_Listado_po;
        private System.Windows.Forms.Button Btn_retornar1;
        private System.Windows.Forms.Button Btn_buscar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_buscar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_provincias;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Panel pnl_titulo_form;
        private System.Windows.Forms.Label label16;
    }
}
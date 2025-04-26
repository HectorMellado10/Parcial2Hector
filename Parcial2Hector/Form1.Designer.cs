namespace Parcial2Hector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            lblcarnet = new Label();
            lblnombre = new Label();
            lblapellido = new Label();
            lblseccion = new Label();
            lblcorreo = new Label();
            txtcarnet = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtseccion = new TextBox();
            txtcorreo = new TextBox();
            btnagregar = new Button();
            btneliminar = new Button();
            btnmodificar = new Button();
            btnlimpiar = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(792, 511);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblcarnet
            // 
            lblcarnet.AutoSize = true;
            lblcarnet.BorderStyle = BorderStyle.Fixed3D;
            lblcarnet.Location = new Point(12, 34);
            lblcarnet.Name = "lblcarnet";
            lblcarnet.Size = new Size(54, 22);
            lblcarnet.TabIndex = 1;
            lblcarnet.Text = "Carnet";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BorderStyle = BorderStyle.Fixed3D;
            lblnombre.Location = new Point(12, 75);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(66, 22);
            lblnombre.TabIndex = 2;
            lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.BorderStyle = BorderStyle.Fixed3D;
            lblapellido.Location = new Point(12, 111);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(68, 22);
            lblapellido.TabIndex = 3;
            lblapellido.Text = "Apellido";
            lblapellido.Click += lblapellido_Click;
            // 
            // lblseccion
            // 
            lblseccion.AutoSize = true;
            lblseccion.BorderStyle = BorderStyle.Fixed3D;
            lblseccion.Location = new Point(12, 144);
            lblseccion.Name = "lblseccion";
            lblseccion.Size = new Size(62, 22);
            lblseccion.TabIndex = 4;
            lblseccion.Text = "Seccion";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.BorderStyle = BorderStyle.Fixed3D;
            lblcorreo.Location = new Point(12, 179);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(56, 22);
            lblcorreo.TabIndex = 5;
            lblcorreo.Text = "Correo";
            // 
            // txtcarnet
            // 
            txtcarnet.Location = new Point(84, 31);
            txtcarnet.Name = "txtcarnet";
            txtcarnet.Size = new Size(125, 27);
            txtcarnet.TabIndex = 6;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(84, 68);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 7;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(84, 108);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 8;
            // 
            // txtseccion
            // 
            txtseccion.Location = new Point(84, 144);
            txtseccion.Name = "txtseccion";
            txtseccion.Size = new Size(125, 27);
            txtseccion.TabIndex = 9;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(84, 177);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(125, 27);
            txtcorreo.TabIndex = 10;
            // 
            // btnagregar
            // 
            btnagregar.BackgroundImageLayout = ImageLayout.Center;
            btnagregar.Location = new Point(22, 236);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(187, 29);
            btnagregar.TabIndex = 11;
            btnagregar.Text = "Agregar nuevo";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(22, 271);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(187, 29);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(22, 306);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(187, 29);
            btnmodificar.TabIndex = 13;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(22, 377);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(187, 29);
            btnlimpiar.TabIndex = 14;
            btnlimpiar.Text = "Limpiar Formulario";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(316, 31);
            label6.Name = "label6";
            label6.Size = new Size(138, 22);
            label6.TabIndex = 15;
            label6.Text = "Filtrar por Seccion :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(458, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1120, 611);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmodificar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(txtcorreo);
            Controls.Add(txtseccion);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtcarnet);
            Controls.Add(lblcorreo);
            Controls.Add(lblseccion);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(lblcarnet);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblcarnet;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblseccion;
        private Label lblcorreo;
        private TextBox txtcarnet;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtseccion;
        private TextBox txtcorreo;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnmodificar;
        private Button btnlimpiar;
        private Label label6;
        private ComboBox comboBox1;
    }
}

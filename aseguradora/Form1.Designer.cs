namespace aseguradora
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEliminar = new Button();
            btnEditar = new Button();
            txtEstado = new TextBox();
            txtNombre = new TextBox();
            txtNIT = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregarProveedor = new Button();
            tabPage2 = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            btnEliminarAfiliado = new Button();
            btnEditarAfiliado = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnGuardarAfiliado = new Button();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.ImeMode = ImeMode.On;
            tabControl1.Location = new Point(12, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(254, 390);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnEditar);
            tabPage1.Controls.Add(txtEstado);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(txtNIT);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnAgregarProveedor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(246, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proveedores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(58, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar Proveedor";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 148);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar Proveedor";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(141, 98);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(40, 23);
            txtEstado.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(116, 31);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(100, 23);
            txtNIT.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 101);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 30);
            label2.TabIndex = 1;
            label2.Text = "Nombre/\r\nRazón Social";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 1;
            label1.Text = "NIT";
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(126, 148);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(114, 23);
            btnAgregarProveedor.TabIndex = 0;
            btnAgregarProveedor.Text = "Agregar/Guardar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dateTimePicker2);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnEliminarAfiliado);
            tabPage2.Controls.Add(btnEditarAfiliado);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnGuardarAfiliado);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(246, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Afiliados";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(115, 128);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(115, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 128);
            label8.Name = "label8";
            label8.Size = new Size(76, 30);
            label8.TabIndex = 20;
            label8.Text = "Fecha Fin \r\nde Cobertura";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(115, 169);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 172);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 18;
            label9.Text = "Monto Cobertura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 89);
            label7.Name = "label7";
            label7.Size = new Size(76, 30);
            label7.TabIndex = 14;
            label7.Text = "Fecha Inicio \r\nde Cobertura";
            // 
            // btnEliminarAfiliado
            // 
            btnEliminarAfiliado.Location = new Point(61, 301);
            btnEliminarAfiliado.Name = "btnEliminarAfiliado";
            btnEliminarAfiliado.Size = new Size(123, 23);
            btnEliminarAfiliado.TabIndex = 13;
            btnEliminarAfiliado.Text = "Eliminar Proveedor";
            btnEliminarAfiliado.UseVisualStyleBackColor = true;
            // 
            // btnEditarAfiliado
            // 
            btnEditarAfiliado.Location = new Point(9, 272);
            btnEditarAfiliado.Name = "btnEditarAfiliado";
            btnEditarAfiliado.Size = new Size(105, 23);
            btnEditarAfiliado.TabIndex = 12;
            btnEditarAfiliado.Text = "Editar Proveedor";
            btnEditarAfiliado.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(40, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 201);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 63);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 7;
            label5.Text = "Nombre Completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 29);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 8;
            label6.Text = "Codigo Afiliado";
            label6.Click += label6_Click;
            // 
            // btnGuardarAfiliado
            // 
            btnGuardarAfiliado.Location = new Point(129, 272);
            btnGuardarAfiliado.Name = "btnGuardarAfiliado";
            btnGuardarAfiliado.Size = new Size(114, 23);
            btnGuardarAfiliado.TabIndex = 5;
            btnGuardarAfiliado.Text = "Agregar/Guardar";
            btnGuardarAfiliado.UseVisualStyleBackColor = true;
            btnGuardarAfiliado.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(435, 282);
            dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAgregarProveedor;
        private TextBox txtEstado;
        private TextBox txtNombre;
        private TextBox txtNIT;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnEliminarAfiliado;
        private Button btnEditarAfiliado;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnGuardarAfiliado;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Label label7;
    }
}
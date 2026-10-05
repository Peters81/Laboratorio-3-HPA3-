namespace EjemploGrid
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            dgvdatos = new DataGridView();
            txtNombre = new TextBox();
            txtIdEmpleado = new TextBox();
            txtApellido = new TextBox();
            txtSalario = new TextBox();
            txtEmail = new TextBox();
            lblNombre = new Label();
            lblIdEmpleado = new Label();
            Apellido = new Label();
            Email = new Label();
            Fecha = new Label();
            Salario = new Label();
            dateTimePicker1 = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(614, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(24, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // dgvdatos
            // 
            dgvdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdatos.Location = new Point(70, 253);
            dgvdatos.Margin = new Padding(3, 2, 3, 2);
            dgvdatos.Name = "dgvdatos";
            dgvdatos.RowHeadersWidth = 51;
            dgvdatos.Size = new Size(480, 169);
            dgvdatos.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(237, 67);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(237, 29);
            txtIdEmpleado.Margin = new Padding(3, 2, 3, 2);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(219, 23);
            txtIdEmpleado.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(237, 103);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(219, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(237, 211);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(219, 23);
            txtSalario.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 141);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(176, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.Location = new Point(158, 37);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(73, 15);
            lblIdEmpleado.TabIndex = 9;
            lblIdEmpleado.Text = "Id Empleado";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(179, 109);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 10;
            Apellido.Text = "Apellido";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(191, 149);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 11;
            Email.Text = "Email";
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(124, 188);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(103, 15);
            Fecha.TabIndex = 12;
            Fecha.Text = "Fecha Nacimiento";
            // 
            // Salario
            // 
            Salario.AutoSize = true;
            Salario.Location = new Point(179, 214);
            Salario.Name = "Salario";
            Salario.Size = new Size(42, 15);
            Salario.TabIndex = 13;
            Salario.Text = "Salario";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(237, 180);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 433);
            Controls.Add(dateTimePicker1);
            Controls.Add(Salario);
            Controls.Add(Fecha);
            Controls.Add(Email);
            Controls.Add(Apellido);
            Controls.Add(lblIdEmpleado);
            Controls.Add(lblNombre);
            Controls.Add(txtSalario);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtIdEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(dgvdatos);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private DataGridView dgvdatos;
        private TextBox txtNombre;
        private TextBox txtIdEmpleado;
        private TextBox txtApellido;
        private TextBox txtSalario;
        private TextBox txtEmail;
        private Label lblNombre;
        private Label lblIdEmpleado;
        private Label Apellido;
        private Label Email;
        private Label Fecha;
        private Label Salario;
        private DateTimePicker dateTimePicker1;
        private ErrorProvider errorProvider1;
    }
}

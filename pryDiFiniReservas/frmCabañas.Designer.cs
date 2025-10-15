namespace pryDiFiniReservas
{
    partial class frmCabañas
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
            btnAceptar = new Button();
            lblReserva = new Label();
            pnl4 = new Panel();
            txtTelefono = new TextBox();
            lbltelefonos = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pnl3 = new Panel();
            cmbTarjetas = new ComboBox();
            lblTarjetas = new Label();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            lblPago = new Label();
            lblAdicionales = new Label();
            panel3 = new Panel();
            pnl2 = new Panel();
            checkBox1 = new CheckBox();
            kkkkk = new CheckBox();
            checkBox3 = new CheckBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            lblCabaña = new Label();
            label1 = new Label();
            pnlUno = new Panel();
            txtDias = new TextBox();
            lblDias = new Label();
            cmbPersonas = new ComboBox();
            lblPersonas = new Label();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            btnCancelar = new Button();
            pnl4.SuspendLayout();
            pnl3.SuspendLayout();
            panel3.SuspendLayout();
            pnl2.SuspendLayout();
            pnlUno.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(449, 469);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(149, 37);
            btnAceptar.TabIndex = 32;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblReserva
            // 
            lblReserva.AutoSize = true;
            lblReserva.Location = new Point(25, 295);
            lblReserva.Name = "lblReserva";
            lblReserva.Size = new Size(108, 15);
            lblReserva.TabIndex = 31;
            lblReserva.Text = "Titular de la reserva";
            // 
            // pnl4
            // 
            pnl4.BorderStyle = BorderStyle.Fixed3D;
            pnl4.Controls.Add(txtTelefono);
            pnl4.Controls.Add(lbltelefonos);
            pnl4.Controls.Add(txtNombre);
            pnl4.Controls.Add(lblNombre);
            pnl4.Location = new Point(25, 313);
            pnl4.Name = "pnl4";
            pnl4.Size = new Size(573, 121);
            pnl4.TabIndex = 30;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(101, 65);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(442, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // lbltelefonos
            // 
            lbltelefonos.AutoSize = true;
            lbltelefonos.Location = new Point(20, 68);
            lbltelefonos.Name = "lbltelefonos";
            lbltelefonos.Size = new Size(57, 15);
            lbltelefonos.TabIndex = 7;
            lbltelefonos.Text = "Teléfonos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(442, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // pnl3
            // 
            pnl3.BorderStyle = BorderStyle.Fixed3D;
            pnl3.Controls.Add(cmbTarjetas);
            pnl3.Controls.Add(lblTarjetas);
            pnl3.Controls.Add(optTarjeta);
            pnl3.Controls.Add(optEfectivo);
            pnl3.Location = new Point(172, 165);
            pnl3.Name = "pnl3";
            pnl3.Size = new Size(426, 111);
            pnl3.TabIndex = 29;
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(96, 67);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(202, 23);
            cmbTarjetas.TabIndex = 5;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(96, 43);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(46, 15);
            lblTarjetas.TabIndex = 4;
            lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(16, 42);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(16, 16);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(67, 19);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(172, 147);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(92, 15);
            lblPago.TabIndex = 28;
            lblPago.Text = "Formas de pago";
            // 
            // lblAdicionales
            // 
            lblAdicionales.AutoSize = true;
            lblAdicionales.Location = new Point(25, 147);
            lblAdicionales.Name = "lblAdicionales";
            lblAdicionales.Size = new Size(68, 15);
            lblAdicionales.TabIndex = 23;
            lblAdicionales.Text = "Adicionales";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pnl2);
            panel3.Controls.Add(chkTelevisor);
            panel3.Controls.Add(chkHeladera);
            panel3.Controls.Add(chkCocina);
            panel3.Location = new Point(25, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 111);
            panel3.TabIndex = 27;
            // 
            // pnl2
            // 
            pnl2.BorderStyle = BorderStyle.Fixed3D;
            pnl2.Controls.Add(checkBox1);
            pnl2.Controls.Add(kkkkk);
            pnl2.Controls.Add(checkBox3);
            pnl2.Location = new Point(-2, -2);
            pnl2.Name = "pnl2";
            pnl2.Size = new Size(122, 111);
            pnl2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 67);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Televisor";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // kkkkk
            // 
            kkkkk.AutoSize = true;
            kkkkk.Location = new Point(12, 42);
            kkkkk.Name = "kkkkk";
            kkkkk.Size = new Size(73, 19);
            kkkkk.TabIndex = 1;
            kkkkk.Text = "Heladera";
            kkkkk.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 17);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(63, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Cocina";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(12, 67);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(70, 19);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(12, 42);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(12, 17);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // lblCabaña
            // 
            lblCabaña.AutoSize = true;
            lblCabaña.BackColor = SystemColors.Control;
            lblCabaña.Location = new Point(25, 30);
            lblCabaña.Name = "lblCabaña";
            lblCabaña.Size = new Size(87, 15);
            lblCabaña.TabIndex = 24;
            lblCabaña.Text = "Tipo de cabaña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 25;
            // 
            // pnlUno
            // 
            pnlUno.BorderStyle = BorderStyle.Fixed3D;
            pnlUno.Controls.Add(txtDias);
            pnlUno.Controls.Add(lblDias);
            pnlUno.Controls.Add(cmbPersonas);
            pnlUno.Controls.Add(lblPersonas);
            pnlUno.Controls.Add(cmbTipo);
            pnlUno.Controls.Add(lblTipo);
            pnlUno.Location = new Point(25, 48);
            pnlUno.Name = "pnlUno";
            pnlUno.Size = new Size(573, 81);
            pnlUno.TabIndex = 26;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(422, 25);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(121, 23);
            txtDias.TabIndex = 5;
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(387, 28);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 4;
            lblDias.Text = "Dias";
            // 
            // cmbPersonas
            // 
            cmbPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(243, 25);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 23);
            cmbPersonas.TabIndex = 3;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(183, 28);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(46, 25);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(10, 28);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(294, 469);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 37);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCabañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 549);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblReserva);
            Controls.Add(pnl4);
            Controls.Add(pnl3);
            Controls.Add(lblPago);
            Controls.Add(lblAdicionales);
            Controls.Add(panel3);
            Controls.Add(lblCabaña);
            Controls.Add(label1);
            Controls.Add(pnlUno);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmCabañas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservas de cabañas";
            Load += frmCabañas_Load;
            pnl4.ResumeLayout(false);
            pnl4.PerformLayout();
            pnl3.ResumeLayout(false);
            pnl3.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnl2.ResumeLayout(false);
            pnl2.PerformLayout();
            pnlUno.ResumeLayout(false);
            pnlUno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblReserva;
        private Panel pnl4;
        private TextBox txtTelefono;
        private Label lbltelefonos;
        private TextBox txtNombre;
        private Label lblNombre;
        private Panel pnl3;
        private ComboBox cmbTarjetas;
        private Label lblTarjetas;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private Label lblPago;
        private Label lblAdicionales;
        private Panel panel3;
        private Panel pnl2;
        private CheckBox checkBox1;
        private CheckBox kkkkk;
        private CheckBox checkBox3;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private Label lblCabaña;
        private Label label1;
        private Panel pnlUno;
        private TextBox txtDias;
        private Label lblDias;
        private ComboBox cmbPersonas;
        private Label lblPersonas;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private Button btnCancelar;
    }
}

namespace RegistroEscuelita
{
    partial class RegistroNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombresB = new System.Windows.Forms.TextBox();
            this.txtApellidosB = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.mtxtCedulaN = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelularP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEdad = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtCedulaP = new System.Windows.Forms.MaskedTextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres Completos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos Completos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular de Padre de Familia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cedula Estudiante:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cedula Padre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre y Apellido Representante:";
            // 
            // txtNombresB
            // 
            this.txtNombresB.Location = new System.Drawing.Point(141, 110);
            this.txtNombresB.Name = "txtNombresB";
            this.txtNombresB.Size = new System.Drawing.Size(125, 20);
            this.txtNombresB.TabIndex = 8;
            // 
            // txtApellidosB
            // 
            this.txtApellidosB.Location = new System.Drawing.Point(141, 150);
            this.txtApellidosB.Name = "txtApellidosB";
            this.txtApellidosB.Size = new System.Drawing.Size(125, 20);
            this.txtApellidosB.TabIndex = 9;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(205, 193);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(141, 20);
            this.txtNombreP.TabIndex = 10;
            // 
            // mtxtCedulaN
            // 
            this.mtxtCedulaN.Location = new System.Drawing.Point(426, 110);
            this.mtxtCedulaN.Mask = "9999999999";
            this.mtxtCedulaN.Name = "mtxtCedulaN";
            this.mtxtCedulaN.Size = new System.Drawing.Size(127, 20);
            this.mtxtCedulaN.TabIndex = 11;
            // 
            // mtxtCelularP
            // 
            this.mtxtCelularP.Location = new System.Drawing.Point(528, 193);
            this.mtxtCelularP.Mask = "9999999999";
            this.mtxtCelularP.Name = "mtxtCelularP";
            this.mtxtCelularP.Size = new System.Drawing.Size(138, 20);
            this.mtxtCelularP.TabIndex = 12;
            // 
            // mtxtEdad
            // 
            this.mtxtEdad.Location = new System.Drawing.Point(661, 110);
            this.mtxtEdad.Mask = "99";
            this.mtxtEdad.Name = "mtxtEdad";
            this.mtxtEdad.Size = new System.Drawing.Size(100, 20);
            this.mtxtEdad.TabIndex = 13;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(376, 241);
            this.mtxtCedula.Mask = "9999999999";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(138, 20);
            this.mtxtCedula.TabIndex = 14;
            // 
            // cmbGrado
            // 
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Items.AddRange(new object[] {
            "Primer Grado",
            "Segundo Grado",
            "Tercer Grado",
            "Cuarto Grado",
            "Quinto Grado",
            "Sexto Grado",
            "Septimo Grado"});
            this.cmbGrado.Location = new System.Drawing.Point(640, 150);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(121, 21);
            this.cmbGrado.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(515, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "REGISTRO DE LA ESCUELITA \"ABC\"";
            // 
            // mtxtCedulaP
            // 
            this.mtxtCedulaP.Location = new System.Drawing.Point(376, 241);
            this.mtxtCedulaP.Name = "mtxtCedulaP";
            this.mtxtCedulaP.Size = new System.Drawing.Size(138, 20);
            this.mtxtCedulaP.TabIndex = 14;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(51, 373);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(710, 150);
            this.dgvDatos.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(376, 317);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Genero";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(432, 150);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 22;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegistroNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroEscuelita.Properties.Resources.WhatsApp_Image_2023_07_30_at_22_35_10;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.mtxtCedula);
            this.Controls.Add(this.mtxtEdad);
            this.Controls.Add(this.mtxtCelularP);
            this.Controls.Add(this.mtxtCedulaN);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.txtApellidosB);
            this.Controls.Add(this.txtNombresB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.Name = "RegistroNuevo";
            this.Text = "RegistroNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombresB;
        private System.Windows.Forms.TextBox txtApellidosB;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.MaskedTextBox mtxtCedulaN;
        private System.Windows.Forms.MaskedTextBox mtxtCelularP;
        private System.Windows.Forms.MaskedTextBox mtxtEdad;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtCedulaP;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}
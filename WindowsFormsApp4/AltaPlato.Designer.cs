namespace Negocio
{
    partial class AltaPlato
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
            this.chktenedor = new System.Windows.Forms.CheckBox();
            this.chkCuchillo = new System.Windows.Forms.CheckBox();
            this.chkCuchara = new System.Windows.Forms.CheckBox();
            this.txtNombrePla = new System.Windows.Forms.TextBox();
            this.txtPrecioPla = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.comboBoxPla = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // chktenedor
            // 
            this.chktenedor.AutoSize = true;
            this.chktenedor.Location = new System.Drawing.Point(31, 166);
            this.chktenedor.Name = "chktenedor";
            this.chktenedor.Size = new System.Drawing.Size(66, 17);
            this.chktenedor.TabIndex = 3;
            this.chktenedor.Text = "Tenedor";
            this.chktenedor.UseVisualStyleBackColor = true;
            // 
            // chkCuchillo
            // 
            this.chkCuchillo.AutoSize = true;
            this.chkCuchillo.Location = new System.Drawing.Point(31, 189);
            this.chkCuchillo.Name = "chkCuchillo";
            this.chkCuchillo.Size = new System.Drawing.Size(63, 17);
            this.chkCuchillo.TabIndex = 4;
            this.chkCuchillo.Text = "Cuchillo";
            this.chkCuchillo.UseVisualStyleBackColor = true;
            // 
            // chkCuchara
            // 
            this.chkCuchara.AutoSize = true;
            this.chkCuchara.Location = new System.Drawing.Point(31, 212);
            this.chkCuchara.Name = "chkCuchara";
            this.chkCuchara.Size = new System.Drawing.Size(66, 17);
            this.chkCuchara.TabIndex = 5;
            this.chkCuchara.Text = "Cuchara";
            this.chkCuchara.UseVisualStyleBackColor = true;
            // 
            // txtNombrePla
            // 
            this.txtNombrePla.Location = new System.Drawing.Point(88, 34);
            this.txtNombrePla.Name = "txtNombrePla";
            this.txtNombrePla.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePla.TabIndex = 6;
            this.txtNombrePla.TextChanged += new System.EventHandler(this.txtNombrePla_TextChanged);
            // 
            // txtPrecioPla
            // 
            this.txtPrecioPla.Location = new System.Drawing.Point(88, 76);
            this.txtPrecioPla.Name = "txtPrecioPla";
            this.txtPrecioPla.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPla.TabIndex = 7;
            this.txtPrecioPla.TextChanged += new System.EventHandler(this.txtPrecioPla_TextChanged);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(23, 235);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(84, 35);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(162, 235);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(92, 35);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxPla
            // 
            this.comboBoxPla.FormattingEnabled = true;
            this.comboBoxPla.Items.AddRange(new object[] {
            "Plato principal",
            "Entrada",
            "Postre",
            "Bebida",
            "Otros"});
            this.comboBoxPla.Location = new System.Drawing.Point(106, 123);
            this.comboBoxPla.Name = "comboBoxPla";
            this.comboBoxPla.Size = new System.Drawing.Size(148, 21);
            this.comboBoxPla.TabIndex = 10;
            this.comboBoxPla.Text = "Seleccionar tipo de plato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de plato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID plato";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(85, 7);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(39, 13);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "Nuevo";
            // 
            // AltaPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(294, 282);
            this.ControlBox = false;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPla);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.txtPrecioPla);
            this.Controls.Add(this.txtNombrePla);
            this.Controls.Add(this.chkCuchara);
            this.Controls.Add(this.chkCuchillo);
            this.Controls.Add(this.chktenedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregado de plato";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AltaPlato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNombrePla;
        public System.Windows.Forms.TextBox txtPrecioPla;
        public System.Windows.Forms.ComboBox comboBoxPla;
        public System.Windows.Forms.CheckBox chktenedor;
        public System.Windows.Forms.CheckBox chkCuchillo;
        public System.Windows.Forms.CheckBox chkCuchara;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label idLabel;
    }
}
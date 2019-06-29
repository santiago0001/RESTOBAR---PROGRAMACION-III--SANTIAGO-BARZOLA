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
            this.txtNombrePla = new System.Windows.Forms.TextBox();
            this.txtPrecioPla = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.comboBoxPla = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dgvVajilla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboVajilla = new System.Windows.Forms.ComboBox();
            this.grupVajilla = new System.Windows.Forms.GroupBox();
            this.BotNew = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.LabError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVajilla)).BeginInit();
            this.grupVajilla.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // txtNombrePla
            // 
            this.txtNombrePla.Location = new System.Drawing.Point(100, 34);
            this.txtNombrePla.MaxLength = 20;
            this.txtNombrePla.Name = "txtNombrePla";
            this.txtNombrePla.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePla.TabIndex = 6;
            this.txtNombrePla.TextChanged += new System.EventHandler(this.txtNombrePla_TextChanged);
            // 
            // txtPrecioPla
            // 
            this.txtPrecioPla.Location = new System.Drawing.Point(100, 79);
            this.txtPrecioPla.Name = "txtPrecioPla";
            this.txtPrecioPla.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioPla.TabIndex = 7;
            this.txtPrecioPla.TextChanged += new System.EventHandler(this.txtPrecioPla_TextChanged);
            this.txtPrecioPla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioPla_KeyPress);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(10, 439);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(84, 35);
            this.Aceptar.TabIndex = 8;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(108, 439);
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
            this.comboBoxPla.Location = new System.Drawing.Point(100, 123);
            this.comboBoxPla.Name = "comboBoxPla";
            this.comboBoxPla.Size = new System.Drawing.Size(148, 21);
            this.comboBoxPla.TabIndex = 10;
            this.comboBoxPla.Text = "Seleccionar tipo de plato";
            this.comboBoxPla.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPla_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripcion";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(254, 34);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(169, 48);
            this.txtDesc.TabIndex = 15;
            // 
            // dgvVajilla
            // 
            this.dgvVajilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVajilla.Location = new System.Drawing.Point(11, 45);
            this.dgvVajilla.Name = "dgvVajilla";
            this.dgvVajilla.Size = new System.Drawing.Size(240, 123);
            this.dgvVajilla.TabIndex = 16;
            this.dgvVajilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Eliminar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // comboVajilla
            // 
            this.comboVajilla.FormattingEnabled = true;
            this.comboVajilla.Location = new System.Drawing.Point(257, 44);
            this.comboVajilla.Name = "comboVajilla";
            this.comboVajilla.Size = new System.Drawing.Size(121, 21);
            this.comboVajilla.TabIndex = 20;
            this.comboVajilla.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // grupVajilla
            // 
            this.grupVajilla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grupVajilla.Controls.Add(this.button2);
            this.grupVajilla.Controls.Add(this.comboVajilla);
            this.grupVajilla.Controls.Add(this.button1);
            this.grupVajilla.Controls.Add(this.dgvVajilla);
            this.grupVajilla.Location = new System.Drawing.Point(10, 245);
            this.grupVajilla.Name = "grupVajilla";
            this.grupVajilla.Size = new System.Drawing.Size(469, 188);
            this.grupVajilla.TabIndex = 21;
            this.grupVajilla.TabStop = false;
            this.grupVajilla.Text = "Vajillas por plato";
            // 
            // BotNew
            // 
            this.BotNew.Location = new System.Drawing.Point(269, 121);
            this.BotNew.Name = "BotNew";
            this.BotNew.Size = new System.Drawing.Size(75, 23);
            this.BotNew.TabIndex = 22;
            this.BotNew.Text = "Nuevo tipo";
            this.BotNew.UseVisualStyleBackColor = true;
            this.BotNew.Click += new System.EventHandler(this.BotNew_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(100, 163);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 24;
            this.txtCant.TextChanged += new System.EventHandler(this.TxtCant_TextChanged);
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCant_KeyPress);
            // 
            // LabError
            // 
            this.LabError.AutoSize = true;
            this.LabError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabError.ForeColor = System.Drawing.Color.Red;
            this.LabError.Location = new System.Drawing.Point(59, 207);
            this.LabError.Name = "LabError";
            this.LabError.Size = new System.Drawing.Size(14, 16);
            this.LabError.TabIndex = 25;
            this.LabError.Text = "*";
            // 
            // AltaPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(515, 486);
            this.ControlBox = false;
            this.Controls.Add(this.LabError);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BotNew);
            this.Controls.Add(this.grupVajilla);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPla);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.txtPrecioPla);
            this.Controls.Add(this.txtNombrePla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaPlato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregado de plato";
            this.Load += new System.EventHandler(this.AltaPlato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVajilla)).EndInit();
            this.grupVajilla.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DataGridView dgvVajilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboVajilla;
        private System.Windows.Forms.GroupBox grupVajilla;
        private System.Windows.Forms.Button BotNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label LabError;
    }
}
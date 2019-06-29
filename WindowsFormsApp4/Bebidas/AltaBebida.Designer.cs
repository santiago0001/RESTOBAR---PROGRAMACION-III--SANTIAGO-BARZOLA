namespace WindowsFormsApp4.Bebidas
{
    partial class AltaBebida
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
            this.labelID = new System.Windows.Forms.Label();
            this.comboMar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GrupReci = new System.Windows.Forms.GroupBox();
            this.radioVaso = new System.Windows.Forms.RadioButton();
            this.radioCopa = new System.Windows.Forms.RadioButton();
            this.ComboMarca = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.ButCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.BotNewMar = new System.Windows.Forms.Button();
            this.GrupReci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(109, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(39, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Nuevo";
            // 
            // comboMar
            // 
            this.comboMar.FormattingEnabled = true;
            this.comboMar.Location = new System.Drawing.Point(111, 40);
            this.comboMar.Name = "comboMar";
            this.comboMar.Size = new System.Drawing.Size(121, 21);
            this.comboMar.TabIndex = 2;
            this.comboMar.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 87);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // GrupReci
            // 
            this.GrupReci.Controls.Add(this.radioVaso);
            this.GrupReci.Controls.Add(this.radioCopa);
            this.GrupReci.Location = new System.Drawing.Point(46, 293);
            this.GrupReci.Name = "GrupReci";
            this.GrupReci.Size = new System.Drawing.Size(102, 69);
            this.GrupReci.TabIndex = 7;
            this.GrupReci.TabStop = false;
            this.GrupReci.Text = "Recipientes";
            // 
            // radioVaso
            // 
            this.radioVaso.AutoSize = true;
            this.radioVaso.Location = new System.Drawing.Point(21, 42);
            this.radioVaso.Name = "radioVaso";
            this.radioVaso.Size = new System.Drawing.Size(49, 17);
            this.radioVaso.TabIndex = 1;
            this.radioVaso.TabStop = true;
            this.radioVaso.Text = "Vaso";
            this.radioVaso.UseVisualStyleBackColor = true;
            // 
            // radioCopa
            // 
            this.radioCopa.AutoSize = true;
            this.radioCopa.Location = new System.Drawing.Point(21, 19);
            this.radioCopa.Name = "radioCopa";
            this.radioCopa.Size = new System.Drawing.Size(50, 17);
            this.radioCopa.TabIndex = 0;
            this.radioCopa.TabStop = true;
            this.radioCopa.Text = "Copa";
            this.radioCopa.UseVisualStyleBackColor = true;
            // 
            // ComboMarca
            // 
            this.ComboMarca.AutoSize = true;
            this.ComboMarca.Location = new System.Drawing.Point(43, 43);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(37, 13);
            this.ComboMarca.TabIndex = 8;
            this.ComboMarca.Text = "Marca";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(112, 131);
            this.txtDescrip.MaxLength = 50;
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(179, 67);
            this.txtDescrip.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(111, 215);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(46, 377);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(81, 30);
            this.butAceptar.TabIndex = 11;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.ButAceptar_Click);
            // 
            // ButCancelar
            // 
            this.ButCancelar.Location = new System.Drawing.Point(175, 377);
            this.ButCancelar.Name = "ButCancelar";
            this.ButCancelar.Size = new System.Drawing.Size(81, 30);
            this.ButCancelar.TabIndex = 12;
            this.ButCancelar.Text = "Cancelar";
            this.ButCancelar.UseVisualStyleBackColor = true;
            this.ButCancelar.Click += new System.EventHandler(this.ButCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(112, 252);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 14;
            this.txtCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCant_KeyPress);
            // 
            // BotNewMar
            // 
            this.BotNewMar.Location = new System.Drawing.Point(242, 38);
            this.BotNewMar.Name = "BotNewMar";
            this.BotNewMar.Size = new System.Drawing.Size(83, 23);
            this.BotNewMar.TabIndex = 15;
            this.BotNewMar.Text = "Nueva marca";
            this.BotNewMar.UseVisualStyleBackColor = true;
            this.BotNewMar.Click += new System.EventHandler(this.BotNewMar_Click);
            // 
            // AltaBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 424);
            this.Controls.Add(this.BotNewMar);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.ComboMarca);
            this.Controls.Add(this.GrupReci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMar);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Name = "AltaBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta bebida";
            this.Load += new System.EventHandler(this.AltaBebida_Load);
            this.GrupReci.ResumeLayout(false);
            this.GrupReci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboMar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GrupReci;
        private System.Windows.Forms.RadioButton radioVaso;
        private System.Windows.Forms.RadioButton radioCopa;
        private System.Windows.Forms.Label ComboMarca;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button ButCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Button BotNewMar;
    }
}
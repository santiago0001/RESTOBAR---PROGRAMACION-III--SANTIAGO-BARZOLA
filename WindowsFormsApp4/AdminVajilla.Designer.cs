namespace WindowsFormsApp4
{
    partial class AdminVajilla
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
            this.AdminVajillaView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.ButBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminVajillaView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminVajillaView
            // 
            this.AdminVajillaView.AllowUserToResizeRows = false;
            this.AdminVajillaView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminVajillaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminVajillaView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminVajillaView.Location = new System.Drawing.Point(39, 59);
            this.AdminVajillaView.MultiSelect = false;
            this.AdminVajillaView.Name = "AdminVajillaView";
            this.AdminVajillaView.ReadOnly = true;
            this.AdminVajillaView.Size = new System.Drawing.Size(318, 350);
            this.AdminVajillaView.TabIndex = 0;
            this.AdminVajillaView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insumos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Vajilla",
            "Bebida",
            "Materia prima",
            "Todos los insumos"});
            this.comboBoxTipo.Location = new System.Drawing.Point(163, 17);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(187, 28);
            this.comboBoxTipo.TabIndex = 5;
            this.comboBoxTipo.Text = "Seleccione tipo";
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ButBuscar
            // 
            this.ButBuscar.Location = new System.Drawing.Point(282, 415);
            this.ButBuscar.Name = "ButBuscar";
            this.ButBuscar.Size = new System.Drawing.Size(75, 23);
            this.ButBuscar.TabIndex = 6;
            this.ButBuscar.Text = "Buscar";
            this.ButBuscar.UseVisualStyleBackColor = true;
            this.ButBuscar.Click += new System.EventHandler(this.ButBuscar_Click);
            // 
            // AdminVajilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 448);
            this.Controls.Add(this.ButBuscar);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminVajillaView);
            this.Name = "AdminVajilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminVajilla";
            this.Load += new System.EventHandler(this.AdminVajilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminVajillaView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButBuscar;
        private System.Windows.Forms.DataGridView AdminVajillaView;
        public System.Windows.Forms.ComboBox comboBoxTipo;
    }
}
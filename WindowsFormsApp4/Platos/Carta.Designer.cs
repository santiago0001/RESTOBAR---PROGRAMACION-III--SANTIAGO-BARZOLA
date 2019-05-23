namespace WindowsFormsApp4
{
    partial class Carta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carta));
            this.dgvCarta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ModificarBoton = new System.Windows.Forms.Button();
            this.buttAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCarta
            // 
            this.dgvCarta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarta.Location = new System.Drawing.Point(45, 51);
            this.dgvCarta.MultiSelect = false;
            this.dgvCarta.Name = "dgvCarta";
            this.dgvCarta.ReadOnly = true;
            this.dgvCarta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarta.Size = new System.Drawing.Size(593, 592);
            this.dgvCarta.TabIndex = 0;
            this.dgvCarta.ReadOnlyChanged += new System.EventHandler(this.dgb_ReadOnlyChanged);
            this.dgvCarta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dgvCarta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarBoton
            // 
            this.ModificarBoton.Location = new System.Drawing.Point(171, 672);
            this.ModificarBoton.Name = "ModificarBoton";
            this.ModificarBoton.Size = new System.Drawing.Size(84, 34);
            this.ModificarBoton.TabIndex = 4;
            this.ModificarBoton.Text = "Modificar";
            this.ModificarBoton.UseVisualStyleBackColor = true;
            this.ModificarBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttAdd
            // 
            this.buttAdd.Location = new System.Drawing.Point(60, 672);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(92, 34);
            this.buttAdd.TabIndex = 5;
            this.buttAdd.Text = "Agregar";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(615, 653);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 721);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.ModificarBoton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCarta);
            this.Name = "Carta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carta";
            this.Deactivate += new System.EventHandler(this.Carta_Deactivate);
            this.Load += new System.EventHandler(this.Carta_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Carta_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ModificarBoton;
        private System.Windows.Forms.Button buttAdd;
        public System.Windows.Forms.DataGridView dgvCarta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
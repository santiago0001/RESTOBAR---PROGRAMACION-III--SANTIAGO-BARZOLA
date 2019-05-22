namespace WindowsFormsApp4.Bebidas
{
    partial class Papelera
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
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.botRestaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPapelera.Location = new System.Drawing.Point(29, 41);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.Size = new System.Drawing.Size(476, 259);
            this.dgvPapelera.TabIndex = 0;
            this.dgvPapelera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // botRestaurar
            // 
            this.botRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botRestaurar.Location = new System.Drawing.Point(29, 306);
            this.botRestaurar.Name = "botRestaurar";
            this.botRestaurar.Size = new System.Drawing.Size(85, 36);
            this.botRestaurar.TabIndex = 1;
            this.botRestaurar.Text = "Restaurar";
            this.botRestaurar.UseVisualStyleBackColor = true;
            this.botRestaurar.Click += new System.EventHandler(this.BotRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminados";
            // 
            // Papelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botRestaurar);
            this.Controls.Add(this.dgvPapelera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Papelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelera";
            this.Load += new System.EventHandler(this.Papelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapelera;
        private System.Windows.Forms.Button botRestaurar;
        private System.Windows.Forms.Label label1;
    }
}
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
            this.dgb = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttAdd = new System.Windows.Forms.Button();
            this.butRefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb
            // 
            this.dgb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgb.Location = new System.Drawing.Point(45, 51);
            this.dgb.MultiSelect = false;
            this.dgb.Name = "dgb";
            this.dgb.ReadOnly = true;
            this.dgb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgb.Size = new System.Drawing.Size(593, 592);
            this.dgb.TabIndex = 0;
            this.dgb.ReadOnlyChanged += new System.EventHandler(this.dgb_ReadOnlyChanged);
            this.dgb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dgb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Seleccione tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 672);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // butRefesh
            // 
            this.butRefesh.Location = new System.Drawing.Point(510, 12);
            this.butRefesh.Name = "butRefesh";
            this.butRefesh.Size = new System.Drawing.Size(75, 23);
            this.butRefesh.TabIndex = 6;
            this.butRefesh.Text = "Refresh";
            this.butRefesh.UseVisualStyleBackColor = true;
            this.butRefesh.Click += new System.EventHandler(this.butRefesh_Click);
            // 
            // Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 721);
            this.Controls.Add(this.butRefesh);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgb);
            this.Name = "Carta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carta";
            this.Deactivate += new System.EventHandler(this.Carta_Deactivate);
            this.Load += new System.EventHandler(this.Carta_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Carta_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttAdd;
        public System.Windows.Forms.DataGridView dgb;
        private System.Windows.Forms.Button butRefesh;
    }
}
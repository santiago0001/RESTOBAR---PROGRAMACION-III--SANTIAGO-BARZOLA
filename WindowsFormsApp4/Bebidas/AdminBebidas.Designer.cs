namespace WindowsFormsApp4.Bebidas
{
    partial class AdminBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBebidas));
            this.DgvBebidas = new System.Windows.Forms.DataGridView();
            this.labelBebidas = new System.Windows.Forms.Label();
            this.botAdd = new System.Windows.Forms.Button();
            this.BotMod = new System.Windows.Forms.Button();
            this.BotElim = new System.Windows.Forms.Button();
            this.BotBus = new System.Windows.Forms.Button();
            this.DeletePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePic)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBebidas
            // 
            this.DgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvBebidas.Location = new System.Drawing.Point(37, 67);
            this.DgvBebidas.Name = "DgvBebidas";
            this.DgvBebidas.ReadOnly = true;
            this.DgvBebidas.Size = new System.Drawing.Size(637, 290);
            this.DgvBebidas.TabIndex = 0;
            this.DgvBebidas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBebidas_CellContentClick);
            // 
            // labelBebidas
            // 
            this.labelBebidas.AutoSize = true;
            this.labelBebidas.Location = new System.Drawing.Point(37, 24);
            this.labelBebidas.Name = "labelBebidas";
            this.labelBebidas.Size = new System.Drawing.Size(45, 13);
            this.labelBebidas.TabIndex = 1;
            this.labelBebidas.Text = "Bebidas";
            // 
            // botAdd
            // 
            this.botAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botAdd.Location = new System.Drawing.Point(37, 376);
            this.botAdd.Name = "botAdd";
            this.botAdd.Size = new System.Drawing.Size(74, 32);
            this.botAdd.TabIndex = 2;
            this.botAdd.Text = "Agregar";
            this.botAdd.UseVisualStyleBackColor = true;
            this.botAdd.Click += new System.EventHandler(this.BotAdd_Click);
            // 
            // BotMod
            // 
            this.BotMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotMod.Location = new System.Drawing.Point(117, 376);
            this.BotMod.Name = "BotMod";
            this.BotMod.Size = new System.Drawing.Size(74, 32);
            this.BotMod.TabIndex = 3;
            this.BotMod.Text = "Modificar";
            this.BotMod.UseVisualStyleBackColor = true;
            this.BotMod.Click += new System.EventHandler(this.BotMod_Click);
            // 
            // BotElim
            // 
            this.BotElim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotElim.Location = new System.Drawing.Point(197, 376);
            this.BotElim.Name = "BotElim";
            this.BotElim.Size = new System.Drawing.Size(74, 32);
            this.BotElim.TabIndex = 4;
            this.BotElim.Text = "Eliminar";
            this.BotElim.UseVisualStyleBackColor = true;
            this.BotElim.Click += new System.EventHandler(this.BotElim_Click);
            // 
            // BotBus
            // 
            this.BotBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotBus.Location = new System.Drawing.Point(277, 376);
            this.BotBus.Name = "BotBus";
            this.BotBus.Size = new System.Drawing.Size(74, 32);
            this.BotBus.TabIndex = 5;
            this.BotBus.Text = "Buscar";
            this.BotBus.UseVisualStyleBackColor = true;
            this.BotBus.Click += new System.EventHandler(this.BotBus_Click);
            // 
            // DeletePic
            // 
            this.DeletePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePic.Image = ((System.Drawing.Image)(resources.GetObject("DeletePic.Image")));
            this.DeletePic.Location = new System.Drawing.Point(628, 363);
            this.DeletePic.Name = "DeletePic";
            this.DeletePic.Size = new System.Drawing.Size(45, 45);
            this.DeletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletePic.TabIndex = 6;
            this.DeletePic.TabStop = false;
            this.DeletePic.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AdminBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(685, 420);
            this.Controls.Add(this.DeletePic);
            this.Controls.Add(this.BotBus);
            this.Controls.Add(this.BotElim);
            this.Controls.Add(this.BotMod);
            this.Controls.Add(this.botAdd);
            this.Controls.Add(this.labelBebidas);
            this.Controls.Add(this.DgvBebidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminBebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBebidas";
            this.Load += new System.EventHandler(this.AdminBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBebidas;
        private System.Windows.Forms.Label labelBebidas;
        private System.Windows.Forms.Button botAdd;
        private System.Windows.Forms.Button BotMod;
        private System.Windows.Forms.Button BotElim;
        private System.Windows.Forms.Button BotBus;
        private System.Windows.Forms.PictureBox DeletePic;
    }
}
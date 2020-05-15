namespace Billar
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.btnMostrarCli = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarCli
            // 
            this.btnMostrarCli.Location = new System.Drawing.Point(411, 112);
            this.btnMostrarCli.Name = "btnMostrarCli";
            this.btnMostrarCli.Size = new System.Drawing.Size(117, 23);
            this.btnMostrarCli.TabIndex = 26;
            this.btnMostrarCli.Text = "Mostrar";
            this.btnMostrarCli.UseVisualStyleBackColor = true;
            this.btnMostrarCli.Click += new System.EventHandler(this.btnMostrarCli_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.Location = new System.Drawing.Point(565, 112);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(117, 23);
            this.btnModificarCli.TabIndex = 25;
            this.btnModificarCli.Text = "Modificar";
            this.btnModificarCli.UseVisualStyleBackColor = true;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(260, 112);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(117, 23);
            this.btnAgregarCli.TabIndex = 24;
            this.btnAgregarCli.Text = "Agregar";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(260, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(573, 293);
            this.dataGridView1.TabIndex = 23;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(716, 112);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(117, 23);
            this.btEliminar.TabIndex = 27;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cliente";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(565, 454);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 50);
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(452, 454);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(56, 50);
            this.pictureBox11.TabIndex = 44;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Billar.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 532);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btnMostrarCli);
            this.Controls.Add(this.btnModificarCli);
            this.Controls.Add(this.btnAgregarCli);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCli;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}
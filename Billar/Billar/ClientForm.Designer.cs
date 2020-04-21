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
            this.btnMostrarCli = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btRecargar = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarCli
            // 
            this.btnMostrarCli.Location = new System.Drawing.Point(315, 180);
            this.btnMostrarCli.Name = "btnMostrarCli";
            this.btnMostrarCli.Size = new System.Drawing.Size(117, 23);
            this.btnMostrarCli.TabIndex = 26;
            this.btnMostrarCli.Text = "Mostrar";
            this.btnMostrarCli.UseVisualStyleBackColor = true;
            this.btnMostrarCli.Click += new System.EventHandler(this.btnMostrarCli_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.Location = new System.Drawing.Point(461, 180);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(117, 23);
            this.btnModificarCli.TabIndex = 25;
            this.btnModificarCli.Text = "Modificar";
            this.btnModificarCli.UseVisualStyleBackColor = true;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(155, 180);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(117, 23);
            this.btnAgregarCli.TabIndex = 24;
            this.btnAgregarCli.Text = "Agregar";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(155, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(573, 293);
            this.dataGridView1.TabIndex = 23;
            // 
            // Titulo
            // 
            this.Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Titulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Titulo.Location = new System.Drawing.Point(335, 38);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(201, 70);
            this.Titulo.TabIndex = 21;
            this.Titulo.Text = "Cliente";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox5.Location = new System.Drawing.Point(144, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(596, 96);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(611, 180);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(117, 23);
            this.btEliminar.TabIndex = 27;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btRecargar
            // 
            this.btRecargar.Location = new System.Drawing.Point(212, 131);
            this.btRecargar.Name = "btRecargar";
            this.btRecargar.Size = new System.Drawing.Size(95, 24);
            this.btRecargar.TabIndex = 28;
            this.btRecargar.Text = "Recargar";
            this.btRecargar.UseVisualStyleBackColor = true;
            this.btRecargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(461, 131);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(117, 23);
            this.btMenu.TabIndex = 29;
            this.btMenu.Text = "Menu Principal";
            this.btMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox4.Location = new System.Drawing.Point(144, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(596, 434);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Billar.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btRecargar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btnMostrarCli);
            this.Controls.Add(this.btnModificarCli);
            this.Controls.Add(this.btnAgregarCli);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarCli;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btRecargar;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
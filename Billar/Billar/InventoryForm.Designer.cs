namespace Billar
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(222, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 313);
            this.dataGridView1.TabIndex = 47;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(222, 99);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(111, 26);
            this.btAgregar.TabIndex = 48;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(402, 99);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(116, 26);
            this.btMostrar.TabIndex = 49;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(569, 99);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(116, 26);
            this.btModificar.TabIndex = 50;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(746, 99);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(112, 26);
            this.btEliminar.TabIndex = 51;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 54;
            this.label1.Text = "Inventario";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(575, 479);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(58, 50);
            this.pictureBox9.TabIndex = 56;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(462, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 539);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
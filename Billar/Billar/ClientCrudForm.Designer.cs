namespace Billar
{
    partial class ClientCrudForm
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(411, 293);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(91, 21);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "button1";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(534, 293);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(91, 21);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "button2";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbTitulo.Location = new System.Drawing.Point(296, 32);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(96, 37);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Titulo";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(109, 142);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(145, 20);
            this.tbCode.TabIndex = 3;
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(109, 212);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(145, 20);
            this.tbHours.TabIndex = 4;
            this.tbHours.Text = "0";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(398, 142);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 20);
            this.tbName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horas";
            // 
            // ClientCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAgregar);
            this.Name = "ClientCrudForm";
            this.Text = "ClientCrudForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
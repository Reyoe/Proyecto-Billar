namespace Billar
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            this.labelCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDiscounts = new System.Windows.Forms.GroupBox();
            this.buttonApplyDiscount = new System.Windows.Forms.Button();
            this.textBoxDiscountIdDisc = new System.Windows.Forms.TextBox();
            this.textBoxDiscountUserClient = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMessages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxModTables = new System.Windows.Forms.GroupBox();
            this.buttonTablesRegistres = new System.Windows.Forms.Button();
            this.buttonPopTable = new System.Windows.Forms.Button();
            this.buttonPushTable = new System.Windows.Forms.Button();
            this.labelNumberTable = new System.Windows.Forms.Label();
            this.groupBoxRequeriments = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.checkBoxClient = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTableOnGame = new System.Windows.Forms.Label();
            this.labelTableAvailable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxNotAvailable = new System.Windows.Forms.PictureBox();
            this.pictureBoxAvailable = new System.Windows.Forms.PictureBox();
            this.buttonLeftTables = new System.Windows.Forms.Button();
            this.button2RightTables = new System.Windows.Forms.Button();
            this.groupBoxDiscounts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxModTables.SuspendLayout();
            this.groupBoxRequeriments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCost
            // 
            this.labelCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelCost.Location = new System.Drawing.Point(812, 355);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(225, 23);
            this.labelCost.TabIndex = 53;
            this.labelCost.Text = "0.00";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(742, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Coste:";
            // 
            // groupBoxDiscounts
            // 
            this.groupBoxDiscounts.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDiscounts.Controls.Add(this.buttonApplyDiscount);
            this.groupBoxDiscounts.Controls.Add(this.textBoxDiscountIdDisc);
            this.groupBoxDiscounts.Controls.Add(this.textBoxDiscountUserClient);
            this.groupBoxDiscounts.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxDiscounts.Location = new System.Drawing.Point(758, 33);
            this.groupBoxDiscounts.Name = "groupBoxDiscounts";
            this.groupBoxDiscounts.Size = new System.Drawing.Size(192, 150);
            this.groupBoxDiscounts.TabIndex = 49;
            this.groupBoxDiscounts.TabStop = false;
            this.groupBoxDiscounts.Text = "Aplicación de Descuento";
            // 
            // buttonApplyDiscount
            // 
            this.buttonApplyDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonApplyDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.buttonApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApplyDiscount.FlatAppearance.BorderSize = 0;
            this.buttonApplyDiscount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonApplyDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyDiscount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyDiscount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonApplyDiscount.Location = new System.Drawing.Point(21, 95);
            this.buttonApplyDiscount.Name = "buttonApplyDiscount";
            this.buttonApplyDiscount.Size = new System.Drawing.Size(150, 33);
            this.buttonApplyDiscount.TabIndex = 8;
            this.buttonApplyDiscount.Text = "Aplicar Descuento";
            this.buttonApplyDiscount.UseVisualStyleBackColor = false;
            // 
            // textBoxDiscountIdDisc
            // 
            this.textBoxDiscountIdDisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxDiscountIdDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscountIdDisc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscountIdDisc.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDiscountIdDisc.Location = new System.Drawing.Point(6, 54);
            this.textBoxDiscountIdDisc.Name = "textBoxDiscountIdDisc";
            this.textBoxDiscountIdDisc.Size = new System.Drawing.Size(180, 23);
            this.textBoxDiscountIdDisc.TabIndex = 7;
            this.textBoxDiscountIdDisc.Text = "ID DESCUENTO";
            // 
            // textBoxDiscountUserClient
            // 
            this.textBoxDiscountUserClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxDiscountUserClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscountUserClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscountUserClient.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDiscountUserClient.Location = new System.Drawing.Point(6, 25);
            this.textBoxDiscountUserClient.Name = "textBoxDiscountUserClient";
            this.textBoxDiscountUserClient.Size = new System.Drawing.Size(180, 23);
            this.textBoxDiscountUserClient.TabIndex = 6;
            this.textBoxDiscountUserClient.Text = "CLAVE DEL CLIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.labelMessages);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 32);
            this.panel1.TabIndex = 48;
            // 
            // labelMessages
            // 
            this.labelMessages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessages.ForeColor = System.Drawing.Color.Orange;
            this.labelMessages.Location = new System.Drawing.Point(125, 9);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(863, 23);
            this.labelMessages.TabIndex = 1;
            this.labelMessages.Text = "ERROR: ";
            this.labelMessages.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Caja de mensajes:";
            // 
            // groupBoxModTables
            // 
            this.groupBoxModTables.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxModTables.Controls.Add(this.buttonTablesRegistres);
            this.groupBoxModTables.Controls.Add(this.buttonPopTable);
            this.groupBoxModTables.Controls.Add(this.buttonPushTable);
            this.groupBoxModTables.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxModTables.Location = new System.Drawing.Point(12, 33);
            this.groupBoxModTables.Name = "groupBoxModTables";
            this.groupBoxModTables.Size = new System.Drawing.Size(200, 156);
            this.groupBoxModTables.TabIndex = 47;
            this.groupBoxModTables.TabStop = false;
            this.groupBoxModTables.Text = "Manejo de mesas.";
            this.groupBoxModTables.Visible = false;
            // 
            // buttonTablesRegistres
            // 
            this.buttonTablesRegistres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTablesRegistres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.buttonTablesRegistres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTablesRegistres.FlatAppearance.BorderSize = 0;
            this.buttonTablesRegistres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonTablesRegistres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTablesRegistres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTablesRegistres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTablesRegistres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonTablesRegistres.Location = new System.Drawing.Point(24, 117);
            this.buttonTablesRegistres.Name = "buttonTablesRegistres";
            this.buttonTablesRegistres.Size = new System.Drawing.Size(150, 33);
            this.buttonTablesRegistres.TabIndex = 3;
            this.buttonTablesRegistres.Text = "Registros de Mesas";
            this.buttonTablesRegistres.UseVisualStyleBackColor = false;
            // 
            // buttonPopTable
            // 
            this.buttonPopTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPopTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.buttonPopTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopTable.FlatAppearance.BorderSize = 0;
            this.buttonPopTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonPopTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPopTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPopTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPopTable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPopTable.Location = new System.Drawing.Point(24, 58);
            this.buttonPopTable.Name = "buttonPopTable";
            this.buttonPopTable.Size = new System.Drawing.Size(150, 33);
            this.buttonPopTable.TabIndex = 2;
            this.buttonPopTable.Text = "Eliminar mesa";
            this.buttonPopTable.UseVisualStyleBackColor = false;
            // 
            // buttonPushTable
            // 
            this.buttonPushTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPushTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.buttonPushTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPushTable.FlatAppearance.BorderSize = 0;
            this.buttonPushTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonPushTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPushTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPushTable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPushTable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPushTable.Location = new System.Drawing.Point(24, 19);
            this.buttonPushTable.Name = "buttonPushTable";
            this.buttonPushTable.Size = new System.Drawing.Size(150, 33);
            this.buttonPushTable.TabIndex = 1;
            this.buttonPushTable.Text = "Agregar mesa";
            this.buttonPushTable.UseVisualStyleBackColor = false;
            // 
            // labelNumberTable
            // 
            this.labelNumberTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumberTable.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNumberTable.Location = new System.Drawing.Point(351, 33);
            this.labelNumberTable.Name = "labelNumberTable";
            this.labelNumberTable.Size = new System.Drawing.Size(272, 23);
            this.labelNumberTable.TabIndex = 37;
            this.labelNumberTable.Text = "MESA";
            this.labelNumberTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRequeriments
            // 
            this.groupBoxRequeriments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxRequeriments.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRequeriments.Controls.Add(this.label7);
            this.groupBoxRequeriments.Controls.Add(this.comboBoxMethod);
            this.groupBoxRequeriments.Controls.Add(this.textBoxClient);
            this.groupBoxRequeriments.Controls.Add(this.checkBoxClient);
            this.groupBoxRequeriments.Controls.Add(this.label5);
            this.groupBoxRequeriments.Controls.Add(this.label6);
            this.groupBoxRequeriments.Controls.Add(this.numericUpDownHours);
            this.groupBoxRequeriments.Controls.Add(this.numericUpDownMinutes);
            this.groupBoxRequeriments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRequeriments.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxRequeriments.Location = new System.Drawing.Point(164, 395);
            this.groupBoxRequeriments.Name = "groupBoxRequeriments";
            this.groupBoxRequeriments.Size = new System.Drawing.Size(786, 89);
            this.groupBoxRequeriments.TabIndex = 46;
            this.groupBoxRequeriments.TabStop = false;
            this.groupBoxRequeriments.Text = "Datos requeridos:";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(559, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "METODO DE PAGO";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMethod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMethod.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA DE CREDITO"});
            this.comboBoxMethod.Location = new System.Drawing.Point(559, 43);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(218, 25);
            this.comboBoxMethod.TabIndex = 21;
            // 
            // textBoxClient
            // 
            this.textBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClient.Enabled = false;
            this.textBoxClient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxClient.Location = new System.Drawing.Point(318, 46);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(226, 23);
            this.textBoxClient.TabIndex = 20;
            this.textBoxClient.Text = "CLAVE DEL CLIENTE";
            // 
            // checkBoxClient
            // 
            this.checkBoxClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxClient.Location = new System.Drawing.Point(318, 25);
            this.checkBoxClient.Name = "checkBoxClient";
            this.checkBoxClient.Size = new System.Drawing.Size(153, 24);
            this.checkBoxClient.TabIndex = 19;
            this.checkBoxClient.Text = "Cliente Registrado:";
            this.checkBoxClient.UseVisualStyleBackColor = true;
            this.checkBoxClient.CheckedChanged += new System.EventHandler(this.checkBoxClient_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiempo requerido:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(147, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Horas:             Minutos:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.numericUpDownHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDownHours.Location = new System.Drawing.Point(147, 48);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownHours.TabIndex = 15;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.numericUpDownMinutes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numericUpDownMinutes.Location = new System.Drawing.Point(229, 48);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(49, 21);
            this.numericUpDownMinutes.TabIndex = 16;
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeRemaining.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeRemaining.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTimeRemaining.Location = new System.Drawing.Point(641, 355);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(81, 23);
            this.labelTimeRemaining.TabIndex = 45;
            this.labelTimeRemaining.Text = "00:00:00";
            this.labelTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(467, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tiempo restante:";
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeElapsed.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTimeElapsed.Location = new System.Drawing.Point(382, 355);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(86, 23);
            this.labelTimeElapsed.TabIndex = 42;
            this.labelTimeElapsed.Text = "00:00:00";
            this.labelTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(183, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tiempo transcurrido:";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.buttonFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFinish.FlatAppearance.BorderSize = 0;
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFinish.Location = new System.Drawing.Point(5, 446);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(143, 38);
            this.buttonFinish.TabIndex = 38;
            this.buttonFinish.Text = "Finalizar";
            this.buttonFinish.UseVisualStyleBackColor = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(5, 402);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(143, 38);
            this.buttonStart.TabIndex = 36;
            this.buttonStart.Text = "Iniciar";
            this.buttonStart.UseVisualStyleBackColor = false;
            // 
            // labelTableOnGame
            // 
            this.labelTableOnGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTableOnGame.BackColor = System.Drawing.Color.Transparent;
            this.labelTableOnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableOnGame.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTableOnGame.Location = new System.Drawing.Point(84, 356);
            this.labelTableOnGame.Name = "labelTableOnGame";
            this.labelTableOnGame.Size = new System.Drawing.Size(93, 23);
            this.labelTableOnGame.TabIndex = 41;
            this.labelTableOnGame.Text = "En juego";
            // 
            // labelTableAvailable
            // 
            this.labelTableAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTableAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableAvailable.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTableAvailable.Location = new System.Drawing.Point(84, 356);
            this.labelTableAvailable.Name = "labelTableAvailable";
            this.labelTableAvailable.Size = new System.Drawing.Size(93, 23);
            this.labelTableAvailable.TabIndex = 40;
            this.labelTableAvailable.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(5, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Estatus:";
            // 
            // pictureBoxNotAvailable
            // 
            this.pictureBoxNotAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNotAvailable.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNotAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotAvailable.Image")));
            this.pictureBoxNotAvailable.Location = new System.Drawing.Point(290, 59);
            this.pictureBoxNotAvailable.Name = "pictureBoxNotAvailable";
            this.pictureBoxNotAvailable.Size = new System.Drawing.Size(395, 277);
            this.pictureBoxNotAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNotAvailable.TabIndex = 35;
            this.pictureBoxNotAvailable.TabStop = false;
            // 
            // pictureBoxAvailable
            // 
            this.pictureBoxAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvailable.Image")));
            this.pictureBoxAvailable.Location = new System.Drawing.Point(289, 59);
            this.pictureBoxAvailable.Name = "pictureBoxAvailable";
            this.pictureBoxAvailable.Size = new System.Drawing.Size(395, 277);
            this.pictureBoxAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvailable.TabIndex = 34;
            this.pictureBoxAvailable.TabStop = false;
            // 
            // buttonLeftTables
            // 
            this.buttonLeftTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLeftTables.BackColor = System.Drawing.Color.Transparent;
            this.buttonLeftTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeftTables.BackgroundImage")));
            this.buttonLeftTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeftTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeftTables.FlatAppearance.BorderSize = 0;
            this.buttonLeftTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLeftTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLeftTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftTables.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeftTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.buttonLeftTables.Location = new System.Drawing.Point(132, 140);
            this.buttonLeftTables.Name = "buttonLeftTables";
            this.buttonLeftTables.Size = new System.Drawing.Size(151, 131);
            this.buttonLeftTables.TabIndex = 50;
            this.buttonLeftTables.UseVisualStyleBackColor = false;
            // 
            // button2RightTables
            // 
            this.button2RightTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2RightTables.BackColor = System.Drawing.Color.Transparent;
            this.button2RightTables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2RightTables.BackgroundImage")));
            this.button2RightTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2RightTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2RightTables.FlatAppearance.BorderSize = 0;
            this.button2RightTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button2RightTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2RightTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2RightTables.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2RightTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.button2RightTables.Location = new System.Drawing.Point(690, 140);
            this.button2RightTables.Name = "button2RightTables";
            this.button2RightTables.Size = new System.Drawing.Size(151, 131);
            this.button2RightTables.TabIndex = 51;
            this.button2RightTables.UseVisualStyleBackColor = false;
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Billar.Properties.Resources.BG1;
            this.ClientSize = new System.Drawing.Size(1020, 532);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDiscounts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxModTables);
            this.Controls.Add(this.labelNumberTable);
            this.Controls.Add(this.groupBoxRequeriments);
            this.Controls.Add(this.labelTimeRemaining);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTableOnGame);
            this.Controls.Add(this.labelTableAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxNotAvailable);
            this.Controls.Add(this.pictureBoxAvailable);
            this.Controls.Add(this.buttonLeftTables);
            this.Controls.Add(this.button2RightTables);
            this.Name = "TableForm";
            this.Text = "Mesas";
            this.groupBoxDiscounts.ResumeLayout(false);
            this.groupBoxDiscounts.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxModTables.ResumeLayout(false);
            this.groupBoxRequeriments.ResumeLayout(false);
            this.groupBoxRequeriments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDiscounts;
        private System.Windows.Forms.Button buttonApplyDiscount;
        private System.Windows.Forms.TextBox textBoxDiscountIdDisc;
        private System.Windows.Forms.TextBox textBoxDiscountUserClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxModTables;
        private System.Windows.Forms.Button buttonTablesRegistres;
        private System.Windows.Forms.Button buttonPopTable;
        private System.Windows.Forms.Button buttonPushTable;
        private System.Windows.Forms.Label labelNumberTable;
        private System.Windows.Forms.GroupBox groupBoxRequeriments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.CheckBox checkBoxClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTableOnGame;
        private System.Windows.Forms.Label labelTableAvailable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxNotAvailable;
        private System.Windows.Forms.PictureBox pictureBoxAvailable;
        private System.Windows.Forms.Button buttonLeftTables;
        private System.Windows.Forms.Button button2RightTables;
    }
}
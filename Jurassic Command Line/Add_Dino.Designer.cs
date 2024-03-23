namespace Jurassic_Command_Line
{
    partial class AddDino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDino));
            this.label2 = new System.Windows.Forms.Label();
            this.TXTespecie = new System.Windows.Forms.TextBox();
            this.TXTflia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cantidad_Num = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBB_Dieta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTera = new System.Windows.Forms.TextBox();
            this.Sec_Num = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_selec_img = new System.Windows.Forms.Button();
            this.Alto_Num = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Largo_Num = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_guardar_tdo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CMBB_ISLAND = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sec_Num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alto_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largo_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Especie:";
            // 
            // TXTespecie
            // 
            this.TXTespecie.Location = new System.Drawing.Point(110, 315);
            this.TXTespecie.Name = "TXTespecie";
            this.TXTespecie.Size = new System.Drawing.Size(181, 20);
            this.TXTespecie.TabIndex = 5;
            // 
            // TXTflia
            // 
            this.TXTflia.Location = new System.Drawing.Point(110, 356);
            this.TXTflia.Name = "TXTflia";
            this.TXTflia.Size = new System.Drawing.Size(181, 20);
            this.TXTflia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Familia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad:";
            // 
            // Cantidad_Num
            // 
            this.Cantidad_Num.Location = new System.Drawing.Point(110, 392);
            this.Cantidad_Num.Name = "Cantidad_Num";
            this.Cantidad_Num.Size = new System.Drawing.Size(93, 20);
            this.Cantidad_Num.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dieta:";
            // 
            // CMBB_Dieta
            // 
            this.CMBB_Dieta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBB_Dieta.FormattingEnabled = true;
            this.CMBB_Dieta.Items.AddRange(new object[] {
            "Carnívoro",
            "Herbívoro",
            "Omnívoro",
            "Piscívoro"});
            this.CMBB_Dieta.Location = new System.Drawing.Point(110, 427);
            this.CMBB_Dieta.Name = "CMBB_Dieta";
            this.CMBB_Dieta.Size = new System.Drawing.Size(121, 21);
            this.CMBB_Dieta.Sorted = true;
            this.CMBB_Dieta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Era:";
            // 
            // TXTera
            // 
            this.TXTera.Location = new System.Drawing.Point(110, 463);
            this.TXTera.Name = "TXTera";
            this.TXTera.Size = new System.Drawing.Size(181, 20);
            this.TXTera.TabIndex = 13;
            // 
            // Sec_Num
            // 
            this.Sec_Num.Location = new System.Drawing.Point(157, 499);
            this.Sec_Num.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Sec_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sec_Num.Name = "Sec_Num";
            this.Sec_Num.Size = new System.Drawing.Size(93, 20);
            this.Sec_Num.TabIndex = 15;
            this.Sec_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "N. Seguridad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btn_selec_img);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 296);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección De Imagen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "IMAGEN:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_selec_img
            // 
            this.btn_selec_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selec_img.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_selec_img.Location = new System.Drawing.Point(316, 84);
            this.btn_selec_img.Name = "btn_selec_img";
            this.btn_selec_img.Size = new System.Drawing.Size(116, 36);
            this.btn_selec_img.TabIndex = 18;
            this.btn_selec_img.Text = "Seleccionar";
            this.btn_selec_img.UseVisualStyleBackColor = true;
            this.btn_selec_img.Click += new System.EventHandler(this.btn_selec_img_Click);
            // 
            // Alto_Num
            // 
            this.Alto_Num.DecimalPlaces = 2;
            this.Alto_Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Alto_Num.Location = new System.Drawing.Point(371, 317);
            this.Alto_Num.Name = "Alto_Num";
            this.Alto_Num.Size = new System.Drawing.Size(93, 20);
            this.Alto_Num.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(297, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Alto:";
            // 
            // Largo_Num
            // 
            this.Largo_Num.DecimalPlaces = 2;
            this.Largo_Num.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Largo_Num.Location = new System.Drawing.Point(371, 354);
            this.Largo_Num.Name = "Largo_Num";
            this.Largo_Num.Size = new System.Drawing.Size(93, 20);
            this.Largo_Num.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(296, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Largo:";
            // 
            // btn_guardar_tdo
            // 
            this.btn_guardar_tdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_tdo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_guardar_tdo.Location = new System.Drawing.Point(335, 495);
            this.btn_guardar_tdo.Name = "btn_guardar_tdo";
            this.btn_guardar_tdo.Size = new System.Drawing.Size(138, 36);
            this.btn_guardar_tdo.TabIndex = 21;
            this.btn_guardar_tdo.Text = "Guardar Todo";
            this.btn_guardar_tdo.UseVisualStyleBackColor = true;
            this.btn_guardar_tdo.Click += new System.EventHandler(this.btn_guardar_tdo_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(479, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 456);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(475, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Información Adicional";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(274, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 36);
            this.button1.TabIndex = 24;
            this.button1.Text = "Selec. Sonido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::Jurassic_Command_Line.Properties.Resources.reproducir_pausar;
            this.button2.Location = new System.Drawing.Point(434, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 26);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CMBB_ISLAND
            // 
            this.CMBB_ISLAND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBB_ISLAND.FormattingEnabled = true;
            this.CMBB_ISLAND.Items.AddRange(new object[] {
            "Nublar",
            "Sorna"});
            this.CMBB_ISLAND.Location = new System.Drawing.Point(352, 435);
            this.CMBB_ISLAND.Name = "CMBB_ISLAND";
            this.CMBB_ISLAND.Size = new System.Drawing.Size(121, 21);
            this.CMBB_ISLAND.Sorted = true;
            this.CMBB_ISLAND.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(296, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Isla:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(430, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(406, 26);
            this.label12.TabIndex = 21;
            this.label12.Text = "Debe de completar todos los campos";
            this.label12.Visible = false;
            // 
            // AddDino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(839, 542);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CMBB_ISLAND);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_guardar_tdo);
            this.Controls.Add(this.Largo_Num);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Alto_Num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Sec_Num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXTera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMBB_Dieta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cantidad_Num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTflia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTespecie);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Dinosaurio";
            this.Load += new System.EventHandler(this.Add_Dino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sec_Num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alto_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largo_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTespecie;
        private System.Windows.Forms.TextBox TXTflia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Cantidad_Num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBB_Dieta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTera;
        private System.Windows.Forms.NumericUpDown Sec_Num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_selec_img;
        private System.Windows.Forms.NumericUpDown Alto_Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Largo_Num;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_guardar_tdo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CMBB_ISLAND;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
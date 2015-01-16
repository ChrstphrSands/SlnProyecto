namespace SlnProyecto
{
    partial class FrmAdmin
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
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Agregar_imagen = new System.Windows.Forms.Button();
            this.txt_Artista = new System.Windows.Forms.TextBox();
            this.txt_Nombre_Cancion = new System.Windows.Forms.TextBox();
            this.txt_Album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Duracion = new System.Windows.Forms.TextBox();
            this.cbo_Genero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Nuevo_Album = new System.Windows.Forms.Button();
            this.gb_Agregar = new System.Windows.Forms.GroupBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Id_Album = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(235, 108);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(24, 155);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(105, 155);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 2;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(198, 155);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Agregar_imagen
            // 
            this.btn_Agregar_imagen.Location = new System.Drawing.Point(561, 80);
            this.btn_Agregar_imagen.Name = "btn_Agregar_imagen";
            this.btn_Agregar_imagen.Size = new System.Drawing.Size(158, 23);
            this.btn_Agregar_imagen.TabIndex = 4;
            this.btn_Agregar_imagen.Text = "Agregar Imagen";
            this.btn_Agregar_imagen.UseVisualStyleBackColor = true;
            // 
            // txt_Artista
            // 
            this.txt_Artista.Location = new System.Drawing.Point(72, 59);
            this.txt_Artista.Name = "txt_Artista";
            this.txt_Artista.Size = new System.Drawing.Size(140, 20);
            this.txt_Artista.TabIndex = 9;
            // 
            // txt_Nombre_Cancion
            // 
            this.txt_Nombre_Cancion.Location = new System.Drawing.Point(633, 492);
            this.txt_Nombre_Cancion.Name = "txt_Nombre_Cancion";
            this.txt_Nombre_Cancion.Size = new System.Drawing.Size(140, 20);
            this.txt_Nombre_Cancion.TabIndex = 10;
            // 
            // txt_Album
            // 
            this.txt_Album.Location = new System.Drawing.Point(302, 23);
            this.txt_Album.Name = "txt_Album";
            this.txt_Album.Size = new System.Drawing.Size(140, 20);
            this.txt_Album.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre De Cancion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Album";
            // 
            // txt_Duracion
            // 
            this.txt_Duracion.Location = new System.Drawing.Point(302, 52);
            this.txt_Duracion.Name = "txt_Duracion";
            this.txt_Duracion.Size = new System.Drawing.Size(140, 20);
            this.txt_Duracion.TabIndex = 18;
            // 
            // cbo_Genero
            // 
            this.cbo_Genero.FormattingEnabled = true;
            this.cbo_Genero.Location = new System.Drawing.Point(72, 111);
            this.cbo_Genero.Name = "cbo_Genero";
            this.cbo_Genero.Size = new System.Drawing.Size(121, 21);
            this.cbo_Genero.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Genero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(642, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 69);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 279);
            this.dataGridView1.TabIndex = 22;
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(72, 85);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(140, 20);
            this.txt_Stock.TabIndex = 23;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(335, 78);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(78, 20);
            this.txt_Precio.TabIndex = 24;
            this.txt_Precio.TextChanged += new System.EventHandler(this.txt_Precio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "StocK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "$.";
            // 
            // btn_Nuevo_Album
            // 
            this.btn_Nuevo_Album.Location = new System.Drawing.Point(12, 12);
            this.btn_Nuevo_Album.Name = "btn_Nuevo_Album";
            this.btn_Nuevo_Album.Size = new System.Drawing.Size(101, 66);
            this.btn_Nuevo_Album.TabIndex = 28;
            this.btn_Nuevo_Album.Text = " NUEVO ALBUM";
            this.btn_Nuevo_Album.UseVisualStyleBackColor = true;
            this.btn_Nuevo_Album.Click += new System.EventHandler(this.btn_Nuevo_Album_Click);
            // 
            // gb_Agregar
            // 
            this.gb_Agregar.Controls.Add(this.label11);
            this.gb_Agregar.Controls.Add(this.numericUpDown1);
            this.gb_Agregar.Controls.Add(this.txt_Id_Album);
            this.gb_Agregar.Controls.Add(this.label10);
            this.gb_Agregar.Controls.Add(this.label1);
            this.gb_Agregar.Controls.Add(this.txt_Artista);
            this.gb_Agregar.Controls.Add(this.label9);
            this.gb_Agregar.Controls.Add(this.pictureBox1);
            this.gb_Agregar.Controls.Add(this.txt_Album);
            this.gb_Agregar.Controls.Add(this.label8);
            this.gb_Agregar.Controls.Add(this.btn_Agregar_imagen);
            this.gb_Agregar.Controls.Add(this.label4);
            this.gb_Agregar.Controls.Add(this.label7);
            this.gb_Agregar.Controls.Add(this.btn_Agregar);
            this.gb_Agregar.Controls.Add(this.label5);
            this.gb_Agregar.Controls.Add(this.txt_Precio);
            this.gb_Agregar.Controls.Add(this.txt_Duracion);
            this.gb_Agregar.Controls.Add(this.txt_Stock);
            this.gb_Agregar.Controls.Add(this.cbo_Genero);
            this.gb_Agregar.Controls.Add(this.label6);
            this.gb_Agregar.Location = new System.Drawing.Point(152, 12);
            this.gb_Agregar.Name = "gb_Agregar";
            this.gb_Agregar.Size = new System.Drawing.Size(725, 137);
            this.gb_Agregar.TabIndex = 29;
            this.gb_Agregar.TabStop = false;
            this.gb_Agregar.Text = "TAKNAJUMP";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(279, 158);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_Buscar.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID Album";
            // 
            // txt_Id_Album
            // 
            this.txt_Id_Album.Location = new System.Drawing.Point(72, 30);
            this.txt_Id_Album.Name = "txt_Id_Album";
            this.txt_Id_Album.Size = new System.Drawing.Size(140, 20);
            this.txt_Id_Album.TabIndex = 29;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(501, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "nº mp3";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 524);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.gb_Agregar);
            this.Controls.Add(this.btn_Nuevo_Album);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre_Cancion);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Modificar);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Agregar.ResumeLayout(false);
            this.gb_Agregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Agregar_imagen;
        private System.Windows.Forms.TextBox txt_Artista;
        private System.Windows.Forms.TextBox txt_Nombre_Cancion;
        private System.Windows.Forms.TextBox txt_Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Duracion;
        private System.Windows.Forms.ComboBox cbo_Genero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Nuevo_Album;
        private System.Windows.Forms.GroupBox gb_Agregar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.TextBox txt_Id_Album;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
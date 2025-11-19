namespace WindowsFormsApp17
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMenuRecetas = new System.Windows.Forms.Panel();
            this.btnDescargarFav = new System.Windows.Forms.Button();
            this.btnEliminarFav = new System.Windows.Forms.Button();
            this.btnAgregarFav = new System.Windows.Forms.Button();
            this.cboTipoComida = new System.Windows.Forms.ComboBox();
            this.lblRegresar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbConsejos = new System.Windows.Forms.RadioButton();
            this.rdbRecetas = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picMenuFav = new System.Windows.Forms.PictureBox();
            this.lblVerPerfilUsuario = new System.Windows.Forms.Label();
            this.timerEstrellaAumentar = new System.Windows.Forms.Timer(this.components);
            this.timerEstrellaDisminuir = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlMenuRecetas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 434);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(268, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 434);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel3.Controls.Add(this.pnlMenuRecetas);
            this.panel3.Controls.Add(this.lblRegresar);
            this.panel3.Location = new System.Drawing.Point(0, -34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 469);
            this.panel3.TabIndex = 3;
            // 
            // pnlMenuRecetas
            // 
            this.pnlMenuRecetas.Controls.Add(this.btnDescargarFav);
            this.pnlMenuRecetas.Controls.Add(this.btnEliminarFav);
            this.pnlMenuRecetas.Controls.Add(this.btnAgregarFav);
            this.pnlMenuRecetas.Controls.Add(this.cboTipoComida);
            this.pnlMenuRecetas.Location = new System.Drawing.Point(4, 34);
            this.pnlMenuRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuRecetas.Name = "pnlMenuRecetas";
            this.pnlMenuRecetas.Size = new System.Drawing.Size(260, 372);
            this.pnlMenuRecetas.TabIndex = 16;
            // 
            // btnDescargarFav
            // 
            this.btnDescargarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarFav.Location = new System.Drawing.Point(44, 128);
            this.btnDescargarFav.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescargarFav.Name = "btnDescargarFav";
            this.btnDescargarFav.Size = new System.Drawing.Size(179, 52);
            this.btnDescargarFav.TabIndex = 19;
            this.btnDescargarFav.Text = "Descargar recetas favoritos";
            this.btnDescargarFav.UseVisualStyleBackColor = true;
            this.btnDescargarFav.Click += new System.EventHandler(this.btnDescargarFav_Click);
            // 
            // btnEliminarFav
            // 
            this.btnEliminarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFav.Location = new System.Drawing.Point(132, 56);
            this.btnEliminarFav.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarFav.Name = "btnEliminarFav";
            this.btnEliminarFav.Size = new System.Drawing.Size(120, 49);
            this.btnEliminarFav.TabIndex = 3;
            this.btnEliminarFav.Text = "Eliminar de Favoritos";
            this.btnEliminarFav.UseVisualStyleBackColor = true;
            this.btnEliminarFav.Click += new System.EventHandler(this.btnEliminarFav_Click);
            // 
            // btnAgregarFav
            // 
            this.btnAgregarFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFav.Location = new System.Drawing.Point(4, 56);
            this.btnAgregarFav.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarFav.Name = "btnAgregarFav";
            this.btnAgregarFav.Size = new System.Drawing.Size(120, 49);
            this.btnAgregarFav.TabIndex = 2;
            this.btnAgregarFav.Text = "Agregar a Favoritos";
            this.btnAgregarFav.UseVisualStyleBackColor = true;
            this.btnAgregarFav.Click += new System.EventHandler(this.btnAgregarFav_Click);
            // 
            // cboTipoComida
            // 
            this.cboTipoComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoComida.FormattingEnabled = true;
            this.cboTipoComida.Items.AddRange(new object[] {
            "Desayuno",
            "Comida",
            "Cena"});
            this.cboTipoComida.Location = new System.Drawing.Point(76, 11);
            this.cboTipoComida.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoComida.Name = "cboTipoComida";
            this.cboTipoComida.Size = new System.Drawing.Size(108, 24);
            this.cboTipoComida.TabIndex = 0;
            this.cboTipoComida.SelectedIndexChanged += new System.EventHandler(this.cboTipoComida_SelectedIndexChanged);
            // 
            // lblRegresar
            // 
            this.lblRegresar.AutoSize = true;
            this.lblRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(48)))));
            this.lblRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegresar.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegresar.Location = new System.Drawing.Point(27, 410);
            this.lblRegresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegresar.Name = "lblRegresar";
            this.lblRegresar.Size = new System.Drawing.Size(200, 47);
            this.lblRegresar.TabIndex = 6;
            this.lblRegresar.Text = "Regresar";
            this.lblRegresar.Click += new System.EventHandler(this.lblRegresar_Click);
            this.lblRegresar.MouseEnter += new System.EventHandler(this.lblRegresar_MouseEnter);
            this.lblRegresar.MouseLeave += new System.EventHandler(this.lblRegresar_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Consejos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.picMenuFav);
            this.panel1.Controls.Add(this.lblVerPerfilUsuario);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 123);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbConsejos);
            this.groupBox1.Controls.Add(this.rdbRecetas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(276, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(627, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rdbConsejos
            // 
            this.rdbConsejos.AutoSize = true;
            this.rdbConsejos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConsejos.Location = new System.Drawing.Point(379, 59);
            this.rdbConsejos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbConsejos.Name = "rdbConsejos";
            this.rdbConsejos.Size = new System.Drawing.Size(127, 35);
            this.rdbConsejos.TabIndex = 5;
            this.rdbConsejos.TabStop = true;
            this.rdbConsejos.Text = "Mostrar";
            this.rdbConsejos.UseVisualStyleBackColor = true;
            this.rdbConsejos.CheckedChanged += new System.EventHandler(this.rdbConsejos_CheckedChanged);
            // 
            // rdbRecetas
            // 
            this.rdbRecetas.AutoSize = true;
            this.rdbRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRecetas.Location = new System.Drawing.Point(119, 59);
            this.rdbRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRecetas.Name = "rdbRecetas";
            this.rdbRecetas.Size = new System.Drawing.Size(127, 35);
            this.rdbRecetas.TabIndex = 4;
            this.rdbRecetas.TabStop = true;
            this.rdbRecetas.Text = "Mostrar";
            this.rdbRecetas.UseVisualStyleBackColor = true;
            this.rdbRecetas.CheckedChanged += new System.EventHandler(this.rdbRecetas_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(34)))), ((int)(((byte)(71)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recetas";
            // 
            // picMenuFav
            // 
            this.picMenuFav.Image = ((System.Drawing.Image)(resources.GetObject("picMenuFav.Image")));
            this.picMenuFav.Location = new System.Drawing.Point(959, 44);
            this.picMenuFav.Margin = new System.Windows.Forms.Padding(4);
            this.picMenuFav.Name = "picMenuFav";
            this.picMenuFav.Size = new System.Drawing.Size(67, 62);
            this.picMenuFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuFav.TabIndex = 18;
            this.picMenuFav.TabStop = false;
            // 
            // lblVerPerfilUsuario
            // 
            this.lblVerPerfilUsuario.AutoSize = true;
            this.lblVerPerfilUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(23)))), ((int)(((byte)(48)))));
            this.lblVerPerfilUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVerPerfilUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVerPerfilUsuario.Font = new System.Drawing.Font("Bookman Old Style", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerPerfilUsuario.ForeColor = System.Drawing.Color.White;
            this.lblVerPerfilUsuario.Location = new System.Drawing.Point(12, 36);
            this.lblVerPerfilUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerPerfilUsuario.Name = "lblVerPerfilUsuario";
            this.lblVerPerfilUsuario.Size = new System.Drawing.Size(217, 45);
            this.lblVerPerfilUsuario.TabIndex = 4;
            this.lblVerPerfilUsuario.Text = "Ver perfil";
            this.lblVerPerfilUsuario.Click += new System.EventHandler(this.lblVerPerfilUsuario_Click);
            // 
            // timerEstrellaAumentar
            // 
            this.timerEstrellaAumentar.Tick += new System.EventHandler(this.timerEstrellaAumentar_Tick);
            // 
            // timerEstrellaDisminuir
            // 
            this.timerEstrellaDisminuir.Tick += new System.EventHandler(this.timerEstrellaDisminuir_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMenuRecetas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuFav)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVerPerfilUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbConsejos;
        private System.Windows.Forms.RadioButton rdbRecetas;
        private System.Windows.Forms.Timer timerEstrellaAumentar;
        private System.Windows.Forms.Timer timerEstrellaDisminuir;
        private System.Windows.Forms.Panel pnlMenuRecetas;
        private System.Windows.Forms.Button btnEliminarFav;
        private System.Windows.Forms.Button btnAgregarFav;
        private System.Windows.Forms.ComboBox cboTipoComida;
        private System.Windows.Forms.PictureBox picMenuFav;
        private System.Windows.Forms.Label lblRegresar;
        private System.Windows.Forms.Button btnDescargarFav;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
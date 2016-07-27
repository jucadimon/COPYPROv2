namespace COPYPROv2
{
    partial class FormCopypro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbGris = new System.Windows.Forms.RadioButton();
            this.rbRadar = new System.Windows.Forms.RadioButton();
            this.rbCereza = new System.Windows.Forms.RadioButton();
            this.rbJarvis = new System.Windows.Forms.RadioButton();
            this.rbIronMan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "C O P Y P R O";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(555, 9);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 21);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(12, 75);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(121, 30);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar a TXT...";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(139, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCaja
            // 
            this.txtCaja.AcceptsReturn = true;
            this.txtCaja.AcceptsTab = true;
            this.txtCaja.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCaja.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtCaja.ForeColor = System.Drawing.Color.Snow;
            this.txtCaja.Location = new System.Drawing.Point(12, 112);
            this.txtCaja.Multiline = true;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCaja.Size = new System.Drawing.Size(680, 270);
            this.txtCaja.TabIndex = 4;
            this.txtCaja.Text = "Escriba aquí...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRANSPARENCIA:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(84, 415);
            this.trackBar1.Maximum = 99;
            this.trackBar1.Minimum = 40;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(123, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 75;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(609, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 21);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(637, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 21);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.Text = "|_|";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(668, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(18, 21);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbGris);
            this.groupBox1.Controls.Add(this.rbRadar);
            this.groupBox1.Controls.Add(this.rbCereza);
            this.groupBox1.Controls.Add(this.rbJarvis);
            this.groupBox1.Controls.Add(this.rbIronMan);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 42);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(347, 18);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(80, 16);
            this.rbNormal.TabIndex = 5;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Reestablecer";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.rbNormal_CheckedChanged);
            // 
            // rbGris
            // 
            this.rbGris.AutoSize = true;
            this.rbGris.Location = new System.Drawing.Point(289, 18);
            this.rbGris.Name = "rbGris";
            this.rbGris.Size = new System.Drawing.Size(41, 16);
            this.rbGris.TabIndex = 4;
            this.rbGris.Text = "Gris";
            this.rbGris.UseVisualStyleBackColor = true;
            this.rbGris.CheckedChanged += new System.EventHandler(this.rbGris_CheckedChanged);
            // 
            // rbRadar
            // 
            this.rbRadar.AutoSize = true;
            this.rbRadar.Location = new System.Drawing.Point(221, 18);
            this.rbRadar.Name = "rbRadar";
            this.rbRadar.Size = new System.Drawing.Size(49, 16);
            this.rbRadar.TabIndex = 3;
            this.rbRadar.Text = "Radar";
            this.rbRadar.UseVisualStyleBackColor = true;
            this.rbRadar.CheckedChanged += new System.EventHandler(this.rbRadar_CheckedChanged);
            // 
            // rbCereza
            // 
            this.rbCereza.AutoSize = true;
            this.rbCereza.Location = new System.Drawing.Point(153, 18);
            this.rbCereza.Name = "rbCereza";
            this.rbCereza.Size = new System.Drawing.Size(53, 16);
            this.rbCereza.TabIndex = 2;
            this.rbCereza.Text = "Cereza";
            this.rbCereza.UseVisualStyleBackColor = true;
            this.rbCereza.CheckedChanged += new System.EventHandler(this.rbCereza_CheckedChanged);
            // 
            // rbJarvis
            // 
            this.rbJarvis.AutoSize = true;
            this.rbJarvis.Location = new System.Drawing.Point(85, 18);
            this.rbJarvis.Name = "rbJarvis";
            this.rbJarvis.Size = new System.Drawing.Size(48, 16);
            this.rbJarvis.TabIndex = 1;
            this.rbJarvis.Text = "Jarvis";
            this.rbJarvis.UseVisualStyleBackColor = true;
            this.rbJarvis.CheckedChanged += new System.EventHandler(this.rbJarvis_CheckedChanged);
            // 
            // rbIronMan
            // 
            this.rbIronMan.AutoSize = true;
            this.rbIronMan.Location = new System.Drawing.Point(17, 18);
            this.rbIronMan.Name = "rbIronMan";
            this.rbIronMan.Size = new System.Drawing.Size(62, 16);
            this.rbIronMan.TabIndex = 0;
            this.rbIronMan.Text = "IronMan";
            this.rbIronMan.UseVisualStyleBackColor = true;
            this.rbIronMan.CheckedChanged += new System.EventHandler(this.rbIronMan_CheckedChanged);
            // 
            // FormCopypro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormCopypro";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COPYPRO v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCopypro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbGris;
        private System.Windows.Forms.RadioButton rbRadar;
        private System.Windows.Forms.RadioButton rbCereza;
        private System.Windows.Forms.RadioButton rbJarvis;
        private System.Windows.Forms.RadioButton rbIronMan;

    }
}


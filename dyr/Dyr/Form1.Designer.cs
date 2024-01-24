namespace Dyr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnPracticar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbCargar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.atras1 = new System.Windows.Forms.Button();
            this.btnGbCargar = new System.Windows.Forms.Button();
            this.txbCargarMeaning = new System.Windows.Forms.TextBox();
            this.txbCargarWord = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.btnCargarNo = new System.Windows.Forms.Button();
            this.btnCargarSi = new System.Windows.Forms.Button();
            this.btnCargarMostrar = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.gbPracticar = new System.Windows.Forms.GroupBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.atras2 = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.atras3 = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.btnResultadoAtras = new System.Windows.Forms.Button();
            this.btnResultadoDenuevo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbCargar.SuspendLayout();
            this.gbPracticar.SuspendLayout();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(74, 33);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 39);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar Palabra";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnPracticar
            // 
            this.btnPracticar.Location = new System.Drawing.Point(343, 33);
            this.btnPracticar.Name = "btnPracticar";
            this.btnPracticar.Size = new System.Drawing.Size(75, 39);
            this.btnPracticar.TabIndex = 0;
            this.btnPracticar.Text = "Practicar";
            this.btnPracticar.UseVisualStyleBackColor = true;
            this.btnPracticar.Click += new System.EventHandler(this.btnPracticar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(590, 33);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 39);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbCargar
            // 
            this.gbCargar.Controls.Add(this.label2);
            this.gbCargar.Controls.Add(this.label1);
            this.gbCargar.Controls.Add(this.atras1);
            this.gbCargar.Controls.Add(this.btnGbCargar);
            this.gbCargar.Controls.Add(this.txbCargarMeaning);
            this.gbCargar.Controls.Add(this.txbCargarWord);
            this.gbCargar.Location = new System.Drawing.Point(35, 165);
            this.gbCargar.Name = "gbCargar";
            this.gbCargar.Size = new System.Drawing.Size(235, 155);
            this.gbCargar.TabIndex = 1;
            this.gbCargar.TabStop = false;
            this.gbCargar.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Significado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Palabra:";
            // 
            // atras1
            // 
            this.atras1.Location = new System.Drawing.Point(187, 19);
            this.atras1.Name = "atras1";
            this.atras1.Size = new System.Drawing.Size(42, 23);
            this.atras1.TabIndex = 3;
            this.atras1.Text = "Atrás";
            this.atras1.UseVisualStyleBackColor = true;
            this.atras1.Click += new System.EventHandler(this.atras1_Click);
            // 
            // btnGbCargar
            // 
            this.btnGbCargar.Location = new System.Drawing.Point(75, 116);
            this.btnGbCargar.Name = "btnGbCargar";
            this.btnGbCargar.Size = new System.Drawing.Size(75, 23);
            this.btnGbCargar.TabIndex = 2;
            this.btnGbCargar.Text = "Cargar";
            this.btnGbCargar.UseVisualStyleBackColor = true;
            this.btnGbCargar.Click += new System.EventHandler(this.btnGbCargar_Click);
            // 
            // txbCargarMeaning
            // 
            this.txbCargarMeaning.Location = new System.Drawing.Point(75, 81);
            this.txbCargarMeaning.Name = "txbCargarMeaning";
            this.txbCargarMeaning.Size = new System.Drawing.Size(100, 20);
            this.txbCargarMeaning.TabIndex = 1;
            // 
            // txbCargarWord
            // 
            this.txbCargarWord.Location = new System.Drawing.Point(75, 47);
            this.txbCargarWord.Name = "txbCargarWord";
            this.txbCargarWord.Size = new System.Drawing.Size(100, 20);
            this.txbCargarWord.TabIndex = 0;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblMeaning.Location = new System.Drawing.Point(84, 119);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(75, 28);
            this.lblMeaning.TabIndex = 4;
            this.lblMeaning.Text = "label1";
            // 
            // btnCargarNo
            // 
            this.btnCargarNo.Location = new System.Drawing.Point(197, 168);
            this.btnCargarNo.Name = "btnCargarNo";
            this.btnCargarNo.Size = new System.Drawing.Size(31, 23);
            this.btnCargarNo.TabIndex = 3;
            this.btnCargarNo.Text = "No";
            this.btnCargarNo.UseVisualStyleBackColor = true;
            this.btnCargarNo.Click += new System.EventHandler(this.btnCargarNo_Click);
            // 
            // btnCargarSi
            // 
            this.btnCargarSi.Location = new System.Drawing.Point(40, 168);
            this.btnCargarSi.Name = "btnCargarSi";
            this.btnCargarSi.Size = new System.Drawing.Size(31, 23);
            this.btnCargarSi.TabIndex = 2;
            this.btnCargarSi.Text = "Si";
            this.btnCargarSi.UseVisualStyleBackColor = true;
            this.btnCargarSi.Click += new System.EventHandler(this.btnCargarSi_Click);
            // 
            // btnCargarMostrar
            // 
            this.btnCargarMostrar.Location = new System.Drawing.Point(84, 88);
            this.btnCargarMostrar.Name = "btnCargarMostrar";
            this.btnCargarMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnCargarMostrar.TabIndex = 1;
            this.btnCargarMostrar.Text = "Mostrar";
            this.btnCargarMostrar.UseVisualStyleBackColor = true;
            this.btnCargarMostrar.Click += new System.EventHandler(this.btnCargarMostrar_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(79, 53);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(75, 28);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label1";
            // 
            // gbPracticar
            // 
            this.gbPracticar.Controls.Add(this.lblPregunta);
            this.gbPracticar.Controls.Add(this.atras2);
            this.gbPracticar.Controls.Add(this.lblMeaning);
            this.gbPracticar.Controls.Add(this.lblWord);
            this.gbPracticar.Controls.Add(this.btnCargarNo);
            this.gbPracticar.Controls.Add(this.btnCargarMostrar);
            this.gbPracticar.Controls.Add(this.btnCargarSi);
            this.gbPracticar.Location = new System.Drawing.Point(259, 96);
            this.gbPracticar.Name = "gbPracticar";
            this.gbPracticar.Size = new System.Drawing.Size(265, 224);
            this.gbPracticar.TabIndex = 2;
            this.gbPracticar.TabStop = false;
            this.gbPracticar.Text = "groupBox1";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(91, 157);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(84, 13);
            this.lblPregunta.TabIndex = 5;
            this.lblPregunta.Text = "¿Lo recordaste?";
            // 
            // atras2
            // 
            this.atras2.Location = new System.Drawing.Point(197, 19);
            this.atras2.Name = "atras2";
            this.atras2.Size = new System.Drawing.Size(42, 23);
            this.atras2.TabIndex = 3;
            this.atras2.Text = "Atrás";
            this.atras2.UseVisualStyleBackColor = true;
            this.atras2.Click += new System.EventHandler(this.atras2_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.dataGridView1);
            this.gbEditar.Controls.Add(this.atras3);
            this.gbEditar.Location = new System.Drawing.Point(504, 96);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(271, 224);
            this.gbEditar.TabIndex = 3;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(231, 158);
            this.dataGridView1.TabIndex = 4;
            // 
            // atras3
            // 
            this.atras3.Location = new System.Drawing.Point(187, 19);
            this.atras3.Name = "atras3";
            this.atras3.Size = new System.Drawing.Size(42, 23);
            this.atras3.TabIndex = 3;
            this.atras3.Text = "Atrás";
            this.atras3.UseVisualStyleBackColor = true;
            this.atras3.Click += new System.EventHandler(this.atras3_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.btnResultadoAtras);
            this.gbResultado.Controls.Add(this.btnResultadoDenuevo);
            this.gbResultado.Controls.Add(this.lblResultado);
            this.gbResultado.Location = new System.Drawing.Point(12, 57);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(280, 155);
            this.gbResultado.TabIndex = 4;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "groupBox1";
            // 
            // btnResultadoAtras
            // 
            this.btnResultadoAtras.Location = new System.Drawing.Point(187, 19);
            this.btnResultadoAtras.Name = "btnResultadoAtras";
            this.btnResultadoAtras.Size = new System.Drawing.Size(42, 23);
            this.btnResultadoAtras.TabIndex = 2;
            this.btnResultadoAtras.Text = "Atrás";
            this.btnResultadoAtras.UseVisualStyleBackColor = true;
            this.btnResultadoAtras.Click += new System.EventHandler(this.btnResultadoAtras_Click);
            // 
            // btnResultadoDenuevo
            // 
            this.btnResultadoDenuevo.Location = new System.Drawing.Point(72, 98);
            this.btnResultadoDenuevo.Name = "btnResultadoDenuevo";
            this.btnResultadoDenuevo.Size = new System.Drawing.Size(95, 23);
            this.btnResultadoDenuevo.TabIndex = 1;
            this.btnResultadoDenuevo.Text = "Jugar de nuevo";
            this.btnResultadoDenuevo.UseVisualStyleBackColor = true;
            this.btnResultadoDenuevo.Click += new System.EventHandler(this.btnResultadoDenuevo_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(23, 50);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 28);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.gbPracticar);
            this.Controls.Add(this.gbCargar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPracticar);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargar.ResumeLayout(false);
            this.gbCargar.PerformLayout();
            this.gbPracticar.ResumeLayout(false);
            this.gbPracticar.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnPracticar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbCargar;
        private System.Windows.Forms.GroupBox gbPracticar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Button btnCargarMostrar;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnCargarNo;
        private System.Windows.Forms.Button btnCargarSi;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Button btnGbCargar;
        private System.Windows.Forms.TextBox txbCargarMeaning;
        private System.Windows.Forms.TextBox txbCargarWord;
        private System.Windows.Forms.Button atras1;
        private System.Windows.Forms.Button atras2;
        private System.Windows.Forms.Button atras3;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Button btnResultadoAtras;
        private System.Windows.Forms.Button btnResultadoDenuevo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


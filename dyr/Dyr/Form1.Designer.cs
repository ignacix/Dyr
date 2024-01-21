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
            this.btnGbCargar = new System.Windows.Forms.Button();
            this.txbCargarMeaning = new System.Windows.Forms.TextBox();
            this.txbCargarWord = new System.Windows.Forms.TextBox();
            this.lblCargarMeaning = new System.Windows.Forms.Label();
            this.btnCargarNo = new System.Windows.Forms.Button();
            this.btnCargarSi = new System.Windows.Forms.Button();
            this.btnCargarMostrar = new System.Windows.Forms.Button();
            this.lblCargarPalabra = new System.Windows.Forms.Label();
            this.gbPracticar = new System.Windows.Forms.GroupBox();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.atras1 = new System.Windows.Forms.Button();
            this.atras2 = new System.Windows.Forms.Button();
            this.atras3 = new System.Windows.Forms.Button();
            this.gbCargar.SuspendLayout();
            this.gbPracticar.SuspendLayout();
            this.gbEditar.SuspendLayout();
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
            // 
            // gbCargar
            // 
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
            // btnGbCargar
            // 
            this.btnGbCargar.Location = new System.Drawing.Point(63, 126);
            this.btnGbCargar.Name = "btnGbCargar";
            this.btnGbCargar.Size = new System.Drawing.Size(75, 23);
            this.btnGbCargar.TabIndex = 2;
            this.btnGbCargar.Text = "button1";
            this.btnGbCargar.UseVisualStyleBackColor = true;
            this.btnGbCargar.Click += new System.EventHandler(this.btnGbCargar_Click);
            // 
            // txbCargarMeaning
            // 
            this.txbCargarMeaning.Location = new System.Drawing.Point(52, 99);
            this.txbCargarMeaning.Name = "txbCargarMeaning";
            this.txbCargarMeaning.Size = new System.Drawing.Size(100, 20);
            this.txbCargarMeaning.TabIndex = 1;
            // 
            // txbCargarWord
            // 
            this.txbCargarWord.Location = new System.Drawing.Point(47, 45);
            this.txbCargarWord.Name = "txbCargarWord";
            this.txbCargarWord.Size = new System.Drawing.Size(100, 20);
            this.txbCargarWord.TabIndex = 0;
            // 
            // lblCargarMeaning
            // 
            this.lblCargarMeaning.AutoSize = true;
            this.lblCargarMeaning.Location = new System.Drawing.Point(94, 100);
            this.lblCargarMeaning.Name = "lblCargarMeaning";
            this.lblCargarMeaning.Size = new System.Drawing.Size(35, 13);
            this.lblCargarMeaning.TabIndex = 4;
            this.lblCargarMeaning.Text = "label1";
            // 
            // btnCargarNo
            // 
            this.btnCargarNo.Location = new System.Drawing.Point(157, 116);
            this.btnCargarNo.Name = "btnCargarNo";
            this.btnCargarNo.Size = new System.Drawing.Size(31, 23);
            this.btnCargarNo.TabIndex = 3;
            this.btnCargarNo.Text = "No";
            this.btnCargarNo.UseVisualStyleBackColor = true;
            // 
            // btnCargarSi
            // 
            this.btnCargarSi.Location = new System.Drawing.Point(36, 116);
            this.btnCargarSi.Name = "btnCargarSi";
            this.btnCargarSi.Size = new System.Drawing.Size(31, 23);
            this.btnCargarSi.TabIndex = 2;
            this.btnCargarSi.Text = "Si";
            this.btnCargarSi.UseVisualStyleBackColor = true;
            // 
            // btnCargarMostrar
            // 
            this.btnCargarMostrar.Location = new System.Drawing.Point(79, 65);
            this.btnCargarMostrar.Name = "btnCargarMostrar";
            this.btnCargarMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnCargarMostrar.TabIndex = 1;
            this.btnCargarMostrar.Text = "Mostrar";
            this.btnCargarMostrar.UseVisualStyleBackColor = true;
            // 
            // lblCargarPalabra
            // 
            this.lblCargarPalabra.AutoSize = true;
            this.lblCargarPalabra.Location = new System.Drawing.Point(94, 32);
            this.lblCargarPalabra.Name = "lblCargarPalabra";
            this.lblCargarPalabra.Size = new System.Drawing.Size(35, 13);
            this.lblCargarPalabra.TabIndex = 0;
            this.lblCargarPalabra.Text = "label1";
            // 
            // gbPracticar
            // 
            this.gbPracticar.Controls.Add(this.atras2);
            this.gbPracticar.Controls.Add(this.lblCargarMeaning);
            this.gbPracticar.Controls.Add(this.lblCargarPalabra);
            this.gbPracticar.Controls.Add(this.btnCargarNo);
            this.gbPracticar.Controls.Add(this.btnCargarMostrar);
            this.gbPracticar.Controls.Add(this.btnCargarSi);
            this.gbPracticar.Location = new System.Drawing.Point(289, 165);
            this.gbPracticar.Name = "gbPracticar";
            this.gbPracticar.Size = new System.Drawing.Size(235, 155);
            this.gbPracticar.TabIndex = 2;
            this.gbPracticar.TabStop = false;
            this.gbPracticar.Text = "groupBox1";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.atras3);
            this.gbEditar.Location = new System.Drawing.Point(540, 165);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(235, 155);
            this.gbEditar.TabIndex = 3;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "groupBox1";
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
            // atras2
            // 
            this.atras2.Location = new System.Drawing.Point(187, 19);
            this.atras2.Name = "atras2";
            this.atras2.Size = new System.Drawing.Size(42, 23);
            this.atras2.TabIndex = 3;
            this.atras2.Text = "Atrás";
            this.atras2.UseVisualStyleBackColor = true;
            this.atras2.Click += new System.EventHandler(this.atras2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label lblCargarPalabra;
        private System.Windows.Forms.Button btnCargarNo;
        private System.Windows.Forms.Button btnCargarSi;
        private System.Windows.Forms.Label lblCargarMeaning;
        private System.Windows.Forms.Button btnGbCargar;
        private System.Windows.Forms.TextBox txbCargarMeaning;
        private System.Windows.Forms.TextBox txbCargarWord;
        private System.Windows.Forms.Button atras1;
        private System.Windows.Forms.Button atras2;
        private System.Windows.Forms.Button atras3;
    }
}


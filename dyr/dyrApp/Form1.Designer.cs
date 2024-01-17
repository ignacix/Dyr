namespace dyrApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txbPalabra = new System.Windows.Forms.TextBox();
            this.txbDefinición = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btngbCargar = new System.Windows.Forms.Button();
            this.btnAtrasgbCargar = new System.Windows.Forms.Button();
            this.btnPracticar = new System.Windows.Forms.Button();
            this.gbPracticar = new System.Windows.Forms.GroupBox();
            this.lblmeaning = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.gbCargar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResultadoAtras = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPracticar.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s start!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(93, 223);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(118, 60);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Palabras";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txbPalabra
            // 
            this.txbPalabra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPalabra.Location = new System.Drawing.Point(131, 52);
            this.txbPalabra.Name = "txbPalabra";
            this.txbPalabra.Size = new System.Drawing.Size(100, 20);
            this.txbPalabra.TabIndex = 0;
            // 
            // txbDefinición
            // 
            this.txbDefinición.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDefinición.Location = new System.Drawing.Point(131, 120);
            this.txbDefinición.Name = "txbDefinición";
            this.txbDefinición.Size = new System.Drawing.Size(100, 20);
            this.txbDefinición.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // btngbCargar
            // 
            this.btngbCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btngbCargar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngbCargar.Location = new System.Drawing.Point(140, 161);
            this.btngbCargar.Name = "btngbCargar";
            this.btngbCargar.Size = new System.Drawing.Size(79, 36);
            this.btngbCargar.TabIndex = 3;
            this.btngbCargar.Text = "Cargar";
            this.btngbCargar.UseVisualStyleBackColor = true;
            this.btngbCargar.Click += new System.EventHandler(this.btngbCargar_Click);
            // 
            // btnAtrasgbCargar
            // 
            this.btnAtrasgbCargar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAtrasgbCargar.Location = new System.Drawing.Point(288, 45);
            this.btnAtrasgbCargar.Name = "btnAtrasgbCargar";
            this.btnAtrasgbCargar.Size = new System.Drawing.Size(43, 23);
            this.btnAtrasgbCargar.TabIndex = 4;
            this.btnAtrasgbCargar.Text = "Atrás";
            this.btnAtrasgbCargar.UseVisualStyleBackColor = true;
            this.btnAtrasgbCargar.Click += new System.EventHandler(this.btnAtrasgbCargar_Click);
            // 
            // btnPracticar
            // 
            this.btnPracticar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPracticar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticar.Location = new System.Drawing.Point(343, 223);
            this.btnPracticar.Name = "btnPracticar";
            this.btnPracticar.Size = new System.Drawing.Size(118, 60);
            this.btnPracticar.TabIndex = 3;
            this.btnPracticar.Text = "Practicar";
            this.btnPracticar.UseVisualStyleBackColor = true;
            this.btnPracticar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbPracticar
            // 
            this.gbPracticar.Controls.Add(this.lblmeaning);
            this.gbPracticar.Controls.Add(this.lblAsk);
            this.gbPracticar.Controls.Add(this.btnNo);
            this.gbPracticar.Controls.Add(this.btnSi);
            this.gbPracticar.Controls.Add(this.btnMostrar);
            this.gbPracticar.Controls.Add(this.lblWord);
            this.gbPracticar.Location = new System.Drawing.Point(325, 305);
            this.gbPracticar.Name = "gbPracticar";
            this.gbPracticar.Size = new System.Drawing.Size(352, 248);
            this.gbPracticar.TabIndex = 4;
            this.gbPracticar.TabStop = false;
            // 
            // lblmeaning
            // 
            this.lblmeaning.AutoSize = true;
            this.lblmeaning.Location = new System.Drawing.Point(155, 99);
            this.lblmeaning.Name = "lblmeaning";
            this.lblmeaning.Size = new System.Drawing.Size(35, 13);
            this.lblmeaning.TabIndex = 5;
            this.lblmeaning.Text = "label5";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Location = new System.Drawing.Point(96, 175);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(159, 13);
            this.lblAsk.TabIndex = 4;
            this.lblAsk.Text = "Did you remember the meaning?";
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(213, 203);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(40, 203);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(130, 123);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(151, 61);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(35, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label4";
            // 
            // gbResultado
            // 
            this.gbResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbResultado.Controls.Add(this.gbCargar);
            this.gbResultado.Controls.Add(this.button1);
            this.gbResultado.Controls.Add(this.btnResultadoAtras);
            this.gbResultado.Controls.Add(this.lblResultado);
            this.gbResultado.Location = new System.Drawing.Point(27, 12);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(351, 248);
            this.gbResultado.TabIndex = 5;
            this.gbResultado.TabStop = false;
            // 
            // gbCargar
            // 
            this.gbCargar.Location = new System.Drawing.Point(0, 26);
            this.gbCargar.Name = "gbCargar";
            this.gbCargar.Size = new System.Drawing.Size(351, 241);
            this.gbCargar.TabIndex = 7;
            this.gbCargar.TabStop = false;
            this.gbCargar.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seguir practicando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnResultadoAtras
            // 
            this.btnResultadoAtras.Location = new System.Drawing.Point(293, 28);
            this.btnResultadoAtras.Name = "btnResultadoAtras";
            this.btnResultadoAtras.Size = new System.Drawing.Size(41, 23);
            this.btnResultadoAtras.TabIndex = 1;
            this.btnResultadoAtras.Text = "Atrás";
            this.btnResultadoAtras.UseVisualStyleBackColor = true;
            this.btnResultadoAtras.Click += new System.EventHandler(this.btnResultadoAtras_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(154, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(35, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label5";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(595, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(118, 60);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.dataGridView1);
            this.gbEditar.Location = new System.Drawing.Point(437, 31);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(351, 248);
            this.gbEditar.TabIndex = 6;
            this.gbEditar.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.gbPracticar);
            this.Controls.Add(this.btnPracticar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPracticar.ResumeLayout(false);
            this.gbPracticar.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txbPalabra;
        private System.Windows.Forms.TextBox txbDefinición;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btngbCargar;        
        private System.Windows.Forms.Button btnAtrasgbCargar;
        private System.Windows.Forms.Button btnPracticar;
        private System.Windows.Forms.GroupBox gbPracticar;
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblmeaning;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnResultadoAtras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbCargar;
    }
}

